USE [AldairDouglasLizeth_NotasDB]
GO

-- Crear tabla Materias
CREATE TABLE Materias
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Docente NVARCHAR(50) NOT NULL,
    GradoId INT NOT NULL,
    FOREIGN KEY (GradoId) REFERENCES Grados(Id)
);
GO

--------------------------------
SELECT *
FROM sys.procedures
WHERE name = 'SP_CrudMaterias';
-------------------------------------------


USE [AldairDouglasLizeth_NotasDB]
GO

--Configuraciones de ANSI_NULLS y QUOTED_IDENTIFIER
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Crear o modificar el procedimiento almacenado SP_CrudMaterias
ALTER PROCEDURE [dbo].[SP_CrudMaterias]
(
    @intProceso            INT,
    @intId                INT = NULL,
    @strNombre            NVARCHAR(50) = NULL,
    @strDocenteId        NVARCHAR(20) = NULL,
    @intGradoId            INT = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Variables
    DECLARE @intRegistros INT,
            @strNombreCompleto NVARCHAR(100);

    -- 2 - INSERT 
    IF @intProceso = 2
    BEGIN 
        -- Verificar si el grado existe
        IF NOT EXISTS (SELECT 1 FROM Grados WHERE Id = @intGradoId)
        BEGIN
            SELECT 300 AS error;
            RETURN;
        END

        -- Verificar si el docente existe
        IF NOT EXISTS (SELECT 1 FROM Docente WHERE Id = @strDocenteId)
        BEGIN
            SELECT 301 AS error;
            RETURN;
        END

        BEGIN TRANSACTION;

        -- Insertar la materia
        INSERT INTO Materias (Nombre, DocenteId, GradoId)
        VALUES (@strNombre, @strDocenteId, @intGradoId);

        -- Obtener el nombre completo del docente
        SELECT @strNombreCompleto = NombreCompleto
        FROM Docente
        WHERE Id = @strDocenteId;

        -- Actualizar la tabla Materias con el nombre completo del docente
        UPDATE Materias
        SET NombreCompleto = @strNombreCompleto
        WHERE Id = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
    END
END


-------------------------------------------

CREATE TABLE Docente
(
    Id NVARCHAR(20) PRIMARY KEY,
    NombreCompleto NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Direccion NVARCHAR(100) NOT NULL,
    Especialidad NVARCHAR(50) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL
);
-------------------------------------------------------
INSERT INTO Docente (Id, NombreCompleto, FechaNacimiento, Direccion, Especialidad, Telefono)
VALUES 
    ('D001', 'Juan Pérez', '1980-05-15', 'Calle Principal 123', 'Matemáticas', '123456789'),
    ('D002', 'María García', '1975-08-20', 'Avenida Central 456', 'Física', '987654321'),
    ('D003', 'Pedro Martínez', '1982-11-10', 'Carrera 7 890', 'Naturales', '555444333'),
    ('D004', 'Ana López', '1978-03-25', 'Calle Secundaria 789', 'Historia', '666777888'),
    ('D005', 'Carlos Rodríguez', '1985-09-03', 'Avenida Principal 567', 'Química', '999888777');

----------------------------------------------------------------
CREATE TABLE Materias (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    DocenteId NVARCHAR(20),
    NombreCompleto NVARCHAR(100),
    GradoId INT,
    FOREIGN KEY (DocenteId) REFERENCES Docente(Id),
    FOREIGN KEY (GradoId) REFERENCES Grados(Id)
);

---------------Tabla Intermedia para la Relación Profesor-Materia-----------------

CREATE TABLE ProfesorMateria
(
    ProfesorId NVARCHAR(20),
    MateriaId INT,
    PRIMARY KEY (ProfesorId, MateriaId),
    FOREIGN KEY (ProfesorId) REFERENCES Docente(Id),
    FOREIGN KEY (MateriaId) REFERENCES Materias(Id)
);

-----------------------------------------------
-- agregamos el nombre del docente que se vea en la consulta
 ALTER TABLE Materias
ADD NombreCompleto NVARCHAR(100);

UPDATE M
SET M.NombreCompleto = D.NombreCompleto
FROM Materias M
JOIN Docente D ON M.DocenteId = D.Id;

drop table Materias

select * from Materias
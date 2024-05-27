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
    @intProceso INT,
    @intId INT = NULL,
    @strNombre NVARCHAR(50) = NULL,
    @strDocente NVARCHAR(50) = NULL,
    @intGradoId INT = NULL
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT;

    -- 1 - SELECT
    IF @intProceso = 1
    BEGIN
        SELECT
            [Id],
            [Nombre],
            [Docente],
            [GradoId]
        FROM [AldairDouglasLizeth_NotasDB].[dbo].[Materias] WITH(NOLOCK)
        WHERE ([Id] = @intId OR @intId IS NULL);
    END

    -- 2 - INSERT
    IF @intProceso = 2
    BEGIN
        SELECT TOP 1 @intRegistros = 1
        FROM [AldairDouglasLizeth_NotasDB].[dbo].[Materias] WITH(NOLOCK)
        WHERE ([Nombre] = @strNombre AND [GradoId] = @intGradoId);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 300 AS error;
            RETURN;
        END

        BEGIN TRANSACTION
            INSERT INTO [AldairDouglasLizeth_NotasDB].[dbo].[Materias]
            (
                [Nombre],
                [Docente],
                [GradoId]
            )
            VALUES
            (
                @strNombre,
                @strDocente,
                @intGradoId
            );
        COMMIT TRANSACTION
    END

    -- 3 - UPDATE
    IF @intProceso = 3
    BEGIN
        BEGIN TRANSACTION
            UPDATE [AldairDouglasLizeth_NotasDB].[dbo].[Materias]
            SET
                [Nombre] = @strNombre,
                [Docente] = @strDocente,
                [GradoId] = @intGradoId
            WHERE ([Id] = @intId);
        COMMIT TRANSACTION
    END

    -- 4 - DELETE
    IF @intProceso = 4
    BEGIN
        DELETE FROM [AldairDouglasLizeth_NotasDB].[dbo].[Materias]
        WHERE ([Id] = @intId);
    END
END
GO




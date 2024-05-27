-- creacion tabla grados

CREATE TABLE Grados (
    Id INT PRIMARY KEY,
    Nombre NVARCHAR(20) NOT NULL
);

-- Tabla de asignación de estudiantes a grados
CREATE TABLE EstudiantesGrados (
    EstudianteId NVARCHAR(20),
    GradoId INT,
    FOREIGN KEY (EstudianteId) REFERENCES Estudiantes(ID),
    FOREIGN KEY (GradoId) REFERENCES Grados(Id),
    PRIMARY KEY (EstudianteId, GradoId)
);

-- Consulta para visualizar la lista de estudiantes por grado
SELECT g.Nombre AS Grado, e.Nombres, e.Apellidos, e.FechaNacimiento, e.Direccion, e.Telefono
FROM Grados g
INNER JOIN EstudiantesGrados eg ON g.Id = eg.GradoId
INNER JOIN Estudiantes e ON eg.EstudianteId = e.ID
ORDER BY g.Nombre, e.Nombres, e.Apellidos;

INSERT INTO Grados (Id, Nombre) VALUES (6, 'Sexto');
INSERT INTO Grados (Id, Nombre) VALUES (7, 'Séptimo');
INSERT INTO Grados (Id, Nombre) VALUES (8, 'Octavo');
INSERT INTO Grados (Id, Nombre) VALUES (9, 'Noveno');
INSERT INTO Grados (Id, Nombre) VALUES (10, 'Décimo');
INSERT INTO Grados (Id, Nombre) VALUES (11, 'Once');




-- Inserta registros en la tabla EstudiantesGrados
INSERT INTO EstudiantesGrados (EstudianteId, GradoId) VALUES
('56789', 6),
('5685455', 6),
('AFDFASDFAS', 7),
('ASDFADFASF', 8),
('ID1', 9),
('ID2', 10),
('ID3', 11),
('ID4', 11);





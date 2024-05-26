--creamos el procedimiento para la tabla estudiantes
CREATE PROCEDURE [dbo].[SP_CrudEstudiantes]
(
    @Nombres NVARCHAR(50),
    @Apellidos NVARCHAR(50),
    @FechaNacimiento DATE,
    @Direccion NVARCHAR(100),
    @Telefono NVARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

   

END;


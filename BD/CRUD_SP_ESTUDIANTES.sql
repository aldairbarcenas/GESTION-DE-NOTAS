USE [AldairDouglasLizeth_NotasDB]
GO
--Configuraciones de ANSI_NULLS y QUOTED_IDENTIFIER
SET ANSI_NULLS ON --Indica que las comparaciones con valores nulos (NULL) sigan el comportamiento est�ndar ANSI.
GO
SET QUOTED_IDENTIFIER ON -- Indica que se deben usar comillas dobles (") para delimitar identificadores.
GO

ALTER     PROCEDURE [dbo].[SP_CrudEstudiantes]
(
	@intProceso				        INT,
	@intId							NVARCHAR(20) = NULL,
	@strNombres	    			    NVARCHAR(50) = NULL,
	@strApelllidos    			    NVARCHAR(50) = NULL,
    @dateFechaNacimiento            DATETIME = NULL,
	@strDireccion	                NVARCHAR(100) = NULL,
    @strTelefono    			    NVARCHAR(20) = NULL
)
AS
BEGIN
    SET NOCOUNT ON; --evitar que SQL Server env�e mensajes de conteo de filas afectadas al cliente
    DECLARE @intRegistros INT --declaramos la variable intRegistros

	--1 - SELECT    
	IF @intProceso = 1  --Si recibe un 1 realiza el Select
		BEGIN
			SELECT
				[Id],
				[Nombres],
				[Apellidos],
				[FechaNacimiento],
				[Direccion],
				[Telefono] --WITH(NOLOCK): Esta cl�usula se utiliza para realizar una lectura sin bloqueo
			FROM [AldairDouglasLizeth_NotasDB].[dbo].[Estudiantes] WITH(NOLOCK) -- de la base de datos aldair de la tabla estudiantes
			WHERE ([Nombres] = @strNombres OR @strNombres IS NULL); --si el valor de nombre coincide con el buscado lo filtra, sino los muestra todos
    END

	--2 - INSERT 
    IF @intProceso = 2 --recibir un 2 para insert
    BEGIN 
        SELECT TOP 1 @intRegistros = 1 --obtener el primer regustro en la tabla estudiantes donde el nombre coincida con el buscado
        FROM [AldairDouglasLizeth_NotasDB].[dbo].[Estudiantes] WITH(NOLOCK) --este primer registro de esta BD y esta tabla
        WHERE ([Nombres] = @strNombres);--donde verificar si el nombre existe

        IF @@ROWCOUNT = 1 --si se encuentra un registro sera igual a 1
        BEGIN
            SELECT 300 AS error -- de ser asi arrojar el numero 300 como un error
            RETURN
        END
		-- si el registro no existe se inicia una transaccion
       BEGIN TRANSACTION --e la operaci�n se realizar� completamente o no se realizar� en absoluto.
			INSERT INTO [AldairDouglasLizeth_NotasDB].[dbo].[Estudiantes]
			(
				[ID],
				[Nombres],
				[Apellidos],
				[FechaNacimiento],
				[Direccion],
				[Telefono]
			)
			VALUES
			(
                @intId,
				@strNombres,
                @strApelllidos,
                @dateFechaNacimiento,
                @strDireccion,
				@strTelefono
			)
       COMMIT TRANSACTION --se confirma la transaccion
    END

		--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		  BEGIN TRANSACTION 
				UPDATE [AldairDouglasLizeth_NotasDB].[dbo].[Estudiantes]
				SET
				[ID]= @intId,
				[Nombres]= @strNombres,
				[Apellidos]=@strApelllidos,
				[FechaNacimiento]=@dateFechaNacimiento,
				[Direccion]=@strDireccion,
				[Telefono]=@strTelefono
                WHERE ([Id] = @intId);
		  COMMIT TRANSACTION
    END

	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [AldairDouglasLizeth_NotasDB].[dbo].[Estudiantes]
        WHERE ([Id] = @intId);
    END



end
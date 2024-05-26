USE [AldairDouglasLizeth_NotasDB]
GO
--Configuraciones de ANSI_NULLS y QUOTED_IDENTIFIER
SET ANSI_NULLS ON --Indica que las comparaciones con valores nulos (NULL) sigan el comportamiento estándar ANSI.
GO
SET QUOTED_IDENTIFIER ON -- Indica que se deben usar comillas dobles (") para delimitar identificadores.
GO

ALTER PROCEDURE [dbo].[SP_CrudGrados]
(
	@intProceso				        INT,
	@intId							INT,
	@strNombre	    			    NVARCHAR(50) = NULL	
)
AS
BEGIN
    SET NOCOUNT ON; --evitar que SQL Server envíe mensajes de conteo de filas afectadas al cliente
    DECLARE @intRegistros INT --declaramos la variable intRegistros

	--1 - SELECT    
	IF @intProceso = 1  --Si recibe un 1 realiza el Select
		BEGIN
			SELECT
				[Id],
				[Nombre]
				--WITH(NOLOCK): Esta cláusula se utiliza para realizar una lectura sin bloqueo
			FROM [AldairDouglasLizeth_NotasDB].[dbo].[Grados] WITH(NOLOCK) -- de la base de datos aldair de la tabla estudiantes
			WHERE ([Nombre] = @strNombre OR @strNombre IS NULL); --si el valor de nombre coincide con el buscado lo filtra, sino los muestra todos
    END

	--2 - INSERT 
    IF @intProceso = 2 --recibir un 2 para insert
    BEGIN 
        SELECT TOP 1 @intRegistros = 1 --obtener el primer regustro en la tabla estudiantes donde el nombre coincida con el buscado
        FROM [AldairDouglasLizeth_NotasDB].[dbo].[Grados] WITH(NOLOCK) --este primer registro de esta BD y esta tabla
        WHERE ([Nombre] = @strNombre);--donde verificar si el nombre existe

        IF @@ROWCOUNT = 1 --si se encuentra un registro sera igual a 1
        BEGIN
            SELECT 300 AS error -- de ser asi arrojar el numero 300 como un error
            RETURN
        END
		-- si el registro no existe se inicia una transaccion
       BEGIN TRANSACTION --e la operación se realizará completamente o no se realizará en absoluto.
			INSERT INTO [AldairDouglasLizeth_NotasDB].[dbo].[Grados]
			(
				[ID],
				[Nombre]
				
			)
			VALUES
			(
                @intId,
				@strNombre               
			)
       COMMIT TRANSACTION --se confirma la transaccion
    END

		--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		  BEGIN TRANSACTION 
				UPDATE [AldairDouglasLizeth_NotasDB].[dbo].[Grados]
				SET
				[ID]= @intId,
				[Nombre]= @strNombre
				
                WHERE ([Id] = @intId);
		  COMMIT TRANSACTION
    END

	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [AldairDouglasLizeth_NotasDB].[dbo].[Grados]
        WHERE ([Id] = @intId);
    END



end



USE [GD1C2018]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*  --------------------------------------------------------------------------------
ELIMINACION DE LOS SP
-------------------------------------------------------------------------------- */

if EXISTS (SELECT * FROM sys.objects  WHERE name = 'buscar_cliente' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[buscar_cliente]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'buscar_cliente_completo' AND type IN (N'P', N'PC'))
	drop procedure [denver].[buscar_cliente_completo]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cargar_cliente' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cargar_cliente]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'eliminar_cliente' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[eliminar_cliente]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cargar_hotel' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cargar_hotel]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'eliminar_hotel' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[eliminar_hotel]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cargar_habitacion' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cargar_habitacion]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'eliminar_habitacion' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[eliminar_habitacion]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cargar_regimen' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cargar_regimen] 
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'eliminar_regimen' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[eliminar_regimen]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cargar_rol' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cargar_rol]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'eliminar_rol' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[eliminar_rol] 
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cargar_usuario' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cargar_usuario] 
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'eliminar_usuario' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[eliminar_usuario] 
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'modificar_cliente' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[modificar_cliente] 
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'buscar_hotel' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[buscar_hotel]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'baja_hotel' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[baja_hotel]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'marcar_intentos_loguin_fallidos' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[marcar_intentos_loguin_fallidos]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'inhabilitar_usuario' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[inhabilitar_usuario]
	
GO


/*  --------------------------------------------------------------------------------
CREACION DE  LOS SP
-------------------------------------------------------------------------------- */

CREATE PROCEDURE [denver].[buscar_cliente]    
	@cliente_apellido nvarchar(255) = NULL ,
	@cliente_nombre nvarchar(255) = NULL,
--	@cliente_doc int = NULL
	@cliente_dni int = NULL 
AS   
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

	SELECT 
		tipo_documentos.tipo_documento_nombre AS Tipo_Doc , cliente_pasaporte_nro AS Pasaporte, cliente_apellido AS Apellido, cliente_nombre AS Nombre, cliente_email AS Email
	FROM 
		clientes  
		INNER JOIN tipo_documentos ON cliente_tipo_documento_id = tipo_documento_id 
	WHERE cliente_apellido LIKE '%' + ISNULL(@cliente_apellido, cliente_apellido) + '%'
		AND cliente_nombre LIKE '%' + ISNULL(@cliente_nombre, cliente_nombre) + '%'
		AND cliente_pasaporte_nro = ISNULL(@cliente_dni, cliente_pasaporte_nro)
		AND  cliente_activo != 'N' ;
		--AND cliente_tipo_documento_id = ISNULL(@cliente_doc, cliente_tipo_documento_id) 
END
GO

CREATE PROCEDURE [denver].[cargar_cliente]    
	@cliente_tipo_documento nvarchar(255) = NULL,
	@cliente_pasaporte_nro numeric(18, 0) = NULL,
	@cliente_apellido nvarchar(255) = NULL,
	@cliente_nombre nvarchar(255) = NULL,
	@cliente_fecha_nac datetime = NULL,
	@cliente_email nvarchar(255) = NULL,
	@cliente_dom_calle nvarchar(255) = NULL,
	@cliente_dom_nro nvarchar(255) = NULL,
	@cliente_piso numeric(18, 0) = NULL,
	@cliente_dpto nvarchar(50) = NULL,
	@cliente_dom_localidad nvarchar(255) = NULL,
	@cliente_telefono nvarchar(50) = NULL,
	@cliente_nacionalidad nvarchar(255) = NULL,
	@cliente_pais_id smallint = NULL
AS
BEGIN
	SET NOCOUNT ON; 

	DECLARE @tipo_documento_id smallint ;

	SELECT @tipo_documento_id = TIPO_DOCUMENTO_ID FROM dbo.tipo_documentos
		WHERE tipo_documento_nombre = @cliente_tipo_documento ;

	INSERT INTO clientes(
		cliente_nombre,
		cliente_apellido,
		cliente_tipo_documento_id,
		cliente_pasaporte_nro,
		cliente_email,
		cliente_telefono,
		cliente_dom_calle,
		cliente_dom_nro,
		cliente_dom_localidad,
		cliente_pais_id,
		cliente_nacionalidad,
		cliente_fecha_nac,
		cliente_created)
	VALUES(
		@cliente_nombre,
		@cliente_apellido,
		@tipo_documento_id,
		@cliente_pasaporte_nro,
		@cliente_email,
		@cliente_telefono,
		@cliente_dom_calle,
		@cliente_dom_nro,
		@cliente_dom_localidad,
		@cliente_pais_id,
		@cliente_nacionalidad,
		@cliente_fecha_nac,
		GETDATE())
END
GO




CREATE PROCEDURE [denver].[eliminar_cliente]
	@cliente_tipo_documento_id nvarchar(50),
	@cliente_pasaporte_nro numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;  

	DECLARE @tip_doc smallint ;

	SELECT @tip_doc = TIPO_DOCUMENTO_ID FROM dbo.tipo_documentos
		WHERE tipo_documento_nombre = @cliente_tipo_documento_id ;

	UPDATE [denver].[clientes]
		SET cliente_activo = 'N'
	WHERE 
		 cliente_tipo_documento_id = @tip_doc AND
		 cliente_pasaporte_nro = @cliente_pasaporte_nro 
END
GO


CREATE PROCEDURE [denver].[cargar_hotel]
	@hotel_nombre nvarchar(255),
	@hotel_email nvarchar(255),
	@hotel_telefono nvarchar(255),
	@hotel_calle nvarchar(255),
	@hotel_nro_calle numeric(18,0),
	@hotel_estrellas numeric(18,0),
	@hotel_ciudad nvarchar(255),
	@hotel_pais_id smallint
AS
BEGIN
	
	SET NOCOUNT ON;  

	INSERT INTO [denver].[hoteles](
		hotel_calle,
		hotel_nro_calle,
		hotel_ciudad,
		hotel_estrellas,
		hotel_recarga_estrella,
		hotel_created,
		hotel_nombre,
		hotel_email,
		hotel_telefono,
		hotel_pais_id,
		hotel_activo	
		)
	VALUES(
		@hotel_calle,
		@hotel_nro_calle,
		@hotel_ciudad,
		@hotel_estrellas,
		10,
		GETDATE(),
		@hotel_nombre,
		@hotel_email,
		@hotel_telefono,
		@hotel_pais_id,
		'S'
)
END
GO

CREATE PROCEDURE [denver].[eliminar_hotel]
	@hotel_id smallint
AS
BEGIN
	SET NOCOUNT ON;  
	UPDATE [denver].[hoteles]
		SET hotel_activo = 'N'
	WHERE
		@hotel_id = hotel_id
END
GO



CREATE PROCEDURE [denver].[cargar_habitacion]
	@habitacion_nro numeric(18,0),
	@habitacion_piso numeric(18,0),
	@habitacion_frente nvarchar(50),
	@habitacion_tipo_habitacion_id numeric(18,0),
	@habitacion_hotel_id smallint,
	@habitacion_descripcion ntext
AS
BEGIN
	SET NOCOUNT ON;  
	INSERT INTO habitaciones(
	habitacion_nro,
	habitacion_piso,
	habitacion_frente,
	habitacion_tipo_habitacion_id,
	habitacion_descripcion,
	habitacion_activa,
	habitacion_created)
	VALUES(
	@habitacion_nro,
	@habitacion_piso,
	@habitacion_frente,
	@habitacion_tipo_habitacion_id,
	@habitacion_descripcion,
	'S',
	GETDATE())
END
GO


CREATE PROCEDURE [denver].[eliminar_habitacion]
	@habitacion_nro numeric(18,0),
	@habitacion_hotel_id smallint
AS
BEGIN
	SET NOCOUNT ON;  
	UPDATE [denver].[habitaciones]
		SET habitacion_activa = 'N'
	WHERE
		@habitacion_hotel_id = habitacion_hotel_id AND
		@habitacion_nro = habitacion_nro
END
GO


CREATE PROCEDURE [denver].[cargar_regimen]
	@regimen_id numeric(18,0),
	@regimen_descripcion nvarchar(255),
	@regimen_precio numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;  
	INSERT INTO [denver].[regimenes](
		regimen_id,
		regimen_descripcion,
		regimen_precio,
		regimen_created,
		regimen_activo
		)
	VALUES(
		@regimen_id,
		@regimen_descripcion,
		@regimen_precio,
		GETDATE(),
		'S')
END
GO


CREATE PROCEDURE [denver].[eliminar_regimen]
	@regimen_id numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;  
	UPDATE [denver].[regimenes]
		SET regimen_activo = 'N'
	WHERE
		@regimen_id = regimen_id
END
GO


CREATE PROCEDURE [denver].[cargar_rol]
	@rol_nombre nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;  
	INSERT INTO [denver].[roles](
		rol_nombre,
		rol_activo,
		rol_created)
	VALUES(
		@rol_nombre,
		'S',
		GETDATE())
END
GO


CREATE PROCEDURE [denver].[eliminar_rol]
	@rol_nombre nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;  
	UPDATE [denver].[roles]
		SET rol_activo = 'N'
	WHERE
		@rol_nombre = rol_nombre
END
GO


CREATE PROCEDURE [denver].[cargar_usuario]
	@usuario_user nvarchar(50),
	@usuario_pass nvarchar(50),
	@usuario_nombre nvarchar(255),
	@usuario_apellido nvarchar(255),
	@usuario_tipo_documento_id smallint,
	@usuario_nro_documento nvarchar(255),
	@usuario_email nvarchar(255),
	@usuario_telefono nvarchar(255),
	@usuario_direccion nvarchar(255),
	@usuario_fecha_nac datetime
AS
BEGIN
	SET NOCOUNT ON;  
	INSERT INTO [denver].[usuarios](
		usuario_user,
		usuario_pass,
		usuario_nombre,
		usuario_apellido,
		usuario_tipo_documento_id,
		usuario_nro_documento,
		usuario_email,
		usuario_telefono,
		usuario_direccion,
		usuario_fecha_nac,
		usuario_activo,
		usuario_login_fallidos,
		usuario_created)
	VALUES(
		@usuario_user,
		@usuario_pass,
		@usuario_nombre,
		@usuario_apellido,
		@usuario_tipo_documento_id,
		@usuario_nro_documento,
		@usuario_email,
		@usuario_telefono,
		@usuario_direccion,
		@usuario_fecha_nac,
		'S',
		0,
		GETDATE())
END
GO


CREATE PROCEDURE [denver].[eliminar_usuario]
	@usuario_user nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;  
	UPDATE [denver].[usuarios]
		SET usuario_activo = 'N'
	WHERE
		@usuario_user = usuario_user
END
GO

CREATE PROCEDURE [denver].[buscar_cliente_completo] 
	@cliente_doc nvarchar(50) = NULL,
	@cliente_dni int = NULL 
AS   
BEGIN 
    -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

	SELECT *
		FROM clientes 
		 INNER JOIN tipo_documentos ON cliente_tipo_documento_id = tipo_documento_id 
		  WHERE	cliente_pasaporte_nro  = ISNULL(@cliente_dni, cliente_pasaporte_nro) 
		    AND tipo_documento_nombre  = ISNULL(@cliente_doc, tipo_documento_nombre) ;
END
GO


CREATE PROCEDURE [denver].[modificar_cliente] 
	@cliente_tipo_documento nvarchar(255) = NULL,
	@cliente_pasaporte_nro numeric(18, 0) = NULL,
	@cliente_apellido nvarchar(255) = NULL,
	@cliente_nombre nvarchar(255) = NULL,
	@cliente_fecha_nac datetime = NULL,
	@cliente_email nvarchar(255) = NULL,
	@cliente_dom_calle nvarchar(255) = NULL,
	@cliente_dom_nro nvarchar(255) = NULL,
	@cliente_piso numeric(18, 0) = NULL,
	@cliente_dpto nvarchar(50) = NULL,
	@cliente_dom_localidad nvarchar(255) = NULL,
	@cliente_telefono nvarchar(50) = NULL,
	@cliente_nacionalidad nvarchar(255) = NULL,
	@cliente_pais_id smallint = NULL
AS   
BEGIN 
    -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

	DECLARE @tipo_documento_id smallint ;

	SELECT @tipo_documento_id = TIPO_DOCUMENTO_ID FROM dbo.tipo_documentos
		WHERE tipo_documento_nombre = @cliente_tipo_documento ;


	UPDATE 
		clientes 
	SET
		cliente_apellido = @cliente_apellido,
		cliente_nombre = @cliente_nombre,
		cliente_fecha_nac = @cliente_fecha_nac,
		cliente_email = @cliente_email,
		cliente_dom_calle = @cliente_dom_calle,
		cliente_dom_nro = @cliente_dom_nro,
		cliente_piso = @cliente_piso,
		cliente_dpto = @cliente_dpto,
		cliente_dom_localidad = @cliente_dom_localidad,
		cliente_telefono = @cliente_telefono,
		cliente_nacionalidad = @cliente_nacionalidad,
		cliente_pais_id = @cliente_pais_id
	WHERE
		cliente_tipo_documento_id = @tipo_documento_id AND
		cliente_pasaporte_nro = @cliente_pasaporte_nro;
END
GO

CREATE PROCEDURE [denver].[buscar_hotel]    
	@hotel_nombre nvarchar(255) = NULL ,
	@hotel_ciudad nvarchar(255) = NULL,
	@pais_nombre  nvarchar(255) = NULL, 
	@hotel_estrellas smallint = NULL
AS   
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  
	DECLARE @pais_id smallint ;

	IF @pais_nombre IS NOT NULL
	BEGIN
 		SELECT @pais_id = pais_id
		FROM paises
		WHERE pais_nombre = @pais_nombre; 
	END

	SELECT hotel_nombre AS Nombre, hotel_ciudad AS Ciudad, p.pais_nombre AS Pais, hotel_email AS Email, hotel_estrellas AS Estrellas
	FROM 
		hoteles
		join paises p on hotel_pais_id = p.pais_id
	 WHERE hotel_nombre LIKE '%' + ISNULL(@hotel_nombre, hotel_nombre) + '%'
		AND hotel_ciudad LIKE '%' + ISNULL(@hotel_ciudad, hotel_ciudad) + '%'
		AND hotel_pais_id = ISNULL(@pais_id, hotel_pais_id) 
		AND hotel_estrellas = ISNULL(@hotel_estrellas, hotel_estrellas) ;
END
GO

CREATE PROCEDURE [denver].[baja_hotel]    
	@id_hotel smallint = NULL ,
	@fecha_inicio datetime = NULL,
	@fecha_fin  datetime = NULL, 
	@motivo nvarchar(255) = NULL
AS   
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

INSERT INTO [denver].[mantenimientos](
		mantenimiento_hotel_id,
		mantenimiento_fecha_desde,
		mantenimiento_fecha_hasta,
		mantenimiento_motivo,
		mantenimiento_created
)
	VALUES(
		@id_hotel,
		@fecha_inicio,
		@fecha_fin,
		@motivo,
		GETDATE());

END
GO

CREATE PROCEDURE denver.marcar_intentos_loguin_fallidos 
	@usuario_user nvarchar(50) = NULL
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE usuarios SET usuario_login_fallidos = usuario_login_fallidos + 1 WHERE usuario_user = @usuario_user;
END
GO

CREATE PROCEDURE denver.inhabilitar_usuario 
	@usuario_user nvarchar(50) = NULL
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE usuarios SET usuario_activo = 'N' WHERE usuario_user = @usuario_user;
END
GO


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
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'actualizar_estado_rol' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[actualizar_estado_rol] 
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
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'reset_intentos_loguin_fallidos' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[reset_intentos_loguin_fallidos]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cant_roles_usuario' AND type IN (N'FN'))
	DROP FUNCTION [denver].[cant_roles_usuario]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_hoteles' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_hoteles]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_tipo_documento' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_tipo_documento]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_regimenes' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_regimenes]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_habitaciones' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_habitaciones]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_consumibles' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_consumibles]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_tipo_habitaciones' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_tipo_habitaciones]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_paises' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_paises]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_roles' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_roles]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'habilitar_disponibilidad' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[habilitar_disponibilidad]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_disponibilidad' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_disponibilidad]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cant_pasajeros_tipo_habitacion' AND type IN (N'FN'))
	DROP FUNCTION [denver].[cant_pasajeros_tipo_habitacion]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'crear_reserva' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[crear_reserva]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'agregar_habitaciones_reserva' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[agregar_habitaciones_reserva]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'existe_usuario' AND type IN (N'FN'))
	DROP FUNCTION [denver].[existe_usuario]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_pasajero_reserva' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_pasajero_reserva]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_detalle_reserva' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_detalle_reserva]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'confirmar_checkin' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[confirmar_checkin]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cambiar_estado_reserva' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cambiar_estado_reserva]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'listado1' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[listado1]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'listado2' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[listado2]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'listado3' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[listado3]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'listado4' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[listado4]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'listado5' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[listado5]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'ocupar_disponibilidad' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[ocupar_disponibilidad]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_consumos' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_consumos]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'registrar_consumos' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[registrar_consumos]
	if EXISTS (SELECT * FROM sys.objects  WHERE name = 'crear_rol' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[crear_rol]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'modificar_rol' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[modificar_rol]		
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'crear_rol_funcionalidad' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[crear_rol_funcionalidad]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'funcionalidades_rol' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[funcionalidades_rol]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'existe_rol' AND type IN (N'FN'))
	DROP FUNCTION [denver].[existe_rol]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'obtener_funcionalidades' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[obtener_funcionalidades]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'buscar_funcionalidades_rol' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[buscar_funcionalidades_rol]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'eliminar_rol_completo' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[eliminar_rol_completo]	
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'cargar_tabla_roles' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[cargar_tabla_roles]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'buscar_usuario' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[buscar_usuario]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'buscar_usuario_completo' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[buscar_usuario_completo]
if EXISTS (SELECT * FROM sys.objects  WHERE name = 'loguin' AND type IN (N'P', N'PC'))
	DROP PROCEDURE [denver].[loguin]
GO


/*  --------------------------------------------------------------------------------
CREACION DE  LOS SP
-------------------------------------------------------------------------------- */

CREATE PROCEDURE [denver].[buscar_cliente]    
	@cliente_apellido nvarchar(255) = NULL ,
	@cliente_nombre nvarchar(255) = NULL,
	@cliente_tipo_doc int = NULL,
	@cliente_nro_doc int = NULL 
AS   
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

	SELECT 
		tipo_documentos.tipo_documento_nombre AS Tipo_Doc , cliente_pasaporte_nro AS Pasaporte, cliente_apellido AS Apellido, cliente_nombre AS Nombre, cliente_email AS Email, tipo_documentos.tipo_documento_id
	FROM 
		clientes  
		INNER JOIN tipo_documentos ON cliente_tipo_documento_id = tipo_documento_id 
	WHERE cliente_apellido LIKE '%' + ISNULL(@cliente_apellido, cliente_apellido) + '%'
		AND cliente_nombre LIKE '%' + ISNULL(@cliente_nombre, cliente_nombre) + '%'
		AND cliente_pasaporte_nro = ISNULL(@cliente_nro_doc, cliente_pasaporte_nro)
		AND  cliente_activo != 'N'
		AND cliente_tipo_documento_id = ISNULL(@cliente_tipo_doc, cliente_tipo_documento_id)  ;
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

	SELECT @tipo_documento_id = TIPO_DOCUMENTO_ID FROM denver.tipo_documentos
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

	SELECT @tip_doc = TIPO_DOCUMENTO_ID FROM denver.tipo_documentos
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

	

CREATE PROCEDURE [denver].[actualizar_estado_rol]
	@rol_nombre nvarchar(255),
	@rol_estado char
AS
BEGIN
	SET NOCOUNT ON;  
	UPDATE [denver].[roles]
		SET rol_activo = @rol_estado
		WHERE @rol_nombre = rol_nombre
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
	@usuario_fecha_nac datetime,
	@usuario_rol nvarchar(255),
    @usuario_hotel smallint
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
		usuario_created
		)
	VALUES(
		@usuario_user,
		HASHBYTES('SHA2_256',@usuario_pass),
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

		INSERT INTO [denver].[usuarios_roles](
			usuario_rol_usuario_user,
			usuario_rol_rol_nombre,
			usuario_rol_created
			)
		VALUES (
		 @usuario_user,
		 @usuario_rol,
		 GETDATE())

		 INSERT INTO [denver].[usuarios_hoteles](
		     usuario_hotel_id,
			 usuario_usuario_user
			 )
			 VALUES (
			 @usuario_user,
			 @usuario_hotel)


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

	SELECT @tipo_documento_id = TIPO_DOCUMENTO_ID FROM denver.tipo_documentos
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

CREATE PROCEDURE denver.reset_intentos_loguin_fallidos 
	@usuario_user nvarchar(50) = NULL
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE usuarios SET usuario_login_fallidos = 0 WHERE usuario_user = @usuario_user;
END
GO


CREATE FUNCTION denver.cant_roles_usuario (@usuario_user nvarchar(50))
RETURNS int
AS
BEGIN
	RETURN (SELECT count(*) FROM denver.usuarios_roles WHERE usuario_rol_usuario_user = @usuario_user)

END
GO


CREATE PROCEDURE denver.obtener_hoteles
	@usuario_user nvarchar(50) = NULL
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		h.hotel_id, h.hotel_nombre 
	FROM 
		denver.hoteles as h
		JOIN denver.usuarios_hoteles as uh ON h.hotel_id = uh.usuario_hotel_id
	WHERE
		uh.usuario_usuario_user = ISNULL(@usuario_user, uh.usuario_usuario_user)
    GROUP BY
		h.hotel_id, h.hotel_nombre 
	ORDER BY 
		h.hotel_nombre
END
GO

CREATE PROCEDURE denver.obtener_tipo_documento
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tipo_documento_id,tipo_documento_nombre FROM denver.tipo_documentos ORDER BY tipo_documento_nombre
END
GO

CREATE PROCEDURE denver.obtener_regimenes
	@hotel_id smallint
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		regimen_id,regimen_descripcion 
	FROM 
		denver.regimenes AS r
		JOIN denver.hoteles_regimenes AS hr ON r.regimen_id = hr.hotel_regimen_regimen_id
	WHERE
		hr.hotel_regimen_hotel_id = ISNULL(@hotel_id, hr.hotel_regimen_hotel_id)
	group by
		regimen_id,regimen_descripcion 
	ORDER BY regimen_descripcion
END
GO

CREATE PROCEDURE denver.obtener_habitaciones
	@hotel_id smallint
AS
BEGIN
	SET NOCOUNT ON;
	SELECT habitacion_nro FROM denver.habitaciones WHERE habitacion_hotel_id = @hotel_id ORDER BY habitacion_nro
END
GO



CREATE PROCEDURE denver.obtener_consumibles
AS
BEGIN
	SET NOCOUNT ON;
	SELECT consumible_id, consumible_descripcion FROM denver.consumibles ORDER BY consumible_descripcion
END
GO

CREATE PROCEDURE denver.obtener_tipo_habitaciones
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tipo_habitacion_id,tipo_habitacion_descripcion FROM denver.tipo_habitaciones ORDER BY tipo_habitacion_descripcion
END
GO

CREATE PROCEDURE denver.obtener_paises
AS
BEGIN
	SET NOCOUNT ON;
	SELECT pais_id, pais_nombre FROM denver.paises ORDER BY pais_nombre
END
GO

CREATE PROCEDURE denver.obtener_roles
	@usuario_user nvarchar(50) = NULL
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		r.rol_nombre
	FROM 
		denver.roles AS r
		JOIN denver.usuarios_roles AS ur ON  r.rol_nombre = ur.usuario_rol_rol_nombre
	WHERE
		ur.usuario_rol_usuario_user = ISNULL(@usuario_user, ur.usuario_rol_usuario_user) AND r.rol_activo = 'S'
	GROUP BY
		r.rol_nombre
	ORDER BY 
		r.rol_nombre
END
GO


CREATE PROCEDURE denver.habilitar_disponibilidad 
	@fecha_desde datetime = NULL,
	@fecha_hasta datetime = NULL
AS
BEGIN
	SET NOCOUNT ON;
	declare @fecha_actual datetime = @fecha_desde

	while (@fecha_actual < @fecha_hasta)
	begin


		insert into denver.disponibilidades (disponibilidad_hotel_id, disponibilidad_habitacion_nro, disponibilidad_tipo_habitacion_id, disponibilidad_ocupado, disponibilidad_fecha) 
		(
			SELECT
				ho.hotel_id, hab.habitacion_nro, th.tipo_habitacion_id, 0, @fecha_actual
			FROM 
			denver.habitaciones AS hab
			join denver.hoteles as ho on ho.hotel_id = hab.habitacion_hotel_id
			join denver.tipo_habitaciones as th on ho.hotel_id = hab.habitacion_hotel_id
		)
			set @fecha_actual = dateadd(day, 1, @fecha_actual)
	end
END
GO

-- Vacio las disponibilidades
truncate table denver.disponibilidades
exec denver.habilitar_disponibilidad '06/01/2018', '12/31/2018'
GO


CREATE PROCEDURE denver.obtener_disponibilidad
	@fecha_desde as datetime,
	@fecha_hasta as datetime,
	@hotel_id as smallint,
	@tipo_habitacion as numeric(18,0),
	@regimen_id as numeric(18,0) = NULL
AS
BEGIN
	SELECT 
		d.disponibilidad_habitacion_nro as "Nro. de Habitacion", th.tipo_habitacion_descripcion as "Tipo de Habitacion", r.regimen_descripcion as Regimen, r.regimen_precio As "Precio Diario por Pax", denver.cant_pasajeros_tipo_habitacion(th.tipo_habitacion_id) as "Max Pax", r.regimen_id, th.tipo_habitacion_id
	from 
		denver.disponibilidades as d
		join denver.hoteles_regimenes as hr on hr.hotel_regimen_hotel_id = d.disponibilidad_hotel_id
		join denver.regimenes as r on r.regimen_id = hr.hotel_regimen_regimen_id
		join denver.tipo_habitaciones as th on th.tipo_habitacion_id = d.disponibilidad_tipo_habitacion_id
	where
		d.disponibilidad_fecha between ''+cast(@fecha_desde as varchar(20))+'' and ''+cast(@fecha_hasta as varchar(20))+'' 
		and d.disponibilidad_hotel_id = @hotel_id
		and d.disponibilidad_ocupado = 0 
		and d.disponibilidad_tipo_habitacion_id = @tipo_habitacion 
		and hr.hotel_regimen_regimen_id = isnull(@regimen_id,hr.hotel_regimen_regimen_id)
		and r.regimen_activo = 'S'
	group by 
		d.disponibilidad_habitacion_nro, th.tipo_habitacion_descripcion, r.regimen_descripcion, r.regimen_precio, th.tipo_habitacion_id, r.regimen_id
END
GO

CREATE FUNCTION denver.cant_pasajeros_tipo_habitacion (@tipo_habitacion numeric(18,0))
RETURNS int
AS
BEGIN
	RETURN (SELECT CASE @tipo_habitacion
		WHEN 1001 THEN 1
		WHEN 1002 THEN 2
		WHEN 1003 THEN 3
		WHEN 1004 THEN 4		
		ELSE 5
	END)
END
GO

CREATE PROCEDURE denver.crear_reserva 
	@reserva_fecha_inicio datetime,
	@reserva_fecha_fin datetime,
	@reserva_cliente_tipo_documento_id smallint,
	@reserva_cliente_pasaporte_nro numeric(18,0),
	@reserva_hotel_id smallint,
	@reserva_usuario_user nvarchar(50),
	@reserva_estado_id smallint,
	@nro_reserva numeric(18,0) OUTPUT
AS
BEGIN
	declare @next_id numeric(18,0) = (SELECT TOP 1 reserva_codigo FROM denver.reservas ORDER BY reserva_codigo DESC)+1

	insert into denver.reservas (reserva_codigo,reserva_fecha_inicio,reserva_fecha_fin,reserva_cant_noches,reserva_cliente_tipo_documento_id,reserva_cliente_pasaporte_nro,reserva_hotel_id,reserva_usuario_user,reserva_estado_id,reserva_created) values (@next_id,@reserva_fecha_inicio,@reserva_fecha_fin,DATEDIFF(day, @reserva_fecha_inicio, @reserva_fecha_fin),@reserva_cliente_tipo_documento_id,@reserva_cliente_pasaporte_nro,@reserva_hotel_id,@reserva_usuario_user,@reserva_estado_id, GETDATE())

	SELECT @nro_reserva = @next_id

END
GO

CREATE PROCEDURE denver.agregar_habitaciones_reserva 
	@nro_reserva numeric(18,0),
	@reserva_fecha_inicio datetime,
	@reserva_fecha_fin datetime,
	@reserva_regimen_id  numeric(18,0),
	@reserva_tipo_habitacion_id numeric(18,0),
	@reserva_habitacion_nro numeric(18,0),
	@reserva_precio_habitacion numeric(18,0)
AS
BEGIN
	insert into reservas_habitaciones (reserva_habitaciones_reserva_codigo,reserva_habitaciones_fecha_inicio,reserva_habitaciones_fecha_fin,reserva_habitaciones_tipo_habitacion_id,reserva_habitaciones_cant_noches,reserva_habitaciones_regimen_id,reserva_habitacion_nro,reserva_habitaciones_precio) values (@nro_reserva, @reserva_fecha_inicio,@reserva_fecha_fin,@reserva_tipo_habitacion_id,DATEDIFF(day, @reserva_fecha_inicio, @reserva_fecha_fin), @reserva_regimen_id, @reserva_habitacion_nro, @reserva_precio_habitacion)
END
GO

CREATE FUNCTION denver.existe_usuario (@usuario_user nvarchar(50))
RETURNS int
AS
BEGIN
	RETURN (SELECT count(*) FROM denver.usuarios WHERE usuario_user = @usuario_user)

END
GO


CREATE PROCEDURE denver.obtener_pasajero_reserva 
	@nro_reserva numeric(18,0)
AS
BEGIN
	SELECT
	c.cliente_apellido as Apellido, c.cliente_nombre AS Nombre, td.tipo_documento_nombre AS "Tipo de Documento", c.cliente_pasaporte_nro AS "Nro. de Documento", c.cliente_tipo_documento_id
	FROM
		denver.reservas as r
		join denver.clientes as c on r.reserva_cliente_tipo_documento_id+r.reserva_cliente_pasaporte_nro=c.cliente_tipo_documento_id+c.cliente_pasaporte_nro
		join denver.tipo_documentos td on td.tipo_documento_id = c.cliente_tipo_documento_id
	WHERE
		r.reserva_codigo = @nro_reserva AND r.reserva_estado_id IN (1, 2)
	ORDER BY
		c.cliente_apellido, c.cliente_nombre
END
GO


CREATE PROCEDURE denver.obtener_detalle_reserva 
	@nro_reserva numeric(18,0)
AS
BEGIN
	SELECT
		rh.reserva_habitaciones_fecha_inicio as "Fecha Entrada", rh.reserva_habitaciones_fecha_fin as "Fecha Salida",th.tipo_habitacion_descripcion as "Tipo Habitacion", reg.regimen_descripcion as "Regimen", rh.reserva_habitaciones_precio as "Precio", rh.reserva_habitacion_nro as "Habitacion", th.tipo_habitacion_id
	FROM
		denver.reservas as r
		join denver.reservas_habitaciones as rh ON r.reserva_codigo = rh.reserva_habitaciones_reserva_codigo
		join denver.tipo_habitaciones as th on rh.reserva_habitaciones_tipo_habitacion_id = th.tipo_habitacion_id
		join denver.regimenes as reg on reg.regimen_id = rh.reserva_habitaciones_regimen_id
	WHERE
		r.reserva_codigo = @nro_reserva AND r.reserva_estado_id IN (1, 2)
END
GO

CREATE PROCEDURE denver.cambiar_estado_reserva 
	@nro_reserva numeric(18,0),
	@nuevo_estado smallint
AS
BEGIN
	UPDATE
		reservas
	SET
		reserva_estado_id = @nuevo_estado
	WHERE
		reserva_codigo = @nro_reserva
END
GO


CREATE PROCEDURE denver.confirmar_checkin 
	@nro_reserva numeric(18,0),
	@estadia_cliente_tipo_documento_id smallint,
	@estadia_cliente_pasaporte_nro numeric(18,0),
	@estadia_fecha_inicio datetime,
	@estadia_fecha_fin datetime,
	@estadia_hotel_id smallint,
	@estadia_usuario_user nvarchar(50)
AS
BEGIN

  INSERT INTO denver.estadias (estadia_cliente_tipo_documento_id,estadia_cliente_pasaporte_nro,estadia_fecha_inicio,estadia_cant_noches,estadia_fecha_fin,estadia_hotel_id,estadia_reserva_codigo,estadia_usuario_user,estadia_created) VALUES (@estadia_cliente_tipo_documento_id, @estadia_cliente_pasaporte_nro,@estadia_fecha_inicio,DATEDIFF(day, @estadia_fecha_inicio, @estadia_fecha_fin),@estadia_fecha_fin,@estadia_hotel_id,@nro_reserva,@estadia_usuario_user,GETDATE())

  -- cambio el estado de la reserva
  exec denver.cambiar_estado_reserva @nro_reserva, 6

END
GO

-- Hoteles con mayor cantidad de reservas canceladas
CREATE PROCEDURE denver.listado1 
	@anio smallint,
	@trimestre smallint
AS
BEGIN
	DECLARE @meses varchar(50);


	if (@trimestre = 1) set @meses = '(1,2,3)';
	if (@trimestre = 2) set @meses = '(4,5,6)';
	if (@trimestre = 3) set @meses = '(7,8,9)';
	if (@trimestre = 4) set @meses = '(10,11,12)';

	select
		h.hotel_nombre as Hotel, count(*) as "Total Reservas Canceladas"
	from
		denver.reservas as r
		join denver.hoteles as h on r.reserva_hotel_id = h.hotel_id
	where
		r.reserva_estado_id IN (3,4,5)
		AND MONTH(r.reserva_fecha_inicio) IN (@meses) AND year(r.reserva_fecha_inicio) = @anio
		AND MONTH(r.reserva_fecha_fin) IN (@meses) AND year(r.reserva_fecha_fin) = @anio
	group by
		h.hotel_nombre
	order by
		count(*) DESc

END
GO

-- Hoteles con mayor cantidad de consumibles facturados
CREATE PROCEDURE denver.listado2
	@anio int,
	@trimestre int
AS
BEGIN
	select
		h.hotel_nombre as Hotel, count(*) as "Total Reservas Canceladas"
	from
		denver.reservas as r
		join denver.hoteles as h on r.reserva_hotel_id = h.hotel_id
	where
		r.reserva_estado_id IN (1,3,4,5)
	group by
		h.hotel_nombre
	order by
		count(*) DESc

END
GO

-- Hoteles con mayor cantidad de días fuera de servicio
CREATE PROCEDURE denver.listado3
	@anio int,
	@trimestre int
AS
BEGIN
	select
		h.hotel_nombre as Hotel, count(*) as "Total Reservas Canceladas"
	from
		denver.reservas as r
		join denver.hoteles as h on r.reserva_hotel_id = h.hotel_id
	where
		r.reserva_estado_id IN (1,3,4,5)
	group by
		h.hotel_nombre
	order by
		count(*) DESc

END
GO

-- Habitaciones con mayor cantidad de días y veces que fueron ocupados
CREATE PROCEDURE denver.listado4
	@anio int,
	@trimestre int
AS
BEGIN
	select
		h.hotel_nombre as Hotel, count(*) as "Total Reservas Canceladas"
	from
		denver.reservas as r
		join denver.hoteles as h on r.reserva_hotel_id = h.hotel_id
	where
		r.reserva_estado_id IN (1,3,4,5)
	group by
		h.hotel_nombre
	order by
		count(*) DESc

END
GO

-- Cliente con mayor cantidad de puntos
CREATE PROCEDURE denver.listado5
	@anio int,
	@trimestre int
AS
BEGIN
	select
		h.hotel_nombre as Hotel, count(*) as "Total Reservas Canceladas"
	from
		denver.reservas as r
		join denver.hoteles as h on r.reserva_hotel_id = h.hotel_id
	where
		r.reserva_estado_id IN (1,3,4,5)
	group by
		h.hotel_nombre
	order by
		count(*) DESc

END
GO

CREATE PROCEDURE denver.ocupar_disponibilidad
	@habitacion_nro numeric(18,0),
	@tipo_habitacion as numeric(18,0),
	@hotel_id smallint,
	@fecha_ocupacion datetime
AS
BEGIN
	UPDATE 
		denver.disponibilidades
	SET 
		disponibilidad_ocupado = 1
	where
		disponibilidad_hotel_id = @hotel_id and
		disponibilidad_habitacion_nro = @habitacion_nro and
		disponibilidad_tipo_habitacion_id = @tipo_habitacion and
		disponibilidad_fecha = @fecha_ocupacion
END
GO

CREATE PROCEDURE denver.obtener_consumos
	@habitacion_nro numeric(18,0),
	@hotel_id smallint,
	@nro_reserva numeric(18,0) OUTPUT
AS
BEGIN
	declare @cliente_tipo_doc int
	declare @cliente_nro_doc int

	select
		@nro_reserva = r.reserva_codigo, @cliente_tipo_doc = r.reserva_cliente_tipo_documento_id, @cliente_nro_doc = r.reserva_cliente_pasaporte_nro
	from
		denver.reservas as r
		join reservas_habitaciones as rh on rh.reserva_habitaciones_reserva_codigo = r.reserva_codigo
	where
		rh.reserva_habitacion_nro = @habitacion_nro and r.reserva_hotel_id = @hotel_id;


	select
		cc.consumible_cliente_fecha_consumo as "Fecha Consumo", c.consumible_descripcion as "Consumo", c.consumible_id
	from
		denver.consumibles_clientes as cc
		join denver.consumibles as c on cc.consumible_cliente_consumible_id = c.consumible_id
	where
		cc.consumible_cliente_tipo_documento_id = @cliente_tipo_doc AND cc.consumible_cliente_pasaporte_nro = @cliente_nro_doc and cc.consumible_cliente_reserva_codigo = @nro_reserva
	order by
		cc.consumible_cliente_fecha_consumo, c.consumible_descripcion

END
GO

CREATE PROCEDURE denver.registrar_consumos
	@consumible_id numeric(18,0),
	@fecha_consumo datetime,
	@habitacion_nro numeric(18,0),
	@hotel_id smallint
AS
BEGIN
	declare @nro_reserva numeric(18,0)
	declare @cliente_tipo_doc int
	declare @cliente_nro_doc int

	select
		@nro_reserva = r.reserva_codigo, @cliente_tipo_doc = r.reserva_cliente_tipo_documento_id, @cliente_nro_doc = r.reserva_cliente_pasaporte_nro
	from
		denver.reservas as r
		join reservas_habitaciones as rh on rh.reserva_habitaciones_reserva_codigo = r.reserva_codigo
	where
		rh.reserva_habitacion_nro = @habitacion_nro and r.reserva_hotel_id = @hotel_id;


	insert into denver.consumibles_clientes (consumible_cliente_consumible_id,consumible_cliente_tipo_documento_id,consumible_cliente_pasaporte_nro,consumible_cliente_fecha_consumo,consumible_cliente_reserva_codigo) values (@consumible_id,@cliente_tipo_doc,@cliente_nro_doc, @fecha_consumo, @nro_reserva)
END
GO

CREATE PROCEDURE [denver].[crear_rol]    
	@rol nvarchar(255)
AS   
BEGIN 
	
	SET NOCOUNT ON;  
	INSERT INTO [denver].[roles](
	    rol_nombre,
		rol_activo,
		rol_created
		)
		values(
		@rol,
		'S',
		GETDATE())

	

END
GO

CREATE PROCEDURE [denver].[modificar_rol]    
	@rol nvarchar(255)
AS   
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

	SELECT rol_funcionalidad_rol_nombre AS ROL,  rol_funcionalidad_funcionalidad_id AS FUNCIONALIDAD
	FROM roles_funcionalidades
	WHERE  rol_funcionalidad_rol_nombre = @rol;
END
GO

CREATE PROCEDURE [denver].[crear_rol_funcionalidad]    
	@rol_nombre nvarchar(255),
	@rol_funcionalidad smallint
AS   
BEGIN 
	
	SET NOCOUNT ON;  
	INSERT INTO [denver].[roles_funcionalidades](
	    rol_funcionalidad_rol_nombre,
		rol_funcionalidad_funcionalidad_id
		)
		values(
		@rol_nombre,
		@rol_funcionalidad
		)
END
GO

CREATE PROCEDURE [denver].[funcionalidades_rol]    
	@usuario_rol nvarchar(255)
AS   
BEGIN 
	
	SET NOCOUNT ON;  

    SELECT rol_funcionalidad_funcionalidad_id AS Permiso
	  FROM roles_funcionalidades
	   WHERE rol_funcionalidad_rol_nombre = @usuario_rol
END
GO

CREATE FUNCTION denver.existe_rol (@rol nvarchar(50))
RETURNS int
AS
BEGIN
	RETURN (SELECT count(*) FROM denver.usuarios WHERE usuario_user = @rol)

END
GO
CREATE PROCEDURE denver.obtener_funcionalidades
AS
BEGIN
	SET NOCOUNT ON;
	SELECT funcionalidad_nombre 
	  FROM denver.funcionalidades
END
GO

CREATE PROCEDURE [denver].[buscar_funcionalidades_rol]
@rol_nombre nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT rol_funcionalidad_funcionalidad_id
	  FROM denver.roles_funcionalidades
		WHERE rol_funcionalidad_rol_nombre = @rol_nombre

END
GO

CREATE PROCEDURE [denver].[eliminar_rol_completo]
	@rol nvarchar(255),
	@rol_nuevo nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;  
	
    DELETE FROM denver.roles_funcionalidades WHERE rol_funcionalidad_rol_nombre = @rol;

	UPDATE denver.usuarios_roles
	 SET usuario_rol_rol_nombre = @rol_nuevo
	  WHERE usuario_rol_rol_nombre = @rol ;

	DELETE FROM denver.roles WHERE rol_nombre = @rol 


END
GO

CREATE PROCEDURE [denver].[cargar_tabla_roles]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT rol_nombre AS Roles, CASE WHEN rol_activo = 'S' THEN 'ACTIVO' ELSE 'INACTIVO' END AS Estado  
	  FROM denver.roles

END
GO

CREATE PROCEDURE [denver].[buscar_usuario]    
	@usuario_nombre nvarchar(255) = NULL ,
	@usuario_apellido nvarchar(255) = NULL,
	@hotel int = NULL 
AS   
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

	SELECT a.usuario_user AS Usuario, a.usuario_nombre AS Nombre, a.usuario_apellido AS Apellido, a.usuario_tipo_documento_id AS 'Tipo DNI',
	a.usuario_nro_documento AS DNI , a.usuario_email AS Mail, a.usuario_telefono AS Tel
		FROM 
		denver.usuarios AS a
		INNER JOIN denver.usuarios_hoteles AS b ON a.usuario_user = b.usuario_usuario_user  
	WHERE  a.usuario_nombre LIKE '%' + ISNULL(@usuario_nombre, usuario_nombre) + '%'
		AND a.usuario_apellido LIKE '%' + ISNULL(@usuario_apellido, usuario_apellido) + '%'
		AND b.usuario_hotel_id = @hotel 
END
GO

CREATE PROCEDURE [denver].[buscar_usuario_completo]    
	@usuario_nombre nvarchar(255) = NULL 
AS   
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;  

	SELECT *
		FROM denver.usuarios AS a 
		WHERE  a.usuario_nombre LIKE '%' + ISNULL(@usuario_nombre, usuario_nombre) + '%'
END
GO

CREATE PROCEDURE denver.loguin
	@usuario_user nvarchar(50),
	@usuario_pass varchar(50),
	@hotel_id smallint
AS   
BEGIN 

	SELECT count(*), usuario_apellido, usuario_nombre, usuario_user, usuario_login_fallidos, denver.cant_roles_usuario(usuario_user), usuario_rol_rol_nombre AS rol 
	FROM 
		denver.usuarios AS u 
		JOIN denver.usuarios_hoteles AS uh ON u.usuario_user = uh.usuario_usuario_user 
		JOIN denver.usuarios_roles AS r ON u.usuario_user = r.usuario_rol_usuario_user 
	WHERE 
		u.usuario_user = UPPER(@usuario_user) AND 
		u.usuario_pass = HASHBYTES('SHA2_256',UPPER(@usuario_pass)) AND 
		uh.usuario_hotel_id = @hotel_id AND 
		u.usuario_activo = 'S' 
	GROUP BY 
		usuario_apellido, usuario_nombre, usuario_user, usuario_login_fallidos, usuario_rol_rol_nombre;;
END
GO


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
		ur.usuario_rol_usuario_user = ISNULL(@usuario_user, ur.usuario_rol_usuario_user)
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
		d.disponibilidad_habitacion_nro as "Nro. de Habitacion", th.tipo_habitacion_descripcion as "Tipo de Habitacion", r.regimen_descripcion as Regimen, r.regimen_precio As "Precio Diario por Pax", denver.cant_pasajeros_tipo_habitacion(th.tipo_habitacion_id) as "Max Pax"
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
		d.disponibilidad_habitacion_nro, th.tipo_habitacion_descripcion, r.regimen_descripcion, r.regimen_precio, th.tipo_habitacion_id
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


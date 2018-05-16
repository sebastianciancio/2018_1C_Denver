USE [GD1C2018]
GO

/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 4/30/2018 7:41:53 PM ******/
DROP PROCEDURE [dbo].[buscar_cliente]
GO
if EXISTS (SELECT * FROM sysobjects  WHERE name='buscar_cliente_completo')
drop procedure dbo.buscar_cliente_completo

go 
/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 4/30/2018 7:41:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[buscar_cliente]    
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


/****** Object:  StoredProcedure [dbo].[cargar_cliente]    Script Date: 4/30/2018 10:43:53 PM ******/

DROP PROCEDURE [dbo].[cargar_cliente]

CREATE PROCEDURE [dbo].[cargar_cliente]
	@cliente_nombre nvarchar(255),
	@cliente_apellido nvarchar(255),
	@cliente_tipo_documento_id smallint,
	@cliente_pasaporte_nro numeric(18,0),
	@cliente_email nvarchar(255),
	@cliente_telefono nvarchar(50),
	@cliente_dom_calle nvarchar(255),
	@cliente_dom_nro nvarchar(255),
	@cliente_dom_localidad nvarchar(255),
	@cliente_pais_origen nvarchar(255),
	@cliente_nacionalidad nvarchar(255),
	@cliente_fecha_nac datetime
AS
BEGIN
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
		cliente_activo,
		cliente_created)
	VALUES(
		@cliente_nombre,
		@cliente_apellido,
		@cliente_tipo_documento_id,
		@cliente_pasaporte_nro,
		@cliente_email,
		@cliente_telefono,
		@cliente_dom_calle,
		@cliente_dom_nro,
		@cliente_dom_localidad,
		(select pais_id from paises where pais_nombre = @cliente_pais_origen),
		@cliente_nacionalidad,
		@cliente_fecha_nac,
		'S',
		GETDATE())
END
GO

/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 5/3/2018 11:52:53 PM ******/

if EXISTS (SELECT * FROM sysobjects  WHERE name='eliminar_cliente')
DROP PROCEDURE [dbo].[eliminar_cliente]
GO

CREATE PROCEDURE [dbo].[eliminar_cliente]
	@cliente_tipo_documento_id nvarchar(50),
	@cliente_pasaporte_nro numeric(18,0)
AS
BEGIN

	DECLARE @tip_doc smallint ;

	SELECT @tip_doc = TIPO_DOCUMENTO_ID FROM dbo.tipo_documentos
		WHERE tipo_documento_nombre = @cliente_tipo_documento_id ;

	UPDATE [dbo].[clientes]
		SET cliente_activo = 'N'
	WHERE 
		 cliente_tipo_documento_id = @tip_doc AND
		 cliente_pasaporte_nro = @cliente_pasaporte_nro 
END

GO
/****** Object:  StoredProcedure [dbo].[cargar_hotel]   Script Date: 5/4/2018 11:52:53 PM ******/


DROP PROCEDURE [dbo].[cargar_hotel]

CREATE PROCEDURE [dbo].[cargar_hotel]
	@hotel_id smallint,
	@hotel_nombre nvarchar(255),
	@hotel_email nvarchar(255),
	@hotel_telefono nvarchar(255),
	@hotel_calle nvarchar(255),
	@hotel_nro_calle numeric(18,0),
	@hotel_estrellas numeric(18,0),
	@hotel_ciudad nvarchar(255),
	@hotel_pais_id smallint,
	@hotel_created datetime
AS
BEGIN
	INSERT INTO [dbo].[hoteles](
		hotel_id,
		hotel_nombre,
		hotel_email,
		hotel_telefono,
		hotel_calle,
		hotel_nro_calle,
		hotel_estrellas,
		hotel_ciudad,
		hotel_pais_id,
		hotel_recarga_estrella,
		hotel_created,
		hotel_activo)
	VALUES(
		@hotel_nombre,
		@hotel_email,
		@hotel_telefono,
		@hotel_calle,
		@hotel_nro_calle,
		@hotel_estrellas,
		@hotel_ciudad,
		@hotel_pais_id,
		10,
		GETDATE(),
		'S')
END
GO

/****** Object:  StoredProcedure [dbo].[eliminar_hotel]   Script Date: 5/4/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[eliminar_hotel]

CREATE PROCEDURE [dbo].[eliminar_hotel]
	@hotel_id smallint
AS
BEGIN
	UPDATE [dbo].[hoteles]
		SET hotel_activo = 'N'
	WHERE
		@hotel_id = hotel_id
END
GO

/****** Object:  StoredProcedure [dbo].[cargar_habitacion]   Script Date: 5/4/2018 11:52:53 PM ******/
select * from habitaciones

DROP PROCEDURE [dbo].[cargar_habitacion]

CREATE PROCEDURE [dbo].[cargar_habitacion]
	@habitacion_nro numeric(18,0),
	@habitacion_piso numeric(18,0),
	@habitacion_frente nvarchar(50),
	@habitacion_tipo_habitacion_id numeric(18,0),
	@habitacion_hotel_id smallint,
	@habitacion_descripcion ntext
AS
BEGIN
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

/****** Object:  StoredProcedure [dbo].[eliminar_habitacion]   Script Date: 5/4/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[eliminar_habitacion]

CREATE PROCEDURE [dbo].[eliminar_habitacion]
	@habitacion_nro numeric(18,0),
	@habitacion_hotel_id smallint
AS
BEGIN
	UPDATE [dbo].[habitaciones]
		SET habitacion_activa = 'N'
	WHERE
		@habitacion_hotel_id = habitacion_hotel_id AND
		@habitacion_nro = habitacion_nro
END
GO

/****** Object:  StoredProcedure [dbo].[cargar_regimen]   Script Date: 5/4/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[cargar_regimen] 

CREATE PROCEDURE [dbo].[cargar_regimen]
	@regimen_id numeric(18,0),
	@regimen_descripcion nvarchar(255),
	@regimen_precio numeric(18,0)
AS
BEGIN
	INSERT INTO [dbo].[regimenes](
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

/****** Object:  StoredProcedure [dbo].[eliminar_regimen]   Script Date: 5/5/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[eliminar_regimen]

CREATE PROCEDURE [dbo].[eliminar_regimen]
	@regimen_id numeric(18,0)
AS
BEGIN
	UPDATE [dbo].[regimenes]
		SET regimen_activo = 'N'
	WHERE
		@regimen_id = regimen_id
END
GO

/****** Object:  StoredProcedure [dbo].[cargar_rol]   Script Date: 5/5/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[cargar_rol]

CREATE PROCEDURE [dbo].[cargar_rol]
	@rol_nombre nvarchar(255)
AS
BEGIN
	INSERT INTO [dbo].[roles](
		rol_nombre,
		rol_activo,
		rol_created)
	VALUES(
		@rol_nombre,
		'S',
		GETDATE())
END
GO

/****** Object:  StoredProcedure [dbo].[eliminar_rol]   Script Date: 5/5/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[eliminar_rol] 

CREATE PROCEDURE [dbo].[eliminar_rol]
	@rol_nombre nvarchar(255)
AS
BEGIN
	UPDATE [dbo].[roles]
		SET rol_activo = 'N'
	WHERE
		@rol_nombre = rol_nombre
END
GO

/****** Object:  StoredProcedure [dbo].[cargar_usuario]   Script Date: 5/5/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[cargar_usuario] 

CREATE PROCEDURE [dbo].[cargar_usuario]
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
	INSERT INTO [dbo].[usuarios](
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

/****** Object:  StoredProcedure [dbo].[eliminar_usuario]   Script Date: 5/5/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[eliminar_usuario] 

CREATE PROCEDURE [dbo].[eliminar_usuario]
	@usuario_user nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[usuarios]
		SET usuario_activo = 'N'
	WHERE
		@usuario_user = usuario_user
END
GO

CREATE PROCEDURE [dbo].[buscar_cliente_completo] 
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

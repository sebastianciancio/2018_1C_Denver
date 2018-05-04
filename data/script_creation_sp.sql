USE [GD1C2018]
GO

/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 4/30/2018 7:41:53 PM ******/
DROP PROCEDURE [dbo].[buscar_cliente]
GO

/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 4/30/2018 7:41:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[buscar_cliente]    
    @cliente_apellido nvarchar(255) = NULL ,
	@cliente_nombre nvarchar(255) = NULL,
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
		AND cliente_pasaporte_nro = ISNULL(@cliente_dni, cliente_pasaporte_nro) ; 
END

GO


/****** Object:  StoredProcedure [dbo].[cargar_cliente]    Script Date: 4/30/2018 10:43:53 PM ******/

DROP PROCEDURE [dbo].[cargar_cliente]

CREATE PROCEDURE [dbo].[cargar_cliente]
	@cliente_nombre nvarchar(255),
	@cliente_apellido nvarchar(255),
	@cliente_tipo_documento nvarchar(50),
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
		cliente_activo)
	VALUES(
		@cliente_nombre,
		@cliente_apellido,
		(select tipo_documento_id from tipo_documentos where  tipo_documento_nombre = @cliente_tipo_documento),
		@cliente_pasaporte_nro,
		@cliente_email,
		@cliente_telefono,
		@cliente_dom_calle,
		@cliente_dom_nro,
		@cliente_dom_localidad,
		(select pais_id from paises where pais_nombre = @cliente_pais_origen),
		@cliente_nacionalidad,
		@cliente_fecha_nac,
		'S')
END
GO

/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 5/3/2018 11:52:53 PM ******/


DROP PROCEDURE [dbo].[eliminar_cliente]

CREATE PROCEDURE [dbo].[eliminar_cliente]
	@cliente_tipo_documento nvarchar(50) = NULL,
	@cliente_pasaporte_nro numeric(18,0) = NULL
AS
BEGIN
	UPDATE [dbo].[clientes]
		SET cliente_activo = 'N'
	WHERE 
		(SELECT tipo_documento_id FROM tipo_documentos WHERE @cliente_tipo_documento = tipo_documento_nombre) = cliente_tipo_documento_id AND
		@cliente_pasaporte_nro = cliente_pasaporte_nro
END
GO

/****** Object:  StoredProcedure [dbo].[cargar_hotel]   Script Date: 5/4/2018 11:52:53 PM ******/


DROP PROCEDURE [dbo].[cargar_hotel]

CREATE PROCEDURE [dbo].[cargar_hotel]
	@hotel_nombre nvarchar(255),
	@hotel_email nvarchar(255),
	@hotel_telefono nvarchar(255),
	@hotel_calle nvarchar(255),
	@hotel_nro_calle numeric(18,0),
	@hotel_estrellas numeric(18,0),
	@hotel_ciudad nvarchar(255),
	@hotel_pais nvarchar(255),
	--@tipo_de_regimenes??
	@hotel_created datetime
AS
BEGIN
	INSERT INTO hoteles(
		hotel_nombre,
		hotel_email,
		hotel_telefono,
		hotel_calle,
		hotel_nro_calle,
		hotel_estrellas,
		hotel_ciudad,
		hotel_pais_id,
		--tipo de regimenes?
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
		@hotel_pais,
		@hotel_created,
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

DROP PROCEDURE [dbo].[cargar_habitacion]

CREATE PROCEDURE [dbo].[cargar_habitacion]
	@habitacion_nro numeric(18,0),
	@habitacion_piso numeric(18,0),
	@habitacion_frente nvarchar(50),
	@habitacion_tipo_habitacion numeric(18,0),
	@habitacion_descripcion ntext
AS
BEGIN
	INSERT INTO habitaciones(
	habitacion_nro,
	habitacion_piso,
	habitacion_frente,
	habitacion_tipo_habitacion_id,
	habitacion_descripcion,
	habitacion_activa)
	VALUES(
	@habitacion_nro,
	@habitacion_piso,
	@habitacion_frente,
	@habitacion_tipo_habitacion,
	@habitacion_descripcion,
	'S')
END
GO

/****** Object:  StoredProcedure [dbo].[eliminar_habitacion]   Script Date: 5/4/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[eliminar_habitacion]

CREATE PROCEDURE [dbo].[eliminar_habitacion]
	@habitacion_nro numeric(18,0)
AS
BEGIN
	UPDATE [dbo].[habitaciones]
		SET habitacion_activa = 'N'
	WHERE
		@habitacion_nro = habitacion_nro
END
GO

/****** Object:  StoredProcedure [dbo].[cargar_regimen]   Script Date: 5/4/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[cargar_regimen] 

CREATE PROCEDURE [dbo].[cargar_regimen] 
	@regimen_id numeric(18,0),
	@regimen_descripcion nvarchar(255),
	@regimen_precio numeric(18,0),
	@regimen_created datetime
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
		@regimen_created,
		'S')
END
GO

/****** Object:  StoredProcedure [dbo].[cargar_reserva]   Script Date: 5/4/2018 11:52:53 PM ******/

DROP PROCEDURE [dbo].[cargar_reserva]

CREATE PROCEDURE [dbo].[cargar_reserva]
	@reserva_codigo numeric(18,0),
	@reserva_fecha_inicio datetime,
	@reserva_fecha_fin datetime,
AS
BEGIN
	INSERT INTO [dbo].[reservas](
		reserva_codigo,
		reserva_fecha_inicio,
		reserva_fecha_fin)
	VALUES(
		@reserva_codigo,
		@reserva_fecha_inicio,
		@reserva_fecha_fin)
END
GO
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

CREATE PROCEDURE [dbo].[eliminar_cliente] --Ver cómo hacer para que se pueda buscar sólo con algunos de estos parametros y no sólo con todos.
	@cliente_nombre nvarchar(255) = NULL,
	@cliente_apellido nvarchar(255) = NULL,
	@cliente_tipo_documento nvarchar(50) = NULL,
	@cliente_pasaporte_nro numeric(18,0) = NULL,
	@cliente_email nvarchar(250) = NULL
AS
BEGIN
	UPDATE [dbo].[clientes]
		SET cliente_activo = 'N'
	WHERE 
		@cliente_nombre = cliente_nombre AND
		@cliente_apellido = cliente_apellido AND
		(SELECT tipo_documento_id FROM tipo_documentos WHERE @cliente_tipo_documento = tipo_documento_nombre) = cliente_tipo_documento_id AND
		@cliente_pasaporte_nro = cliente_pasaporte_nro AND
		@cliente_email = cliente_email
END
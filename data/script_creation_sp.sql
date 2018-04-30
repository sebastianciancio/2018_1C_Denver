USE [GD1C2018]
GO

/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 4/30/2018 6:22:21 PM ******/
DROP PROCEDURE [dbo].[buscar_cliente]
GO

/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 4/30/2018 6:22:21 PM ******/
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

	SELECT *  
	FROM dbo.clientes  
	WHERE cliente_apellido LIKE '%' + ISNULL(@cliente_apellido, cliente_apellido) + '%'
		AND cliente_nombre LIKE '%' + ISNULL(@cliente_nombre, cliente_nombre) + '%'
		AND cliente_pasaporte_nro = ISNULL(@cliente_dni, cliente_pasaporte_nro) ; 
END

GO


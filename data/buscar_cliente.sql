USE [GD1C2018]
GO

/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 26/4/2018 10:25:23 ******/
DROP PROCEDURE [dbo].[buscar_cliente]
GO

/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 26/4/2018 10:25:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[buscar_cliente]    
    @cliente_apellido nvarchar(255) ,
	@cliente_nombre nvarchar(255) ,
	@cliente_dni int 
AS   

    SET NOCOUNT ON;  
    SELECT *  
    FROM dbo.clientes  
    WHERE cliente_apellido = @cliente_apellido
	  AND cliente_nombre   = @cliente_nombre
	  AND cliente_pasaporte_nro = @cliente_dni ; 
GO


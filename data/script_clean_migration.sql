USE [GD1C2018]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*  --------------------------------------------------------------------------------
ELIMINACION DE TODOS LAS CONSTRAINT
-------------------------------------------------------------------------------- */

ALTER TABLE [DENVER].[clientes] DROP CONSTRAINT [FK_clientes_tipo_documentos];
ALTER TABLE [DENVER].[clientes] DROP CONSTRAINT [FK_clientes_paises];
ALTER TABLE [DENVER].[clientes] DROP CONSTRAINT [DF_clientes_cliente_activo];
ALTER TABLE [DENVER].[estadias] DROP CONSTRAINT [FK_estadias_usuarios1];
ALTER TABLE [DENVER].[estadias] DROP CONSTRAINT [FK_estadias_reservas];
ALTER TABLE [DENVER].[estadias] DROP CONSTRAINT [FK_estadias_hoteles];
ALTER TABLE [DENVER].[estadias] DROP CONSTRAINT [FK_estadias_clientes];
ALTER TABLE [DENVER].[facturas] DROP CONSTRAINT [FK_facturas_formas_pago];
ALTER TABLE [DENVER].[facturas] DROP CONSTRAINT [FK_facturas_clientes];
ALTER TABLE [DENVER].[habitaciones] DROP CONSTRAINT [FK_habitaciones_tipo_habitaciones];
ALTER TABLE [DENVER].[habitaciones] DROP CONSTRAINT [FK_habitaciones_hoteles];
ALTER TABLE [DENVER].[habitaciones] DROP CONSTRAINT [DF_habitaciones_habitacion_activa];
ALTER TABLE [DENVER].[hoteles] DROP CONSTRAINT [FK_hoteles_paises];
ALTER TABLE [DENVER].[hoteles] DROP CONSTRAINT [DF_hoteles_hotel_activo];
ALTER TABLE [DENVER].[hoteles_regimenes] DROP CONSTRAINT [FK_hoteles_regimenes_regimenes];
ALTER TABLE [DENVER].[hoteles_regimenes] DROP CONSTRAINT [FK_hoteles_regimenes_hoteles];
ALTER TABLE [DENVER].[regimenes] DROP CONSTRAINT [DF_regimenes_regimen_activo];
ALTER TABLE [DENVER].[reservas] DROP CONSTRAINT [FK_reservas_usuarios1];
ALTER TABLE [DENVER].[reservas] DROP CONSTRAINT [FK_reservas_usuarios];
ALTER TABLE [DENVER].[reservas] DROP CONSTRAINT [FK_reservas_hoteles];
ALTER TABLE [DENVER].[reservas] DROP CONSTRAINT [FK_reservas_estados];
ALTER TABLE [DENVER].[reservas] DROP CONSTRAINT [FK_reservas_clientes];
ALTER TABLE [DENVER].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones];
ALTER TABLE [DENVER].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_reservas];
ALTER TABLE [DENVER].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_regimenes];
ALTER TABLE [DENVER].[roles] DROP CONSTRAINT [DF_roles1_rol_activo];
ALTER TABLE [DENVER].[roles_funcionalidades] DROP CONSTRAINT [FK_roles_funcionalidades_roles];
ALTER TABLE [DENVER].[roles_funcionalidades] DROP CONSTRAINT [FK_roles_funcionalidades_funcionalidades];
ALTER TABLE [DENVER].[usuarios] DROP CONSTRAINT [DF_usuarios_usuario_activo];
ALTER TABLE [DENVER].[usuarios] DROP CONSTRAINT [DF_usuarios_usuario_login_fallidos];
ALTER TABLE [DENVER].[usuarios_hoteles] DROP CONSTRAINT [FK_usuarios_hoteles_usuarios];
ALTER TABLE [DENVER].[usuarios_hoteles] DROP CONSTRAINT [FK_usuarios_hoteles_hoteles];
ALTER TABLE [DENVER].[usuarios_roles] DROP CONSTRAINT [FK_usuarios_roles_usuarios];
ALTER TABLE [DENVER].[usuarios_roles] DROP CONSTRAINT [FK_usuarios_roles_roles];
ALTER TABLE [DENVER].[facturas_items] DROP CONSTRAINT [FK_facturas_items_reservas];
ALTER TABLE [DENVER].[facturas_items] DROP CONSTRAINT [FK_facturas_items_facturas];
ALTER TABLE [DENVER].[facturas_items] DROP CONSTRAINT [FK_facturas_items_consumibles];
ALTER TABLE [DENVER].[mantenimientos] DROP CONSTRAINT [FK_mantenimientos_hoteles];
ALTER TABLE [DENVER].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_reservas]
ALTER TABLE [DENVER].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_consumibles]
ALTER TABLE [DENVER].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_clientes]
ALTER TABLE [DENVER].[disponibilidades] DROP CONSTRAINT [FK_disponibilidades_tipo_habitaciones]
ALTER TABLE [DENVER].[disponibilidades] DROP CONSTRAINT [FK_disponibilidades_habitaciones]
ALTER TABLE [DENVER].[disponibilidades] DROP CONSTRAINT [DF_disponibilidades_disponibilidad_ocupado]
GO
/*  --------------------------------------------------------------------------------
ELIMINACION TODAS LAS TABLAS
-------------------------------------------------------------------------------- */

DROP TABLE [DENVER].[clientes];
DROP TABLE [DENVER].[consumibles];
DROP TABLE [DENVER].[consumibles_clientes];
DROP TABLE [DENVER].[estadias];
DROP TABLE [DENVER].[estados];
DROP TABLE [DENVER].[facturas];
DROP TABLE [DENVER].[facturas_items];
DROP TABLE [DENVER].[formas_pago];
DROP TABLE [DENVER].[funcionalidades];
DROP TABLE [DENVER].[habitaciones];
DROP TABLE [DENVER].[hoteles];
DROP TABLE [DENVER].[hoteles_regimenes];
DROP TABLE [DENVER].[paises];
DROP TABLE [DENVER].[regimenes];
DROP TABLE [DENVER].[reservas];
DROP TABLE [DENVER].[reservas_habitaciones];
DROP TABLE [DENVER].[roles];
DROP TABLE [DENVER].[roles_funcionalidades];
DROP TABLE [DENVER].[tipo_documentos];
DROP TABLE [DENVER].[tipo_habitaciones];
DROP TABLE [DENVER].[usuarios];
DROP TABLE [DENVER].[usuarios_hoteles];
DROP TABLE [DENVER].[usuarios_roles];
DROP TABLE [DENVER].[mantenimientos];
DROP TABLE [DENVER].[disponibilidades]
GO

/*  --------------------------------------------------------------------------------
ELIMINACION DE LOS SP
-------------------------------------------------------------------------------- */

DROP PROCEDURE [DENVER].[buscar_cliente]
drop procedure [DENVER].[buscar_cliente_completo]
DROP PROCEDURE [DENVER].[cargar_cliente]
DROP PROCEDURE [DENVER].[eliminar_cliente]
DROP PROCEDURE [DENVER].[eliminar_hotel]
DROP PROCEDURE [DENVER].[buscar_hotel_completo]
DROP PROCEDURE [DENVER].[cargar_hotel]
DROP PROCEDURE [DENVER].[cargar_habitacion]
DROP PROCEDURE [DENVER].[eliminar_habitacion]
DROP PROCEDURE [DENVER].[alta_habitacion] 
DROP PROCEDURE [DENVER].[eliminar_regimen]
DROP PROCEDURE [DENVER].[actualizar_estado_rol] 
DROP PROCEDURE [DENVER].[cargar_usuario] 
DROP PROCEDURE [DENVER].[eliminar_usuario] 
DROP PROCEDURE [DENVER].[modificar_cliente] 
DROP PROCEDURE [DENVER].[buscar_hotel]
DROP PROCEDURE [DENVER].[baja_hotel]
DROP PROCEDURE [DENVER].[marcar_intentos_loguin_fallidos]
DROP PROCEDURE [DENVER].[inhabilitar_usuario]
DROP PROCEDURE [DENVER].[reset_intentos_loguin_fallidos]
DROP FUNCTION [DENVER].[cant_roles_usuario]
DROP PROCEDURE [DENVER].[obtener_hoteles]
DROP PROCEDURE [DENVER].[obtener_tipo_documento]
DROP PROCEDURE [DENVER].[obtener_regimenes]
DROP PROCEDURE [DENVER].[obtener_habitaciones]
DROP PROCEDURE [DENVER].[obtener_consumibles]
DROP PROCEDURE [DENVER].[obtener_tipo_habitaciones]
DROP PROCEDURE [DENVER].[obtener_paises]
DROP PROCEDURE [DENVER].[obtener_formas_pago]   
DROP PROCEDURE [DENVER].[obtener_roles]
DROP PROCEDURE [DENVER].[habilitar_disponibilidad]    
DROP PROCEDURE [DENVER].[obtener_disponibilidad]      
DROP FUNCTION [DENVER].[cant_pasajeros_tipo_habitacion]
DROP PROCEDURE [DENVER].[crear_reserva]   
DROP PROCEDURE [DENVER].[agregar_habitaciones_reserva]      
DROP FUNCTION [DENVER].[existe_usuario]
DROP PROCEDURE [DENVER].[obtener_pasajero_reserva]    
DROP PROCEDURE [DENVER].[obtener_detalle_reserva]     
DROP PROCEDURE [DENVER].[confirmar_checkin]     
DROP PROCEDURE [DENVER].[cambiar_estado_reserva]      
DROP PROCEDURE [DENVER].[listado1]  
DROP PROCEDURE [DENVER].[listado2]  
DROP PROCEDURE [DENVER].[listado3]  
DROP PROCEDURE [DENVER].[listado4]  
DROP PROCEDURE [DENVER].[listado5]  
DROP PROCEDURE [DENVER].[ocupar_disponibilidad] 
DROP PROCEDURE [DENVER].[liberar_disponibilidad]      
DROP PROCEDURE [DENVER].[obtener_consumos]      
DROP PROCEDURE [DENVER].[registrar_consumos]
DROP PROCEDURE [DENVER].[crear_rol] 
DROP PROCEDURE [DENVER].[modificar_rol]         
DROP PROCEDURE [DENVER].[crear_rol_funcionalidad]     
DROP PROCEDURE [DENVER].[funcionalidades_rol]   
DROP FUNCTION [DENVER].[existe_rol]
DROP PROCEDURE [DENVER].[obtener_funcionalidades]
DROP PROCEDURE [DENVER].[buscar_funcionalidades_rol]  
DROP PROCEDURE [DENVER].[eliminar_rol_completo] 
DROP PROCEDURE [DENVER].[cargar_tabla_roles]
DROP PROCEDURE [DENVER].[buscar_usuario]
DROP PROCEDURE [DENVER].[buscar_usuario_completo]
DROP PROCEDURE [DENVER].[loguin]
DROP PROCEDURE [DENVER].[obtener_facturable]
DROP PROCEDURE [DENVER].[modificar_hotel]
DROP FUNCTION  [DENVER].[hotel_en_mantenimiento]
DROP PROCEDURE [DENVER].[buscar_habitacion]
DROP PROCEDURE [DENVER].[buscar_habitacion_completa]
DROP PROCEDURE [DENVER].[buscar_reserva_hab_hotel]
DROP PROCEDURE [DENVER].[modificar_habitacion]  
DROP PROCEDURE [DENVER].[existe_habitacion_hotel]
DROP PROCEDURE [DENVER].[cargar_usuario_hotel]
DROP PROCEDURE [DENVER].[buscar_regimen]
DROP PROCEDURE [DENVER].[alta_regimen]
DROP PROCEDURE [DENVER].[buscar_reserva]
DROP PROCEDURE [DENVER].[cancelar_reserva]
DROP PROCEDURE [DENVER].[modificar_usuario] 
DROP FUNCTION  [DENVER].[existe_reserva]
DROP PROCEDURE [DENVER].[facturar_encabezado]
DROP PROCEDURE [DENVER].[facturar_items]
DROP PROCEDURE [DENVER].[habilitar_usuario]
DROP PROCEDURE [DENVER].[cambiar_contraseña]
GO

DROP SCHEMA [DENVER]
GO
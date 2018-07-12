USE [GD1C2018]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Me aseguro que el idioma del usuario gdHotel2018 es espanol
alter login gdHotel2018 with default_language= Spanish
GO

set dateformat dmy
GO

/*  --------------------------------------------------------------------------------
CREACION DEL SCHEMA 
-------------------------------------------------------------------------------- */
CREATE SCHEMA [DENVER]
GO

/*  --------------------------------------------------------------------------------
CREACION DE TODA LA ESTRUCUTRA NUEVA
-------------------------------------------------------------------------------- */

CREATE TABLE [DENVER].[clientes](
      [cliente_tipo_documento_id] [smallint] NOT NULL,
      [cliente_pasaporte_nro] [numeric](18, 0) NOT NULL,
      [cliente_apellido] [nvarchar](255) NULL,
      [cliente_nombre] [nvarchar](255) NULL,
      [cliente_fecha_nac] [datetime] NULL,
      [cliente_email] [nvarchar](255) NULL,
      [cliente_dom_calle] [nvarchar](255) NULL,
      [cliente_dom_nro] [nvarchar](255) NULL,
      [cliente_piso] [numeric](18, 0) NULL,
      [cliente_dpto] [nvarchar](50) NULL,
      [cliente_dom_localidad] [nvarchar](255) NULL,
      [cliente_telefono] [nvarchar](50) NULL,
      [cliente_nacionalidad] [nvarchar](255) NULL,
      [cliente_activo] [char](1) NULL,
      [cliente_pais_id] [smallint] NULL,
      [cliente_created] [datetime] NULL,      
 CONSTRAINT [PK_clientes_1] PRIMARY KEY CLUSTERED 
(
      [cliente_tipo_documento_id] ASC,
      [cliente_pasaporte_nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_email] UNIQUE NONCLUSTERED 
(
      [cliente_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [DENVER].[consumibles](
      [consumible_id] [numeric](18, 0) NOT NULL,
      [consumible_descripcion] [nvarchar](255) NULL,
      [consumible_precio] [numeric](18, 2) NULL,
      [consumible_created] [datetime] NULL,
 CONSTRAINT [PK_consumibles] PRIMARY KEY CLUSTERED 
(
      [consumible_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [DENVER].[consumibles_clientes](
      [consumible_cliente_consumible_id] [numeric](18, 0) NULL,
      [consumible_cliente_tipo_documento_id] [smallint] NULL,
      [consumible_cliente_pasaporte_nro] [numeric](18, 0) NULL,
      [consumible_cliente_fecha_consumo] [datetime] NULL,
      [consumible_cliente_reserva_codigo] [numeric](18, 0) NULL
) ON [PRIMARY]
GO


CREATE TABLE [DENVER].[estadias](
      [estadia_cliente_tipo_documento_id] [smallint] NULL,
      [estadia_cliente_pasaporte_nro] [numeric](18, 0) NULL,
      [estadia_fecha_inicio] [datetime] NULL,
      [estadia_cant_noches] [numeric](18, 0) NULL,
      [estadia_fecha_fin] [datetime] NULL,      
      [estadia_hotel_id] [smallint] NULL,
      [estadia_reserva_codigo] [numeric](18, 0) NULL,
      [estadia_usuario_user] [nvarchar](50) NULL,
      [estadia_created] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[estados](
      [estado_id] [smallint] NOT NULL,
      [estado_nombre] [nvarchar](150) NULL,
 CONSTRAINT [PK_estados] PRIMARY KEY CLUSTERED 
(
      [estado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[facturas](
      [factura_nro] [numeric](18, 0) NOT NULL,
      [factura_fecha] [datetime] NULL,
      [factura_total] [numeric](18, 2) NULL,
      [factura_forma_pago_id] [smallint] NULL,
      [factura_detalle_pago] [nvarchar](150) NULL,
      [factura_cliente_tipo_documento] [smallint] NULL,
      [factura_pasaporte_nro] [numeric](18, 0) NULL,
      [factura_hotel_id] [smallint] NULL,
      [factura_created] [datetime] NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
      [factura_nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[facturas_items](
      [factura_item_nro] [numeric](18, 0) NULL,      
      [factura_item_cant] [numeric](18, 0) NULL,
      [factura_item_monto] [numeric](18, 2) NULL,
      [factura_item_descripcion] [nvarchar](255) NULL,
      [factura_consumible_id] [numeric](18, 0) NULL,
      [factura_reserva_codigo] [numeric](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[formas_pago](
      [forma_pago_id] [smallint] NOT NULL,
      [forma_pago_nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_formas_pago] PRIMARY KEY CLUSTERED 
(
      [forma_pago_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[funcionalidades](
      [funcionalidad_id] [smallint] IDENTITY(1,1) NOT NULL,
      [funcionalidad_nombre] [nvarchar](255) NULL,
      [funcionalidad_created] [datetime] NULL,
 CONSTRAINT [PK_funcionalidades] PRIMARY KEY CLUSTERED 
(
      [funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[habitaciones](
      [habitacion_nro] [numeric](18, 0) NOT NULL,
      [habitacion_piso] [numeric](18, 0) NULL,
      [habitacion_frente] [nvarchar](50) NULL,
      [habitacion_tipo_habitacion_id] [numeric](18, 0) NULL,
      [habitacion_descripcion] [ntext] NULL,
      [habitacion_hotel_id] [smallint] NOT NULL,
      [habitacion_activa] [char](1) NULL,
      [habitacion_created] [datetime] NULL,      
 CONSTRAINT [PK_habitaciones] PRIMARY KEY NONCLUSTERED 
(
      [habitacion_nro] ASC,
      [habitacion_hotel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [DENVER].[hoteles](
      [hotel_id] [smallint] IDENTITY(1,1) NOT NULL,
	  [hotel_nombre] [nvarchar](255) NULL,
      [hotel_calle] [nvarchar](255) NULL,
      [hotel_nro_calle] [numeric](18, 0) NULL,
      [hotel_ciudad] [nvarchar](255) NULL,
      [hotel_pais_id] [smallint] NULL,      
      [hotel_email] [nvarchar](255) NULL,
      [hotel_telefono] [nvarchar](255) NULL,      
      [hotel_estrellas] [numeric](18, 0) NULL,
      [hotel_recarga_estrella] [numeric](18, 0) NULL,
      [hotel_activo] [char](1) NULL,
      [hotel_created] [datetime] NULL,      
 CONSTRAINT [PK_hoteles] PRIMARY KEY CLUSTERED 
(
      [hotel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [DENVER].[hoteles_regimenes](
      [hotel_regimen_hotel_id] [smallint] NULL,
      [hotel_regimen_regimen_id] [numeric](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[paises](
      [pais_id] [smallint] NOT NULL,
      [pais_nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_paises] PRIMARY KEY CLUSTERED 
(
      [pais_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[regimenes](
      [regimen_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
      [regimen_descripcion] [nvarchar](255) NULL,
      [regimen_precio] [numeric](18, 2) NULL,
      [regimen_activo] [char](1) NULL,
      [regimen_created] [datetime] NULL,
 CONSTRAINT [PK_regimenes] PRIMARY KEY CLUSTERED 
(
      [regimen_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[reservas](
      [reserva_codigo] [numeric](18, 0) NOT NULL,      
      [reserva_fecha_inicio] [datetime] NULL,
      [reserva_cant_noches] [numeric](18, 0) NULL,
      [reserva_fecha_fin] [datetime] NULL,
      [reserva_cliente_tipo_documento_id] [smallint] NULL,
      [reserva_cliente_pasaporte_nro] [numeric](18, 0) NULL,
      [reserva_hotel_id] [smallint] NULL,
      [reserva_usuario_user] [nvarchar](50) NULL,
      [reserva_estado_id] [smallint] NULL,
      [reserva_motivo_cancelacion] [ntext] NULL,
      [reserva_fecha_cancelacion] [datetime] NULL,
      [reserva_usuario_user_cancelacion] [nvarchar](50) NULL,
      [reserva_created] [datetime] NULL,     
 CONSTRAINT [PK_reservas] PRIMARY KEY CLUSTERED 
(
      [reserva_codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [DENVER].[reservas_habitaciones](
      [reserva_habitaciones_reserva_codigo] [numeric](18, 0) NULL,
      [reserva_habitaciones_fecha_inicio] [datetime] NULL,
      [reserva_habitaciones_fecha_fin] [datetime] NULL,
      [reserva_habitaciones_tipo_habitacion_id] [numeric](18, 0) NULL,
      [reserva_habitaciones_cant_noches] [numeric](18, 0) NULL,
      [reserva_habitaciones_regimen_id] [numeric](18, 0) NULL,
      [reserva_habitacion_nro] [numeric](18, 0) NOT NULL,      
      [reserva_habitaciones_precio] [numeric](18, 2) NULL
) ON [PRIMARY]
GO


CREATE TABLE [DENVER].[roles](
      [rol_nombre] [nvarchar](255) NOT NULL,
      [rol_activo] [char](1) NOT NULL,
      [rol_created] [datetime] NULL,
 CONSTRAINT [PK_roles1] PRIMARY KEY CLUSTERED 
(
      [rol_nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[roles_funcionalidades](
      [rol_funcionalidad_rol_nombre] [nvarchar](255) NULL,
      [rol_funcionalidad_funcionalidad_id] [smallint] NULL,
 CONSTRAINT [IX_roles_funcionalidades] UNIQUE NONCLUSTERED 
(
      [rol_funcionalidad_rol_nombre] ASC,
      [rol_funcionalidad_funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [DENVER].[tipo_documentos](
      [tipo_documento_id] [smallint] NOT NULL,
      [tipo_documento_nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_tipo_documentos] PRIMARY KEY CLUSTERED 
(
      [tipo_documento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[tipo_habitaciones](
      [tipo_habitacion_id] [numeric](18, 0) NOT NULL,
      [tipo_habitacion_descripcion] [nvarchar](255) NULL,
      [tipo_habitacion_porcentual] [numeric](18, 2) NULL,
      [tipo_habitacion_created] [datetime] NULL,
 CONSTRAINT [PK_tipohabitaciones] PRIMARY KEY CLUSTERED 
(
      [tipo_habitacion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [DENVER].[usuarios](
      [usuario_user] [nvarchar](50) NOT NULL,
      [usuario_pass] [binary](32) NULL,
      [usuario_apellido] [nvarchar](255) NULL,      
      [usuario_nombre] [nvarchar](255) NULL,
      [usuario_tipo_documento_id] [smallint] NULL,
      [usuario_nro_documento] [nvarchar](255) NULL,
      [usuario_email] [nvarchar](255) NULL,
      [usuario_telefono] [nvarchar](255) NULL,
      [usuario_direccion] [nvarchar](255) NULL,
      [usuario_fecha_nac] [datetime] NULL,
      [usuario_activo] [char](1) NOT NULL,      
      [usuario_login_fallidos] [smallint] NOT NULL,      
      [usuario_created] [datetime] NULL,      
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
      [usuario_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[usuarios_hoteles](
      [usuario_hotel_id] [smallint] NULL,
      [usuario_usuario_user] [nvarchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[usuarios_roles](
      [usuario_rol_usuario_user] [nvarchar](50) NOT NULL,
      [usuario_rol_rol_nombre] [nvarchar](255) NOT NULL,
      [usuario_rol_created] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[mantenimientos](
      [mantenimiento_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
      [mantenimiento_hotel_id] [smallint] NULL,
      [mantenimiento_fecha_desde] [datetime] NULL,
      [mantenimiento_fecha_hasta] [datetime] NULL,
      [mantenimiento_motivo] [nvarchar](255) NULL,
      [mantenimiento_created] [datetime] NULL
 CONSTRAINT [PK_mantenimientos] PRIMARY KEY CLUSTERED 
(
      [mantenimiento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [DENVER].[disponibilidades](
      [disponibilidad_habitacion_nro] [numeric](18, 0) NULL,
      [disponibilidad_hotel_id] [smallint] NULL,
      [disponibilidad_fecha] [datetime] NULL,
      [disponibilidad_ocupado] [nchar](1) NULL,
      [disponibilidad_tipo_habitacion_id] [numeric](18, 0) NULL
) ON [PRIMARY]
GO


SET ANSI_PADDING OFF
GO

/*  --------------------------------------------------------------------------------
CREACION DE LOS CONSTRAINT
-------------------------------------------------------------------------------- */

ALTER TABLE [DENVER].[regimenes] ADD  CONSTRAINT [DF_regimenes_regimen_activo]  DEFAULT ('S') FOR [regimen_activo]
GO


ALTER TABLE [DENVER].[reservas]  WITH NOCHECK ADD  CONSTRAINT [FK_reservas_clientes] FOREIGN KEY([reserva_cliente_tipo_documento_id], [reserva_cliente_pasaporte_nro])
REFERENCES [DENVER].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [DENVER].[reservas] NOCHECK CONSTRAINT [FK_reservas_clientes]
GO

ALTER TABLE [DENVER].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_estados] FOREIGN KEY([reserva_estado_id])
REFERENCES [DENVER].[estados] ([estado_id])
GO

ALTER TABLE [DENVER].[reservas] CHECK CONSTRAINT [FK_reservas_estados]
GO

ALTER TABLE [DENVER].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_hoteles] FOREIGN KEY([reserva_hotel_id])
REFERENCES [DENVER].[hoteles] ([hotel_id])
GO

ALTER TABLE [DENVER].[reservas] CHECK CONSTRAINT [FK_reservas_hoteles]
GO

ALTER TABLE [DENVER].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_usuarios] FOREIGN KEY([reserva_usuario_user])
REFERENCES [DENVER].[usuarios] ([usuario_user])
GO

ALTER TABLE [DENVER].[reservas] CHECK CONSTRAINT [FK_reservas_usuarios]
GO

ALTER TABLE [DENVER].[reservas]  WITH NOCHECK ADD  CONSTRAINT [FK_reservas_usuarios1] FOREIGN KEY([reserva_usuario_user_cancelacion])
REFERENCES [DENVER].[usuarios] ([usuario_user])
GO

ALTER TABLE [DENVER].[reservas] NOCHECK CONSTRAINT [FK_reservas_usuarios1]
GO

ALTER TABLE [DENVER].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_regimenes] FOREIGN KEY([reserva_habitaciones_regimen_id])
REFERENCES [DENVER].[regimenes] ([regimen_id])
GO

ALTER TABLE [DENVER].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_regimenes]
GO

ALTER TABLE [DENVER].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_reservas] FOREIGN KEY([reserva_habitaciones_reserva_codigo])
REFERENCES [DENVER].[reservas] ([reserva_codigo])
GO

ALTER TABLE [DENVER].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_reservas]
GO

ALTER TABLE [DENVER].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones] FOREIGN KEY([reserva_habitaciones_tipo_habitacion_id])
REFERENCES [DENVER].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [DENVER].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones]
GO

ALTER TABLE [DENVER].[roles] ADD  CONSTRAINT [DF_roles1_rol_activo]  DEFAULT ('S') FOR [rol_activo]
GO


ALTER TABLE [DENVER].[roles_funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_roles_funcionalidades_funcionalidades] FOREIGN KEY([rol_funcionalidad_funcionalidad_id])
REFERENCES [DENVER].[funcionalidades] ([funcionalidad_id])
GO

ALTER TABLE [DENVER].[roles_funcionalidades] CHECK CONSTRAINT [FK_roles_funcionalidades_funcionalidades]
GO

ALTER TABLE [DENVER].[roles_funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_roles_funcionalidades_roles] FOREIGN KEY([rol_funcionalidad_rol_nombre])
REFERENCES [DENVER].[roles] ([rol_nombre])
GO

ALTER TABLE [DENVER].[roles_funcionalidades] CHECK CONSTRAINT [FK_roles_funcionalidades_roles]
GO


ALTER TABLE [DENVER].[usuarios] ADD  CONSTRAINT [DF_usuarios_usuario_login_fallidos]  DEFAULT ((0)) FOR [usuario_login_fallidos]
GO

ALTER TABLE [DENVER].[usuarios] ADD  CONSTRAINT [DF_usuarios_usuario_activo]  DEFAULT ('S') FOR [usuario_activo]
GO

ALTER TABLE [DENVER].[usuarios_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_hoteles_hoteles] FOREIGN KEY([usuario_hotel_id])
REFERENCES [DENVER].[hoteles] ([hotel_id])
GO

ALTER TABLE [DENVER].[usuarios_hoteles] CHECK CONSTRAINT [FK_usuarios_hoteles_hoteles]
GO

ALTER TABLE [DENVER].[usuarios_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_hoteles_usuarios] FOREIGN KEY([usuario_usuario_user])
REFERENCES [DENVER].[usuarios] ([usuario_user])
GO

ALTER TABLE [DENVER].[usuarios_hoteles] CHECK CONSTRAINT [FK_usuarios_hoteles_usuarios]
GO

ALTER TABLE [DENVER].[usuarios_roles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles_roles] FOREIGN KEY([usuario_rol_rol_nombre])
REFERENCES [DENVER].[roles] ([rol_nombre])
GO

ALTER TABLE [DENVER].[usuarios_roles] CHECK CONSTRAINT [FK_usuarios_roles_roles]
GO

ALTER TABLE [DENVER].[usuarios_roles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles_usuarios] FOREIGN KEY([usuario_rol_usuario_user])
REFERENCES [DENVER].[usuarios] ([usuario_user])
GO

ALTER TABLE [DENVER].[usuarios_roles] CHECK CONSTRAINT [FK_usuarios_roles_usuarios]
GO

ALTER TABLE [DENVER].[mantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_mantenimientos_hoteles] FOREIGN KEY([mantenimiento_hotel_id])
REFERENCES [DENVER].[hoteles] ([hotel_id])
GO

ALTER TABLE [DENVER].[mantenimientos] CHECK CONSTRAINT [FK_mantenimientos_hoteles]
GO

ALTER TABLE [DENVER].[hoteles_regimenes]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_regimenes_hoteles] FOREIGN KEY([hotel_regimen_hotel_id])
REFERENCES [DENVER].[hoteles] ([hotel_id])
GO

ALTER TABLE [DENVER].[hoteles_regimenes] CHECK CONSTRAINT [FK_hoteles_regimenes_hoteles]
GO

ALTER TABLE [DENVER].[hoteles_regimenes]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_regimenes_regimenes] FOREIGN KEY([hotel_regimen_regimen_id])
REFERENCES [DENVER].[regimenes] ([regimen_id])
GO

ALTER TABLE [DENVER].[hoteles_regimenes] CHECK CONSTRAINT [FK_hoteles_regimenes_regimenes]
GO

ALTER TABLE [DENVER].[hoteles] ADD  CONSTRAINT [DF_hoteles_hotel_activo]  DEFAULT ('S') FOR [hotel_activo]
GO

ALTER TABLE [DENVER].[hoteles]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_paises] FOREIGN KEY([hotel_pais_id])
REFERENCES [DENVER].[paises] ([pais_id])
GO

ALTER TABLE [DENVER].[hoteles] CHECK CONSTRAINT [FK_hoteles_paises]
GO

ALTER TABLE [DENVER].[habitaciones] ADD  CONSTRAINT [DF_habitaciones_habitacion_activa]  DEFAULT ('S') FOR [habitacion_activa]
GO

ALTER TABLE [DENVER].[habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_habitaciones_hoteles] FOREIGN KEY([habitacion_hotel_id])
REFERENCES [DENVER].[hoteles] ([hotel_id])
GO

ALTER TABLE [DENVER].[habitaciones] CHECK CONSTRAINT [FK_habitaciones_hoteles]
GO

ALTER TABLE [DENVER].[habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_habitaciones_tipo_habitaciones] FOREIGN KEY([habitacion_tipo_habitacion_id])
REFERENCES [DENVER].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [DENVER].[habitaciones] CHECK CONSTRAINT [FK_habitaciones_tipo_habitaciones]
GO

ALTER TABLE [DENVER].[clientes] ADD  CONSTRAINT [DF_clientes_cliente_activo]  DEFAULT ('S') FOR [cliente_activo]
GO

ALTER TABLE [DENVER].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_paises] FOREIGN KEY([cliente_pais_id])
REFERENCES [DENVER].[paises] ([pais_id])
GO

ALTER TABLE [DENVER].[clientes] CHECK CONSTRAINT [FK_clientes_paises]
GO

ALTER TABLE [DENVER].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tipo_documentos] FOREIGN KEY([cliente_tipo_documento_id])
REFERENCES [DENVER].[tipo_documentos] ([tipo_documento_id])
GO

ALTER TABLE [DENVER].[clientes] CHECK CONSTRAINT [FK_clientes_tipo_documentos]
GO


ALTER TABLE [DENVER].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_clientes] FOREIGN KEY([consumible_cliente_tipo_documento_id], [consumible_cliente_pasaporte_nro])
REFERENCES [DENVER].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [DENVER].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_clientes]
GO

ALTER TABLE [DENVER].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_consumibles] FOREIGN KEY([consumible_cliente_consumible_id])
REFERENCES [DENVER].[consumibles] ([consumible_id])
GO

ALTER TABLE [DENVER].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_consumibles]
GO

ALTER TABLE [DENVER].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_reservas] FOREIGN KEY([consumible_cliente_reserva_codigo])
REFERENCES [DENVER].[reservas] ([reserva_codigo])
GO

ALTER TABLE [DENVER].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_reservas]
GO


ALTER TABLE [DENVER].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_clientes] FOREIGN KEY([estadia_cliente_tipo_documento_id], [estadia_cliente_pasaporte_nro])
REFERENCES [DENVER].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [DENVER].[estadias] CHECK CONSTRAINT [FK_estadias_clientes]
GO

ALTER TABLE [DENVER].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_hoteles] FOREIGN KEY([estadia_hotel_id])
REFERENCES [DENVER].[hoteles] ([hotel_id])
GO

ALTER TABLE [DENVER].[estadias] CHECK CONSTRAINT [FK_estadias_hoteles]
GO

ALTER TABLE [DENVER].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_reservas] FOREIGN KEY([estadia_reserva_codigo])
REFERENCES [DENVER].[reservas] ([reserva_codigo])
GO

ALTER TABLE [DENVER].[estadias] CHECK CONSTRAINT [FK_estadias_reservas]
GO

ALTER TABLE [DENVER].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_usuarios1] FOREIGN KEY([estadia_usuario_user])
REFERENCES [DENVER].[usuarios] ([usuario_user])
GO

ALTER TABLE [DENVER].[estadias] CHECK CONSTRAINT [FK_estadias_usuarios1]
GO

ALTER TABLE [DENVER].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_clientes] FOREIGN KEY([factura_cliente_tipo_documento], [factura_pasaporte_nro])
REFERENCES [DENVER].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [DENVER].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_hotel] FOREIGN KEY([factura_hotel_id])
REFERENCES [DENVER].[hoteles] ([hotel_id])
GO

ALTER TABLE [DENVER].[facturas] CHECK CONSTRAINT [FK_facturas_clientes]
GO

ALTER TABLE [DENVER].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_formas_pago] FOREIGN KEY([factura_forma_pago_id])
REFERENCES [DENVER].[formas_pago] ([forma_pago_id])
GO

ALTER TABLE [DENVER].[facturas] CHECK CONSTRAINT [FK_facturas_formas_pago]
GO

ALTER TABLE [DENVER].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_consumibles] FOREIGN KEY([factura_consumible_id])
REFERENCES [DENVER].[consumibles] ([consumible_id])
GO

ALTER TABLE [DENVER].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_consumibles]
GO

ALTER TABLE [DENVER].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_facturas] FOREIGN KEY([factura_item_nro])
REFERENCES [DENVER].[facturas] ([factura_nro])
GO

ALTER TABLE [DENVER].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_facturas]
GO

ALTER TABLE [DENVER].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_reservas] FOREIGN KEY([factura_reserva_codigo])
REFERENCES [DENVER].[reservas] ([reserva_codigo])
GO

ALTER TABLE [DENVER].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_reservas]
GO

ALTER TABLE [DENVER].[disponibilidades] ADD  CONSTRAINT [DF_disponibilidades_disponibilidad_ocupado]  DEFAULT ('N') FOR [disponibilidad_ocupado]
GO

ALTER TABLE [DENVER].[disponibilidades]  WITH CHECK ADD  CONSTRAINT [FK_disponibilidades_habitaciones] FOREIGN KEY([disponibilidad_habitacion_nro], [disponibilidad_hotel_id])
REFERENCES [DENVER].[habitaciones] ([habitacion_nro], [habitacion_hotel_id])
GO

ALTER TABLE [DENVER].[disponibilidades] CHECK CONSTRAINT [FK_disponibilidades_habitaciones]
GO

ALTER TABLE [DENVER].[disponibilidades]  WITH CHECK ADD  CONSTRAINT [FK_disponibilidades_tipo_habitaciones] FOREIGN KEY([disponibilidad_tipo_habitacion_id])
REFERENCES [DENVER].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [DENVER].[disponibilidades] CHECK CONSTRAINT [FK_disponibilidades_tipo_habitaciones]
GO

/*  --------------------------------------------------------------------------------
CREACION DE LOS INDICES
-------------------------------------------------------------------------------- */

CREATE NONCLUSTERED INDEX [IX_calle] ON [DENVER].[hoteles]
(
      [hotel_calle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_ciudad] ON [DENVER].[hoteles]
(
      [hotel_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_disponibilidad_fecha] ON [DENVER].[disponibilidades]
(
      [disponibilidad_fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_disponibilidad_ocupado] ON [DENVER].[disponibilidades]
(
      [disponibilidad_ocupado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_disponibilidad_hotel_id] ON [DENVER].[disponibilidades]
(
      [disponibilidad_hotel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_disponibilidad_habitacion_nro] ON [DENVER].[disponibilidades]
(
      [disponibilidad_habitacion_nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_disponibilidad_tipo_habitacion_id] ON [DENVER].[disponibilidades]
(
      [disponibilidad_tipo_habitacion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO


-------------------------------------------------------------------------------- */

CREATE FUNCTION DENVER.cant_pasajeros_tipo_habitacion (@tipo_habitacion numeric(18,0))
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

/****** PAISES  ******/
INSERT INTO DENVER.paises VALUES (1, 'ARGENTINA');
INSERT INTO DENVER.paises VALUES (2, 'CHILE');
INSERT INTO DENVER.paises VALUES (3, 'URUGUAY');
INSERT INTO DENVER.paises VALUES (4, 'PARAGUAY');
INSERT INTO DENVER.paises VALUES (5, 'BOLIVIA');
INSERT INTO DENVER.paises VALUES (6, 'COLOMBIA');
INSERT INTO DENVER.paises VALUES (7, 'PERÚ');
INSERT INTO DENVER.paises VALUES (8, 'BRASIL');
INSERT INTO DENVER.paises VALUES (9, 'ECUADOR');
INSERT INTO DENVER.paises VALUES (10, 'VENEZUELA');
INSERT INTO DENVER.paises VALUES (11, 'PANAMÁ');
INSERT INTO DENVER.paises VALUES (12, 'COSTA RICA');
INSERT INTO DENVER.paises VALUES (13, 'HONDURAS');
INSERT INTO DENVER.paises VALUES (14, 'GUATEMALA');
INSERT INTO DENVER.paises VALUES (15, 'MÉXICO');
INSERT INTO DENVER.paises VALUES (16, 'CUBA');
INSERT INTO DENVER.paises VALUES (17, 'NICARAGUA');
INSERT INTO DENVER.paises VALUES (18, 'EL SALVADOR');
INSERT INTO DENVER.paises VALUES (19, 'HAITÍ');
INSERT INTO DENVER.paises VALUES (20, 'REPÚBLICA DOMINICANA');
INSERT INTO DENVER.paises VALUES (21, 'PUERTO RICO');
INSERT INTO DENVER.paises VALUES (22, 'ESPAÑA');
GO

/****** FORMAS_PAGO  ******/
INSERT INTO DENVER.formas_pago VALUES (1, 'EFECTIVO');
INSERT INTO DENVER.formas_pago VALUES (2, 'TARJETA DE CREDITO');
INSERT INTO DENVER.formas_pago VALUES (3, 'TARJETA DE DEBITO');
INSERT INTO DENVER.formas_pago VALUES (4, 'CHEQUE');
GO

/****** ESTADOS  ******/
INSERT INTO DENVER.estados VALUES (1, 'RESERVA CORRECTA');
INSERT INTO DENVER.estados VALUES (2, 'RESERVA MODIFICADA');
INSERT INTO DENVER.estados VALUES (3, 'RESERVA CANCELADA POR RECEPCIÓN');
INSERT INTO DENVER.estados VALUES (4, 'RESERVA CANCELADA POR CLIENTE');
INSERT INTO DENVER.estados VALUES (5, 'RESERVA CANCELADA POR NO-SHOW');
INSERT INTO DENVER.estados VALUES (6, 'RESERVA CON INGRESO (EFECTIVIZADA)');
INSERT INTO DENVER.estados VALUES (7, 'RESERVA CON INGRESO (FACTURADA)');
GO

/****** tipo_documentos  ******/
INSERT INTO DENVER.tipo_documentos VALUES (1, 'PASAPORTE');
INSERT INTO DENVER.tipo_documentos VALUES (2, 'DNI');
INSERT INTO DENVER.tipo_documentos VALUES (3, 'LE');
INSERT INTO DENVER.tipo_documentos VALUES (4, 'LC');
INSERT INTO DENVER.tipo_documentos VALUES (5, 'CEDULA POLICIAL');
GO

/****** usuarios  ******/
INSERT INTO DENVER.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('GUEST', HASHBYTES('SHA2_256','GUEST'),'GUEST','GUEST');
INSERT INTO DENVER.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('MIGRATION', HASHBYTES('SHA2_256','MIGRATION'),'MIGRATION','MIGRATION');
INSERT INTO DENVER.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('ADMIN', HASHBYTES('SHA2_256','W23E'),'ADMIN','ADMIN');
INSERT INTO DENVER.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('RECEPCION', HASHBYTES('SHA2_256','RECEPCION'),'RECEPCION','RECEPCION');
GO


/****** roles  ******/
INSERT INTO DENVER.roles (rol_nombre, rol_created) VALUES ('ADMINISTRADOR GENERAL',GETDATE());
INSERT INTO DENVER.roles (rol_nombre, rol_created) VALUES ('RECEPCIONISTA',GETDATE());
INSERT INTO DENVER.roles (rol_nombre, rol_created) VALUES ('GUEST',GETDATE());
GO

/****** usuarios_roles  ******/
INSERT INTO DENVER.usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('ADMIN','ADMINISTRADOR GENERAL',GETDATE());
INSERT INTO DENVER.usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('RECEPCION','RECEPCIONISTA',GETDATE());
INSERT INTO DENVER.usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('GUEST','GUEST',GETDATE());
GO

/****** funcionalidades  ******/
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE ROL', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE USUARIO', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE CLIENTE', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE HOTEL', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE HABITACIÓN', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM RÉGIMEN DE ESTADÍA', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('GENERAR O MODIFICAR UN RESERVA', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('CANCELAR RESERVA', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('REGISTRAR ESTADÍA (CHECK-IN/CHECK-OUT)', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('REGISTRAR CONSUMIBLES', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('FACTURAR ESTADÍA', GETDATE());
INSERT INTO DENVER.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('LISTADO ESTADÍSTICO', GETDATE());
GO

/****** funcionalidades por rol  ******/
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 1);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 2);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 3);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 4);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 5);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 6);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 7);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 8);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 9);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 10);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 11);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('ADMINISTRADOR GENERAL', 12);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('GUEST', 7);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('RECEPCIONISTA', 3);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('RECEPCIONISTA', 7);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('RECEPCIONISTA', 8);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('RECEPCIONISTA', 9);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('RECEPCIONISTA', 10);
INSERT INTO DENVER.roles_funcionalidades (rol_funcionalidad_rol_nombre, rol_funcionalidad_funcionalidad_id) VALUES ('RECEPCIONISTA', 11);
GO


/****** CLIENTES ******/
INSERT INTO DENVER.clientes (cliente_pasaporte_nro,cliente_apellido,cliente_nombre,cliente_fecha_nac,cliente_email,cliente_dom_calle,
cliente_dom_nro,cliente_piso,cliente_dpto,cliente_nacionalidad,cliente_tipo_documento_id, cliente_pais_id, cliente_created)  (

SELECT 
      [Cliente_Pasaporte_Nro]
      ,[Cliente_Apellido]
      ,[Cliente_Nombre]
      ,[Cliente_Fecha_Nac]
      ,convert(varchar,Cliente_Pasaporte_Nro)+'@CAMBIAR'
      ,[Cliente_Dom_Calle]
      ,[Cliente_Nro_Calle]
      ,[Cliente_Piso]
      ,[Cliente_Depto]
      ,[Cliente_Nacionalidad]
        , 1, 1,  GETDATE()
  FROM [GD1C2018].[gd_esquema].[Maestra]
  WHERE
      [Cliente_Pasaporte_Nro] NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921) AND     
      [Factura_Nro] IS NOT NULL
  GROUP BY
            [Cliente_Pasaporte_Nro]
      ,[Cliente_Apellido]
      ,[Cliente_Nombre]
      ,[Cliente_Fecha_Nac]
      ,[Cliente_Dom_Calle]
      ,[Cliente_Nro_Calle]
      ,[Cliente_Piso]
      ,[Cliente_Depto]
      ,[Cliente_Nacionalidad]
)
GO

/****** HOTELES ******/
INSERT INTO DENVER.hoteles 
(hotel_nombre,hotel_ciudad, hotel_calle, hotel_nro_calle, hotel_estrellas, hotel_recarga_estrella, hotel_pais_id, hotel_created)
( 
SELECT     concat('Suc. ',Hotel_Calle),Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 1, GETDATE()
FROM         gd_esquema.Maestra
GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella
)
GO


/****** usuarios_hoteles  ******/
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'GUEST');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'MIGRATION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'ADMIN');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'RECEPCION');
INSERT INTO DENVER.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'RECEPCION');

GO

/****** TIPO_HABITACIONES ******/
INSERT INTO DENVER.tipo_habitaciones (tipo_habitacion_descripcion, tipo_habitacion_porcentual, tipo_habitacion_id, tipo_habitacion_created)
(
SELECT  DISTINCT   Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual, Habitacion_Tipo_Codigo, GETDATE()
FROM         gd_esquema.Maestra

)
GO

/****** HABITACIONES ******/
INSERT INTO DENVER.habitaciones 
(habitacion_nro, habitacion_piso, habitacion_frente, habitacion_created, habitacion_hotel_id, habitacion_tipo_habitacion_id)
(
SELECT distinct Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, GETDATE(), (SELECT distinct top 1 t1.hotel_id FROM DENVER.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad), Habitacion_Tipo_Codigo
FROM         gd_esquema.Maestra

)
GO

/****** CONSUMIBLES ******/
INSERT INTO DENVER.consumibles
(consumible_id, consumible_descripcion, consumible_precio, consumible_created)
(
SELECT     Consumible_Codigo, Consumible_Descripcion, Consumible_Precio, GETDATE()
FROM         gd_esquema.Maestra
WHERE Consumible_Codigo is not null
GROUP BY Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
)
GO
INSERT INTO DENVER.consumibles (consumible_id, consumible_descripcion, consumible_precio, consumible_created) VALUES (9999,'Otros',0,getdate());
GO

/****** REGIMENES ******/
INSERT INTO DENVER.regimenes
(regimen_descripcion,regimen_precio,regimen_created)
(
SELECT     Regimen_Descripcion, Regimen_Precio, GETDATE()
FROM         gd_esquema.Maestra
group by Regimen_Descripcion, Regimen_Precio
)
GO


/****** HOTELES_REGIMENES ******/
INSERT INTO DENVER.hoteles_regimenes
(hotel_regimen_hotel_id,hotel_regimen_regimen_id)
(
SELECT DISTINCT    
(SELECT distinct top 1 t1.hotel_id FROM DENVER.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad),
(SELECT distinct t1.regimen_id FROM DENVER.regimenes as t1 WHERE t1.regimen_descripcion = gd_esquema.Maestra.Regimen_Descripcion)
 
FROM gd_esquema.Maestra
)
GO


/****** RESERVAS ******/
INSERT INTO DENVER.reservas
(reserva_fecha_inicio, reserva_fecha_fin,reserva_codigo,reserva_cant_noches, reserva_cliente_tipo_documento_id, reserva_cliente_pasaporte_nro, reserva_hotel_id, reserva_usuario_user, reserva_estado_id, reserva_created)
(
SELECT     Reserva_Fecha_Inicio, (Reserva_Fecha_Inicio+Reserva_Cant_Noches), Reserva_Codigo, Reserva_Cant_Noches, 1, Cliente_Pasaporte_Nro, (SELECT distinct top 1 t1.hotel_id FROM DENVER.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad), 'MIGRATION',1, getdate()
FROM         gd_esquema.Maestra
WHERE
      Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)
  GROUP BY
      Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Hotel_Calle, Hotel_Ciudad
)
GO

/****** RESERVAS_HABITACIONES ******/
INSERT INTO DENVER.reservas_habitaciones
(reserva_habitaciones_reserva_codigo,reserva_habitaciones_fecha_inicio,reserva_habitaciones_fecha_fin,reserva_habitaciones_tipo_habitacion_id,reserva_habitaciones_cant_noches,reserva_habitaciones_regimen_id,reserva_habitacion_nro,reserva_habitaciones_precio)
(
SELECT  Reserva_Codigo, Reserva_Fecha_Inicio, (Reserva_Fecha_Inicio+Reserva_Cant_Noches), Habitacion_Tipo_Codigo, Reserva_Cant_Noches, (SELECT TOP 1 t1.regimen_id FROM DENVER.regimenes as t1 WHERE t1.regimen_descripcion = gd_esquema.Maestra.Regimen_Descripcion), Habitacion_Numero, ((Regimen_Precio * DENVER.cant_pasajeros_tipo_habitacion(Habitacion_Tipo_Codigo)) + Hotel_Recarga_Estrella)
FROM         gd_esquema.Maestra
WHERE
      Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)
group by Reserva_Codigo, Habitacion_Tipo_Codigo, Reserva_Fecha_Inicio, Reserva_Cant_Noches, Habitacion_Numero, Regimen_Descripcion, Regimen_Precio,Hotel_Recarga_Estrella

)
GO


/****** ESTADIAS ******/
INSERT INTO DENVER.estadias
(estadia_cliente_tipo_documento_id,estadia_cliente_pasaporte_nro,estadia_fecha_inicio,estadia_cant_noches,estadia_fecha_fin,estadia_hotel_id,estadia_reserva_codigo,estadia_usuario_user,estadia_created)
SELECT  
      1
      ,Cliente_Pasaporte_Nro
      ,Estadia_Fecha_Inicio  
      ,Estadia_Cant_Noches    
      ,(Estadia_Fecha_Inicio+Estadia_Cant_Noches)
      ,(SELECT distinct top 1 t1.hotel_id FROM DENVER.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad)
      ,Reserva_Codigo
      , 'MIGRATION',getdate()

FROM GD1C2018.gd_esquema.Maestra
WHERE 
      Estadia_Fecha_Inicio is not null AND Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)

/****** CONSUMIBLES_CLIENTES ******/
INSERT INTO DENVER.consumibles_clientes
(consumible_cliente_consumible_id, consumible_cliente_pasaporte_nro, consumible_cliente_tipo_documento_id, consumible_cliente_fecha_consumo, consumible_cliente_reserva_codigo)
(
SELECT     Consumible_Codigo, Cliente_Pasaporte_Nro, 1, NULL, (SELECT TOP 1 reserva_codigo FROM DENVER.reservas WHERE reserva_cliente_pasaporte_nro = gd_esquema.Maestra.Cliente_Pasaporte_Nro)
FROM         gd_esquema.Maestra
WHERE
      Consumible_Codigo IS NOT NULL AND  Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)
GROUP BY
      Consumible_Codigo, Cliente_Pasaporte_Nro
)
GO

/****** FACTURA ******/
insert into DENVER.facturas (factura_nro, factura_fecha, factura_total, factura_forma_pago_id, factura_cliente_tipo_documento, factura_pasaporte_nro, factura_created, factura_hotel_id)
(
SELECT distinct Factura_Nro,Factura_Fecha,Factura_Total,1,1,Cliente_Pasaporte_Nro, Factura_Fecha, (SELECT distinct top 1 t1.hotel_id FROM DENVER.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad) 
FROM gd_esquema.Maestra 
where Factura_Nro is not null AND  Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
88559381,89094646,90135406,91296720,95744921)
)      
GO

/****** FACTURA_ITEM ******/
insert into DENVER.facturas_items (factura_item_nro, factura_item_cant, factura_item_monto, factura_consumible_id, factura_reserva_codigo)
(
SELECT 
      Factura_Nro, Item_Factura_Cantidad, Item_Factura_Monto, Consumible_Codigo, Reserva_Codigo
FROM [gd_esquema].[Maestra]
  where [Factura_Nro] is not null and [Consumible_Codigo] is not null and [Reserva_Codigo] is not null and Factura_Nro not in (SELECT distinct Factura_Nro
FROM gd_esquema.Maestra 
where Factura_Nro is not null AND  Cliente_Pasaporte_Nro IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
88559381,89094646,90135406,91296720,95744921))
)
GO

/*  --------------------------------------------------------------------------------
CREACION DE  LOS SP
-------------------------------------------------------------------------------- */

CREATE PROCEDURE [DENVER].[buscar_cliente]    
      @cliente_apellido nvarchar(255) = NULL ,
      @cliente_nombre nvarchar(255) = NULL,
      @cliente_tipo_doc int = NULL,
      @cliente_nro_doc int = NULL 
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  

      SELECT 
            tipo_documentos.tipo_documento_nombre AS Tipo_Doc , cliente_pasaporte_nro AS Pasaporte, cliente_apellido AS Apellido, cliente_nombre AS Nombre, cliente_email AS Email, concat(cliente_dom_calle,' ',cliente_dom_nro,' ',cliente_piso,' ',cliente_dpto,' ',cliente_dom_localidad) AS Direccion, tipo_documentos.tipo_documento_id
                  FROM 
            DENVER.clientes  
            INNER JOIN DENVER.tipo_documentos ON cliente_tipo_documento_id = tipo_documento_id 
      WHERE cliente_apellido LIKE '%' + ISNULL(@cliente_apellido, cliente_apellido) + '%'
            AND cliente_nombre LIKE '%' + ISNULL(@cliente_nombre, cliente_nombre) + '%'
            AND cliente_pasaporte_nro = ISNULL(@cliente_nro_doc, cliente_pasaporte_nro)
            AND  cliente_activo != 'N'
            AND cliente_tipo_documento_id = ISNULL(@cliente_tipo_doc, cliente_tipo_documento_id)  ;
END
GO

CREATE PROCEDURE [DENVER].[cargar_cliente]    
      @cliente_tipo_documento smallint = NULL,
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
      @cliente_pais_id smallint = NULL,
      @fecha_sistema datetime
AS
BEGIN
      SET NOCOUNT ON; 

      INSERT INTO clientes(
            cliente_nombre,
            cliente_apellido,
            cliente_tipo_documento_id,
            cliente_pasaporte_nro,
            cliente_email,
            cliente_telefono,
            cliente_dom_calle,
            cliente_dom_nro,
            cliente_piso,
            cliente_dpto,
            cliente_dom_localidad,
            cliente_pais_id,
            cliente_nacionalidad,
            cliente_fecha_nac,
            cliente_created)
      VALUES(
            @cliente_nombre,
            @cliente_apellido,
            @cliente_tipo_documento,
            @cliente_pasaporte_nro,
            @cliente_email,
            @cliente_telefono,
            @cliente_dom_calle,
            @cliente_dom_nro,
            @cliente_piso,
            @cliente_dpto,
            @cliente_dom_localidad,
            @cliente_pais_id,
            @cliente_nacionalidad,
            @cliente_fecha_nac,
            @fecha_sistema)
END
GO


CREATE PROCEDURE [DENVER].[eliminar_cliente]
      @cliente_tipo_documento_id nvarchar(50),
      @cliente_pasaporte_nro numeric(18,0)
AS
BEGIN
      SET NOCOUNT ON;  

      DECLARE @tip_doc smallint ;

      SELECT @tip_doc = TIPO_DOCUMENTO_ID FROM DENVER.tipo_documentos
            WHERE tipo_documento_nombre = @cliente_tipo_documento_id ;

      UPDATE [DENVER].[clientes]
            SET cliente_activo = 'N'
      WHERE 
             cliente_tipo_documento_id = @tip_doc AND
             cliente_pasaporte_nro = @cliente_pasaporte_nro 
END
GO


CREATE PROCEDURE [DENVER].[cargar_hotel]
      @hotel_nombre nvarchar(255),
      @hotel_email nvarchar(255),
      @hotel_telefono nvarchar(255),
      @hotel_calle nvarchar(255),
      @hotel_nro_calle numeric(18,0),
      @hotel_estrellas numeric(18,0),
      @hotel_ciudad nvarchar(255),
      @hotel_pais_id smallint,
      @hotel_regimen smallint,
      @user_creador nvarchar(50),
      @fecha_sistema datetime
AS
BEGIN
      
      SET NOCOUNT ON;  

      DECLARE @hotel_id smallint;

      INSERT INTO [DENVER].[hoteles](
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
            @fecha_sistema,
            @hotel_nombre,
            @hotel_email,
            @hotel_telefono,
            @hotel_pais_id,
            'S'
)

        SELECT TOP 1 @hotel_id = HOTEL_ID 
          FROM DENVER.hoteles ORDER BY hotel_id DESC

    INSERT INTO   DENVER.hoteles_regimenes (
                        hotel_regimen_hotel_id,
                        hotel_regimen_regimen_id )
                        VALUES (
                        @hotel_id,
                        @hotel_regimen)

      INSERT INTO DENVER.usuarios_hoteles (
                        usuario_hotel_id,
                        usuario_usuario_user)
                        VALUES (
                         @hotel_id,
                         @user_creador)
END
GO

CREATE PROCEDURE [DENVER].[eliminar_hotel]
      @hotel_id smallint
AS
BEGIN
      SET NOCOUNT ON;  
      UPDATE [DENVER].[hoteles]
            SET hotel_activo = 'N'
      WHERE
            @hotel_id = hotel_id
END
GO



CREATE PROCEDURE [DENVER].[cargar_habitacion]
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
      habitacion_hotel_id,
      habitacion_activa,
      habitacion_created)
      VALUES(
      @habitacion_nro,
      @habitacion_piso,
      @habitacion_frente,
      @habitacion_tipo_habitacion_id,
      @habitacion_descripcion,
      @habitacion_hotel_id,
      'S',
      GETDATE())
END
GO


CREATE PROCEDURE [DENVER].[eliminar_habitacion]
      @habitacion_nro numeric(18,0),
      @habitacion_hotel_id smallint
AS
BEGIN
      SET NOCOUNT ON;  
      UPDATE [DENVER].[habitaciones]
            SET habitacion_activa = 'N'
      WHERE
            @habitacion_hotel_id = habitacion_hotel_id AND
            @habitacion_nro = habitacion_nro
END
GO

CREATE PROCEDURE [DENVER].[alta_habitacion]
      @habitacion_nro numeric(18,0),
      @habitacion_hotel_id smallint
AS
BEGIN
      SET NOCOUNT ON;  
      UPDATE [DENVER].[habitaciones]
            SET habitacion_activa = 'S'
      WHERE
            @habitacion_hotel_id = habitacion_hotel_id AND
            @habitacion_nro = habitacion_nro
END
GO

CREATE PROCEDURE [DENVER].[eliminar_regimen]
      @regimen_id numeric(18,0)
AS
BEGIN
      SET NOCOUNT ON;  
      UPDATE [DENVER].[regimenes]
            SET regimen_activo = 'N'
      WHERE
            @regimen_id = regimen_id
END
GO


CREATE PROCEDURE [DENVER].[actualizar_estado_rol]
      @rol_nombre nvarchar(255),
      @rol_estado char
AS
BEGIN
      SET NOCOUNT ON;  
      UPDATE [DENVER].[roles]
            SET rol_activo = @rol_estado
            WHERE @rol_nombre = rol_nombre
END
GO


CREATE PROCEDURE [DENVER].[cargar_usuario]
      @usuario_user nvarchar(50),
      @usuario_pass varchar(50),
      @usuario_nombre nvarchar(255),
      @usuario_apellido nvarchar(255),
      @usuario_tipo_documento_id smallint,
      @usuario_nro_documento nvarchar(255),
      @usuario_email nvarchar(255),
      @usuario_telefono nvarchar(255),
      @usuario_direccion nvarchar(255),
      @usuario_fecha_nac datetime,
      @usuario_rol nvarchar(255),
    @usuario_hotel smallint,
      @fecha_sistema datetime

AS
BEGIN
      SET NOCOUNT ON;  
      INSERT INTO [DENVER].[usuarios](
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
            HASHBYTES('SHA2_256',UPPER(@usuario_pass)),
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
            @fecha_sistema) 

            INSERT INTO [DENVER].[usuarios_roles](
                  usuario_rol_usuario_user,
                  usuario_rol_rol_nombre,
                  usuario_rol_created
                  )
            VALUES (
             @usuario_user,
             @usuario_rol,
             @fecha_sistema)

             INSERT INTO [DENVER].[usuarios_hoteles](
                 usuario_hotel_id,
                   usuario_usuario_user
                   )
                   VALUES (
                   @usuario_hotel,
                   @usuario_user)


END
GO


CREATE PROCEDURE [DENVER].[eliminar_usuario]
      @usuario_user nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;  
      UPDATE [DENVER].[usuarios]
            SET usuario_activo = 'N'
      WHERE
            @usuario_user = usuario_user
END
GO

CREATE PROCEDURE [DENVER].[buscar_cliente_completo] 
      @cliente_doc nvarchar(50) = NULL,
      @cliente_dni int = NULL 
AS   
BEGIN 
    -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  

      SELECT *
            FROM clientes 
             INNER JOIN tipo_documentos ON cliente_tipo_documento_id = tipo_documento_id 
              WHERE     cliente_pasaporte_nro  = ISNULL(@cliente_dni, cliente_pasaporte_nro) 
                AND tipo_documento_nombre  = ISNULL(@cliente_doc, tipo_documento_nombre) ;
END
GO


CREATE PROCEDURE [DENVER].[modificar_cliente] 
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

      SELECT @tipo_documento_id = TIPO_DOCUMENTO_ID FROM DENVER.tipo_documentos
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

CREATE PROCEDURE [DENVER].[buscar_hotel]    
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

      SELECT hotel_nombre AS Nombre,hotel_estrellas AS Estrellas, p.pais_nombre AS Pais, hotel_ciudad AS Ciudad, hotel_email AS Email, hotel_id 
      FROM 
            DENVER.hoteles
            join DENVER.paises p on hotel_pais_id = p.pais_id
       WHERE hotel_nombre LIKE '%' + ISNULL(@hotel_nombre, hotel_nombre) + '%'
            AND hotel_ciudad LIKE '%' + ISNULL(@hotel_ciudad, hotel_ciudad) + '%'
            AND hotel_pais_id = ISNULL(@pais_id, hotel_pais_id) 
            AND hotel_estrellas = ISNULL(@hotel_estrellas, hotel_estrellas) ;
END
GO

CREATE PROCEDURE [DENVER].[baja_hotel]    
      @id_hotel smallint = NULL ,
      @fecha_inicio datetime = NULL,
      @fecha_fin  datetime = NULL, 
      @motivo nvarchar(255) = NULL,
      @fecha_sistema datetime,
	  @result	int OUTPUT
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
     -- DECLARE @cont int;
      SET NOCOUNT ON;  
      SELECT @result = count(*) from DENVER.reservas
      WHERE( reserva_fecha_inicio BETWEEN  @fecha_inicio AND @fecha_fin
          OR reserva_fecha_fin    BETWEEN  @fecha_inicio AND @fecha_fin )
         AND reserva_hotel_id = @id_hotel 

         IF (@result = 0) 
         BEGIN

            INSERT INTO [DENVER].[mantenimientos](
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
                        @fecha_sistema);
           
			END
		RETURN @result  
END
GO

CREATE PROCEDURE DENVER.marcar_intentos_loguin_fallidos 
      @usuario_user nvarchar(50) = NULL
AS
BEGIN
      SET NOCOUNT ON;

      UPDATE usuarios SET usuario_login_fallidos = usuario_login_fallidos + 1 WHERE usuario_user = @usuario_user;
END
GO

CREATE PROCEDURE DENVER.inhabilitar_usuario 
      @usuario_user nvarchar(50) = NULL
AS
BEGIN
      SET NOCOUNT ON;
      UPDATE usuarios SET usuario_activo = 'N' WHERE usuario_user = @usuario_user;
END
GO

CREATE PROCEDURE DENVER.reset_intentos_loguin_fallidos 
      @usuario_user nvarchar(50) = NULL
AS
BEGIN
      SET NOCOUNT ON;

      UPDATE usuarios SET usuario_login_fallidos = 0 WHERE usuario_user = @usuario_user;
END
GO


CREATE FUNCTION DENVER.cant_roles_usuario (@usuario_user nvarchar(50))
RETURNS int
AS
BEGIN
      RETURN (SELECT count(*) FROM DENVER.usuarios_roles WHERE usuario_rol_usuario_user = @usuario_user)

END
GO


CREATE PROCEDURE DENVER.obtener_hoteles
      @usuario_user nvarchar(50) = NULL
AS
BEGIN
      SET NOCOUNT ON;
      SELECT 
            h.hotel_id, h.hotel_nombre 
      FROM 
            DENVER.hoteles as h
            JOIN DENVER.usuarios_hoteles as uh ON h.hotel_id = uh.usuario_hotel_id
      WHERE
            uh.usuario_usuario_user = ISNULL(@usuario_user, uh.usuario_usuario_user)
    GROUP BY
            h.hotel_id, h.hotel_nombre 
      ORDER BY 
            h.hotel_nombre
END
GO

CREATE PROCEDURE DENVER.obtener_tipo_documento
AS
BEGIN
      SET NOCOUNT ON;
      SELECT tipo_documento_id,tipo_documento_nombre FROM DENVER.tipo_documentos ORDER BY tipo_documento_nombre
END
GO

CREATE PROCEDURE DENVER.obtener_regimenes
      @hotel_id smallint
AS
BEGIN
      SET NOCOUNT ON;
      SELECT 
            regimen_id,regimen_descripcion 
      FROM 
            DENVER.regimenes AS r
            JOIN DENVER.hoteles_regimenes AS hr ON r.regimen_id = hr.hotel_regimen_regimen_id
      WHERE
            hr.hotel_regimen_hotel_id = ISNULL(@hotel_id, hr.hotel_regimen_hotel_id)
      group by
            regimen_id,regimen_descripcion 
      ORDER BY regimen_descripcion
END
GO

CREATE PROCEDURE DENVER.obtener_habitaciones
      @hotel_id smallint
AS
BEGIN
      SET NOCOUNT ON;
      SELECT habitacion_nro FROM DENVER.habitaciones WHERE habitacion_hotel_id = @hotel_id ORDER BY habitacion_nro
END
GO



CREATE PROCEDURE DENVER.obtener_consumibles
AS
BEGIN
      SET NOCOUNT ON;
      SELECT consumible_id, consumible_descripcion FROM DENVER.consumibles WHERE consumible_id <> 9999 ORDER BY consumible_descripcion
END
GO

CREATE PROCEDURE DENVER.obtener_tipo_habitaciones
AS
BEGIN
      SET NOCOUNT ON;
      SELECT tipo_habitacion_id,tipo_habitacion_descripcion FROM DENVER.tipo_habitaciones ORDER BY tipo_habitacion_descripcion
END
GO

CREATE PROCEDURE DENVER.obtener_paises
AS
BEGIN
      SET NOCOUNT ON;
      SELECT pais_id, pais_nombre FROM DENVER.paises ORDER BY pais_nombre
END
GO

CREATE PROCEDURE DENVER.obtener_formas_pago
AS
BEGIN
      SET NOCOUNT ON;
      SELECT forma_pago_id, forma_pago_nombre FROM DENVER.formas_pago ORDER BY forma_pago_nombre
END
GO

CREATE PROCEDURE DENVER.obtener_roles
      @usuario_user nvarchar(50) = NULL
AS
BEGIN
      SET NOCOUNT ON;

      IF (@usuario_user IS NULL)
            SELECT 
                  r.rol_nombre
            FROM 
                  DENVER.roles AS r
            WHERE
                  r.rol_activo = 'S'
            GROUP BY
                  r.rol_nombre
            ORDER BY 
                  r.rol_nombre
      ELSE
            SELECT 
                  r.rol_nombre
            FROM 
                  DENVER.roles AS r
                  LEFT JOIN DENVER.usuarios_roles AS ur ON  r.rol_nombre = ur.usuario_rol_rol_nombre
            WHERE
                  ur.usuario_rol_usuario_user = ISNULL(@usuario_user, ur.usuario_rol_usuario_user) AND r.rol_activo = 'S'
            GROUP BY
                  r.rol_nombre
            ORDER BY 
                  r.rol_nombre
END
GO

CREATE PROCEDURE DENVER.obtener_disponibilidad
      @fecha_desde as datetime,
      @fecha_hasta as datetime,
      @hotel_id as smallint,
      @tipo_habitacion as numeric(18,0),
      @regimen_id as numeric(18,0) = NULL
AS
BEGIN
      SELECT 
            d.disponibilidad_habitacion_nro as "Nro. de Habitacion", th.tipo_habitacion_descripcion as "Tipo de Habitacion", r.regimen_descripcion as Regimen, r.regimen_precio As "Precio Diario por Pax", DENVER.cant_pasajeros_tipo_habitacion(th.tipo_habitacion_id) as "Max Pax", r.regimen_id, th.tipo_habitacion_id, h.hotel_recarga_estrella As "Recarga Hotel"
      from 
            DENVER.disponibilidades as d
            join DENVER.hoteles_regimenes as hr on hr.hotel_regimen_hotel_id = d.disponibilidad_hotel_id
            join DENVER.regimenes as r on r.regimen_id = hr.hotel_regimen_regimen_id
            join DENVER.tipo_habitaciones as th on th.tipo_habitacion_id = d.disponibilidad_tipo_habitacion_id
            join DENVER.hoteles as h on h.hotel_id = d.disponibilidad_hotel_id
      where
            d.disponibilidad_fecha between @fecha_desde and @fecha_hasta
            and d.disponibilidad_hotel_id = @hotel_id
            and d.disponibilidad_ocupado = 0 
            and d.disponibilidad_tipo_habitacion_id = @tipo_habitacion 
            and hr.hotel_regimen_regimen_id = isnull(@regimen_id,hr.hotel_regimen_regimen_id)
            and r.regimen_activo = 'S'
      group by 
            d.disponibilidad_habitacion_nro, th.tipo_habitacion_descripcion, r.regimen_descripcion, r.regimen_precio, th.tipo_habitacion_id, r.regimen_id, h.hotel_recarga_estrella
      having
            count(*) = DATEDIFF(DAY,@fecha_desde,@fecha_hasta)+1        
END
GO

CREATE PROCEDURE DENVER.crear_reserva 
      @reserva_fecha_inicio datetime,
      @reserva_fecha_fin datetime,
      @reserva_cliente_tipo_documento_id smallint,
      @reserva_cliente_pasaporte_nro numeric(18,0),
      @reserva_hotel_id smallint,
      @reserva_usuario_user nvarchar(50),
      @reserva_estado_id smallint,
      @fecha_sistema datetime,
      @nro_reserva numeric(18,0) OUTPUT
AS
BEGIN
      declare @next_id numeric(18,0) = (SELECT TOP 1 reserva_codigo FROM DENVER.reservas ORDER BY reserva_codigo DESC)+1

      insert into DENVER.reservas (reserva_codigo,reserva_fecha_inicio,reserva_fecha_fin,reserva_cant_noches,reserva_cliente_tipo_documento_id,reserva_cliente_pasaporte_nro,reserva_hotel_id,reserva_usuario_user,reserva_estado_id,reserva_created) values (@next_id,@reserva_fecha_inicio,@reserva_fecha_fin,DATEDIFF(day, @reserva_fecha_inicio, @reserva_fecha_fin),@reserva_cliente_tipo_documento_id,@reserva_cliente_pasaporte_nro,@reserva_hotel_id,@reserva_usuario_user,@reserva_estado_id, @fecha_sistema)

      SELECT @nro_reserva = @next_id

END
GO

CREATE PROCEDURE DENVER.agregar_habitaciones_reserva 
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

CREATE FUNCTION DENVER.existe_usuario (@usuario_user nvarchar(50))
RETURNS int
AS
BEGIN
      RETURN (SELECT count(*) FROM DENVER.usuarios WHERE usuario_user = @usuario_user)

END
GO


CREATE PROCEDURE DENVER.obtener_pasajero_reserva 
      @nro_reserva numeric(18,0)
AS
BEGIN
      SELECT
      c.cliente_apellido as Apellido, c.cliente_nombre AS Nombre, td.tipo_documento_nombre AS "Tipo de Documento", c.cliente_pasaporte_nro AS "Nro. de Documento", c.cliente_tipo_documento_id
      FROM
            DENVER.reservas as r
            join DENVER.clientes as c on r.reserva_cliente_tipo_documento_id+r.reserva_cliente_pasaporte_nro=c.cliente_tipo_documento_id+c.cliente_pasaporte_nro
            join DENVER.tipo_documentos td on td.tipo_documento_id = c.cliente_tipo_documento_id
      WHERE
            r.reserva_codigo = @nro_reserva AND r.reserva_estado_id IN (1, 2)
      ORDER BY
            c.cliente_apellido, c.cliente_nombre
END
GO


CREATE PROCEDURE DENVER.obtener_detalle_reserva 
      @nro_reserva numeric(18,0) = NULL,
      @habitacion_nro numeric(18,0) = NULL,
      @chechout char(1) = NULL
AS
BEGIN
      declare @nro_reserva_aux numeric(18,0);

      -- Usado en el checkin
      IF(@nro_reserva IS NOT NULL)
      begin

            if (@chechout IS NULL)
            begin
                  SELECT
                        convert(varchar(50),rh.reserva_habitaciones_fecha_inicio,103) as "Fecha Entrada", convert(varchar(50),rh.reserva_habitaciones_fecha_fin,103) as "Fecha Salida",th.tipo_habitacion_descripcion as "Tipo Habitacion", reg.regimen_descripcion as "Regimen", rh.reserva_habitaciones_precio*rh.reserva_habitaciones_cant_noches as "Precio", rh.reserva_habitacion_nro as "Nro. Habitacion", th.tipo_habitacion_id, r.reserva_estado_id, reg.regimen_id
                  FROM
                        DENVER.reservas as r
                        join DENVER.reservas_habitaciones as rh ON r.reserva_codigo = rh.reserva_habitaciones_reserva_codigo
                        join DENVER.tipo_habitaciones as th on rh.reserva_habitaciones_tipo_habitacion_id = th.tipo_habitacion_id
                        join DENVER.regimenes as reg on reg.regimen_id = rh.reserva_habitaciones_regimen_id
                  WHERE
                        r.reserva_codigo = @nro_reserva AND r.reserva_estado_id NOT IN (3,4,5);
            end
            else
            begin
                  SELECT distinct
                        convert(varchar(50),rh.reserva_habitaciones_fecha_inicio,103) as "Fecha Entrada", convert(varchar(50),rh.reserva_habitaciones_fecha_fin,103) as "Fecha Salida",th.tipo_habitacion_descripcion as "Tipo Habitacion", reg.regimen_descripcion as "Regimen", rh.reserva_habitaciones_precio*rh.reserva_habitaciones_cant_noches as "Precio", rh.reserva_habitacion_nro as "Nro. Habitacion", th.tipo_habitacion_id, r.reserva_estado_id, reg.regimen_id
                  FROM
                        DENVER.reservas as r
                        join DENVER.reservas_habitaciones as rh ON r.reserva_codigo = rh.reserva_habitaciones_reserva_codigo
                        join DENVER.tipo_habitaciones as th on rh.reserva_habitaciones_tipo_habitacion_id = th.tipo_habitacion_id
                        join DENVER.regimenes as reg on reg.regimen_id = rh.reserva_habitaciones_regimen_id
                        join DENVER.disponibilidades as d on d.disponibilidad_fecha between rh.reserva_habitaciones_fecha_inicio and rh.reserva_habitaciones_fecha_fin and d.disponibilidad_habitacion_nro = rh.reserva_habitacion_nro and d.disponibilidad_hotel_id = r.reserva_hotel_id and d.disponibilidad_tipo_habitacion_id = th.tipo_habitacion_id
                  WHERE
                        r.reserva_codigo =  @nro_reserva and d.disponibilidad_ocupado = 1;
            end

      end

      -- Usado en el checkout
      IF(@habitacion_nro IS NOT NULL)
      begin
            SELECT
                  @nro_reserva_aux = r.reserva_codigo
            FROM
                  DENVER.reservas as r
                  join DENVER.reservas_habitaciones as rh ON r.reserva_codigo = rh.reserva_habitaciones_reserva_codigo
                  join DENVER.tipo_habitaciones as th on rh.reserva_habitaciones_tipo_habitacion_id = th.tipo_habitacion_id
                  join DENVER.regimenes as reg on reg.regimen_id = rh.reserva_habitaciones_regimen_id
            WHERE
                  rh.reserva_habitacion_nro = @habitacion_nro AND r.reserva_estado_id IN (6);

            exec DENVER.obtener_detalle_reserva @nro_reserva_aux, NULL, 'S';
      end

END
GO

CREATE PROCEDURE DENVER.cambiar_estado_reserva 
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


CREATE PROCEDURE DENVER.confirmar_checkin 
      @nro_reserva numeric(18,0),
      @estadia_cliente_tipo_documento_id smallint,
      @estadia_cliente_pasaporte_nro numeric(18,0),
      @estadia_fecha_inicio datetime,
      @estadia_fecha_fin datetime,
      @estadia_hotel_id smallint,
      @estadia_usuario_user nvarchar(50)
AS
BEGIN

  INSERT INTO DENVER.estadias (estadia_cliente_tipo_documento_id,estadia_cliente_pasaporte_nro,estadia_fecha_inicio,estadia_cant_noches,estadia_fecha_fin,estadia_hotel_id,estadia_reserva_codigo,estadia_usuario_user,estadia_created) VALUES (@estadia_cliente_tipo_documento_id, @estadia_cliente_pasaporte_nro,@estadia_fecha_inicio,DATEDIFF(day, @estadia_fecha_inicio, @estadia_fecha_fin),@estadia_fecha_fin,@estadia_hotel_id,@nro_reserva,@estadia_usuario_user,GETDATE())

  -- cambio el estado de la reserva
  exec DENVER.cambiar_estado_reserva @nro_reserva, 6

END
GO

-- Hoteles con mayor cantidad de reservas canceladas
CREATE PROCEDURE DENVER.listado1 
      @anio smallint,
      @trimestre smallint
AS
BEGIN
--    DECLARE @meses varchar(50);

--
--    if (@trimestre = 1) set @meses = '(1,2,3)';
--    if (@trimestre = 2) set @meses = '(4,5,6)';
--    if (@trimestre = 3) set @meses = '(7,8,9)';
--    if (@trimestre = 4) set @meses = '(10,11,12)';

      CREATE TABLE #trimestre
    ( mes int)

      if (@trimestre = 1)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (1), (2), (3);
     END
      if (@trimestre = 2)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (4), (5) , (6);
     END
            if (@trimestre = 3)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (7), (8), (9);
     END
            if (@trimestre = 4)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (10), (11), (12);
     END

      select TOP 5
            h.hotel_nombre as Hotel, count(*) as "Total Reservas Canceladas"
      from
            DENVER.reservas as r
            join DENVER.hoteles as h on r.reserva_hotel_id = h.hotel_id
      where
            r.reserva_estado_id IN (3,4,5)
            AND MONTH(r.reserva_fecha_inicio) IN (SELECT mes from #trimestre) AND year(r.reserva_fecha_inicio) = @anio
      --    AND MONTH(r.reserva_fecha_fin) IN (SELECT mes from #trimestre) AND year(r.reserva_fecha_fin) = @anio
      group by
            h.hotel_nombre
      order by
            count(*) DESc

            DROP TABLE #trimestre

END
GO

-- Hoteles con mayor cantidad de consumibles facturados
CREATE PROCEDURE DENVER.listado2
      @anio smallint,
      @trimestre smallint
AS
BEGIN
      --DECLARE @meses varchar(50);
      CREATE TABLE #trimestre
    ( mes int)

      if (@trimestre = 1)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (1), (2), (3);
     END
      if (@trimestre = 2)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (4), (5) , (6);
     END
            if (@trimestre = 3)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (7), (8), (9);
     END
            if (@trimestre = 4)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (10), (11), (12);
     END

select top 5 c.hotel_nombre as Hotel, count(*) as "Total Consumibles Facturados"
 from DENVER.consumibles_clientes a JOIN DENVER.reservas b
 ON a.consumible_cliente_reserva_codigo =  b.reserva_codigo
 JOIN DENVER.hoteles c ON c.hotel_id = b.reserva_hotel_id
   WHERE b.reserva_estado_id IN (1,2,6)
        AND MONTH(b.reserva_fecha_inicio) IN (SELECT mes FROM #trimestre) AND year(b.reserva_fecha_inicio) = @anio
      --    AND MONTH(b.reserva_fecha_fin) IN (SELECT mes FROM #trimestre) AND year (b.reserva_fecha_fin) = @anio
      group by
            c.hotel_nombre
      order by
            count(*) DESc 

            DROP TABLE #trimestre
END
GO

-- Hoteles con mayor cantidad de días fuera de servicio
CREATE PROCEDURE DENVER.listado3
      @anio int,
      @trimestre int
AS
BEGIN
      CREATE TABLE #trimestre
    ( mes int)

      if (@trimestre = 1)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (1), (2), (3);
     END
      if (@trimestre = 2)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (4), (5) , (6);
     END
            if (@trimestre = 3)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (7), (8), (9);
     END
            if (@trimestre = 4)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (10), (11), (12);
     END

select top 5 a.hotel_nombre as Hotel, sum(DateDIFF(dd, mantenimiento_fecha_hasta, mantenimiento_fecha_desde)) as "Dias Fuera de Servicio"
 from DENVER.hoteles a JOIN DENVER.mantenimientos b ON a.hotel_id = b.mantenimiento_hotel_id
   WHERE MONTH(b.mantenimiento_fecha_desde) IN (SELECT mes FROM #trimestre) AND year(b.mantenimiento_fecha_desde) = @anio
            AND MONTH(b.mantenimiento_fecha_hasta) IN (SELECT mes FROM #trimestre) AND year (b.mantenimiento_fecha_hasta) = @anio
      group by
            hotel_nombre
      order by
            count(*) DESc 

            DROP TABLE #trimestre
END
GO

-- Habitaciones con mayor cantidad de días y veces que fueron ocupados
CREATE PROCEDURE DENVER.listado4
      @anio int,
      @trimestre int
AS
BEGIN
      CREATE TABLE #trimestre
    ( mes int)

      if (@trimestre = 1)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (1), (2), (3);
     END
      if (@trimestre = 2)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (4), (5) , (6);
     END
            if (@trimestre = 3)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (7), (8), (9);
     END
            if (@trimestre = 4)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (10), (11), (12);
     END

      select b.reserva_habitacion_nro as [Numero de habitacion], SUM(a.reserva_cant_noches) AS [Dias Ocupados],
             COUNT(*) AS [Cantidad de veces ocupada] , hotel_nombre AS [Hotel de pertenencia]
      from DENVER.reservas a JOIN DENVER.reservas_habitaciones b ON a.reserva_codigo = b.reserva_habitaciones_reserva_codigo  
            join DENVER.hoteles as c on a.reserva_hotel_id = c.hotel_id
      where MONTH(a.reserva_fecha_inicio) IN (SELECT mes FROM #trimestre) AND year(a.reserva_fecha_inicio) = @anio
      --      AND MONTH(a.reserva_fecha_fin) IN (SELECT mes FROM #trimestre) AND year (a.reserva_fecha_fin) = @anio
      --      AND a.reserva_estado_id IN (6)
      group by
            reserva_habitacion_nro, hotel_nombre
      order by
            SUM(a.reserva_cant_noches),COUNT(*) DESc

            DROP TABLE #trimestre
END
GO

-- Cliente con mayor cantidad de puntos
CREATE PROCEDURE DENVER.listado5
      @anio int,
      @trimestre int
AS
BEGIN
      CREATE TABLE #trimestre
    ( mes int)

      if (@trimestre = 1)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (1), (2), (3);
     END
      if (@trimestre = 2)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (4), (5) , (6);
     END
            if (@trimestre = 3)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (7), (8), (9);
     END
            if (@trimestre = 4)
      BEGIN
         INSERT INTO #trimestre(mes) VALUES (10), (11), (12);
     END

      select cliente_apellido AS Apellido, cliente_nombre AS Nombre, 
             SUM( (a.reserva_cant_noches*d.reserva_habitaciones_precio)/20 + (c.factura_item_monto * c.factura_item_cant)/10 ) 
      from DENVER.reservas a JOIN DENVER.clientes b ON a.reserva_cliente_pasaporte_nro = b.cliente_pasaporte_nro
                                                   AND a.reserva_cliente_tipo_documento_id = b.cliente_tipo_documento_id
         JOIN DENVER.facturas_items c ON  a.reserva_codigo = c.factura_reserva_codigo
             JOIN DENVER.reservas_habitaciones d ON a.reserva_codigo = d.reserva_habitaciones_reserva_codigo
      where MONTH(a.reserva_fecha_inicio) IN (SELECT mes FROM #trimestre) AND year(a.reserva_fecha_inicio) = @anio
            AND MONTH(a.reserva_fecha_fin) IN (SELECT mes FROM #trimestre) AND year (a.reserva_fecha_fin) = @anio
          AND a.reserva_estado_id IN (6)
      group by
            cliente_apellido, cliente_nombre
      order by
            SUM( (a.reserva_cant_noches*d.reserva_habitaciones_precio)/20 + (c.factura_item_monto * c.factura_item_cant)/10 ) DESc
            DROP TABLE #trimestre
END
GO

CREATE PROCEDURE DENVER.ocupar_disponibilidad
      @fecha_ocupacion datetime,
      @hotel_id smallint,      
      @tipo_habitacion as numeric(18,0),
      @habitacion_nro numeric(18,0)

AS
BEGIN
      UPDATE 
            DENVER.disponibilidades
      SET 
            disponibilidad_ocupado = 1
      where
            disponibilidad_hotel_id = @hotel_id and
            disponibilidad_habitacion_nro = @habitacion_nro and
            disponibilidad_tipo_habitacion_id = @tipo_habitacion and
            disponibilidad_fecha = @fecha_ocupacion
END
GO

CREATE PROCEDURE DENVER.liberar_disponibilidad
      @fecha_ocupacion datetime,
      @hotel_id smallint,
      @tipo_habitacion as numeric(18,0),
      @habitacion_nro numeric(18,0)
AS
BEGIN
      UPDATE 
            DENVER.disponibilidades
      SET 
            disponibilidad_ocupado = 0
      where
            disponibilidad_hotel_id = @hotel_id and
            disponibilidad_habitacion_nro = @habitacion_nro and
            disponibilidad_tipo_habitacion_id = @tipo_habitacion and
            disponibilidad_fecha = @fecha_ocupacion
END
GO

CREATE PROCEDURE DENVER.obtener_consumos
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
            DENVER.reservas as r
            join reservas_habitaciones as rh on rh.reserva_habitaciones_reserva_codigo = r.reserva_codigo
      where
            rh.reserva_habitacion_nro = @habitacion_nro and r.reserva_hotel_id = @hotel_id AND r.reserva_estado_id = 6;


      select
            convert(varchar(50),cc.consumible_cliente_fecha_consumo,103) as "Fecha Consumo", c.consumible_descripcion as "Consumo", c.consumible_id
      from
            DENVER.consumibles_clientes as cc
            join DENVER.consumibles as c on cc.consumible_cliente_consumible_id = c.consumible_id
      where
            cc.consumible_cliente_tipo_documento_id = @cliente_tipo_doc AND cc.consumible_cliente_pasaporte_nro = @cliente_nro_doc and cc.consumible_cliente_reserva_codigo = @nro_reserva
      order by
            cc.consumible_cliente_fecha_consumo, c.consumible_descripcion

END
GO

CREATE PROCEDURE DENVER.registrar_consumos
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
            DENVER.reservas as r
            join reservas_habitaciones as rh on rh.reserva_habitaciones_reserva_codigo = r.reserva_codigo
      where
            rh.reserva_habitacion_nro = @habitacion_nro and r.reserva_hotel_id = @hotel_id AND r.reserva_estado_id = 6;


      insert into DENVER.consumibles_clientes (consumible_cliente_consumible_id,consumible_cliente_tipo_documento_id,consumible_cliente_pasaporte_nro,consumible_cliente_fecha_consumo,consumible_cliente_reserva_codigo) values (@consumible_id,@cliente_tipo_doc,@cliente_nro_doc, @fecha_consumo, @nro_reserva)
END
GO

CREATE PROCEDURE [DENVER].[crear_rol]    
      @rol nvarchar(255),
      @fecha_sistema datetime
AS   
BEGIN 
      
      SET NOCOUNT ON;  
      INSERT INTO [DENVER].[roles](
          rol_nombre,
            rol_activo,
            rol_created
            )
            values(
            @rol,
            'S',
            @fecha_sistema)

      

END
GO

CREATE PROCEDURE [DENVER].[modificar_rol]    
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

CREATE PROCEDURE [DENVER].[crear_rol_funcionalidad]    
      @rol_nombre nvarchar(255),
      @rol_funcionalidad smallint
AS   
BEGIN 
      
      SET NOCOUNT ON;  
      INSERT INTO [DENVER].[roles_funcionalidades](
          rol_funcionalidad_rol_nombre,
            rol_funcionalidad_funcionalidad_id
            )
            values(
            @rol_nombre,
            @rol_funcionalidad
            )
END
GO

CREATE PROCEDURE [DENVER].[funcionalidades_rol]    
      @usuario_rol nvarchar(255)
AS   
BEGIN 
      
      SET NOCOUNT ON;  

    SELECT rol_funcionalidad_funcionalidad_id AS Permiso
        FROM roles_funcionalidades
         WHERE rol_funcionalidad_rol_nombre = @usuario_rol
END
GO

CREATE FUNCTION DENVER.existe_rol (@rol nvarchar(50))
RETURNS int
AS
BEGIN
      RETURN (SELECT count(*) FROM DENVER.roles WHERE rol_nombre = @rol)

END
GO

CREATE PROCEDURE DENVER.obtener_funcionalidades
AS
BEGIN
      SET NOCOUNT ON;
      SELECT funcionalidad_nombre 
        FROM DENVER.funcionalidades
END
GO

CREATE PROCEDURE [DENVER].[buscar_funcionalidades_rol]
@rol_nombre nvarchar(255)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT rol_funcionalidad_funcionalidad_id
        FROM DENVER.roles_funcionalidades
            WHERE rol_funcionalidad_rol_nombre = @rol_nombre

END
GO

CREATE PROCEDURE [DENVER].[eliminar_rol_completo]
      @rol nvarchar(255),
      @rol_nuevo nvarchar(255)
AS
BEGIN
      SET NOCOUNT ON;  
      
    DELETE FROM DENVER.roles_funcionalidades WHERE rol_funcionalidad_rol_nombre = @rol;

      UPDATE DENVER.usuarios_roles
       SET usuario_rol_rol_nombre = @rol_nuevo
        WHERE usuario_rol_rol_nombre = @rol ;

      DELETE FROM DENVER.roles WHERE rol_nombre = @rol 


END
GO

CREATE PROCEDURE [DENVER].[cargar_tabla_roles]
AS
BEGIN
      SET NOCOUNT ON;
      SELECT rol_nombre AS Roles, CASE WHEN rol_activo = 'S' THEN 'ACTIVO' ELSE 'INACTIVO' END AS Estado  
        FROM DENVER.roles

END
GO

CREATE PROCEDURE [DENVER].[buscar_usuario]    
      @usuario_nombre nvarchar(255) = NULL ,
      @usuario_apellido nvarchar(255) = NULL,
      @hotel int = NULL 
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  

      SELECT a.usuario_user AS Usuario, a.usuario_nombre AS Nombre, a.usuario_apellido AS Apellido, td.tipo_documento_nombre AS 'Tipo DNI',
      a.usuario_nro_documento AS DNI , a.usuario_email AS Mail, a.usuario_telefono AS Tel, a.usuario_tipo_documento_id
            FROM 
            DENVER.usuarios AS a
            JOIN DENVER.usuarios_hoteles AS b ON a.usuario_user = b.usuario_usuario_user  
            LEFT JOIN DENVER.tipo_documentos as td ON td.tipo_documento_id = a.usuario_tipo_documento_id
      WHERE  a.usuario_nombre LIKE '%' + ISNULL(@usuario_nombre, usuario_nombre) + '%'
            AND a.usuario_apellido LIKE '%' + ISNULL(@usuario_apellido, usuario_apellido) + '%'
            AND b.usuario_hotel_id = ISNULL(@hotel, usuario_hotel_id) AND usuario_activo = 'S' AND a.usuario_user NOT IN ('GUEST','MIGRATION')
END
GO

CREATE PROCEDURE [DENVER].[modificar_usuario] 
      @usuario_user nvarchar(50) = NULL,
      --@usuario_pass varchar(50) = NULL,
      @usuario_apellido nvarchar(255) = NULL,
      @usuario_nombre nvarchar(255) = NULL,
      @usuario_tipo_documento_id smallint = NULL,
      @usuario_nro_documento nvarchar(255) = NULL,      
      @usuario_fecha_nac datetime = NULL,
      @usuario_email nvarchar(255) = NULL,
      @usuario_direccion nvarchar(255) = NULL,
      @usuario_telefono nvarchar(255) = NULL,
      @usuario_rol nvarchar(255) = NULL,
      @fecha_sistema datetime
AS   
BEGIN 
      SET NOCOUNT ON;  

      UPDATE 
            [DENVER].[usuarios]
      SET
        --    usuario_pass = HASHBYTES('SHA2_256',UPPER(@usuario_pass)),
            usuario_nombre = @usuario_nombre,
            usuario_apellido = @usuario_apellido,
            usuario_tipo_documento_id = @usuario_tipo_documento_id,
            usuario_nro_documento = @usuario_nro_documento,
            usuario_email = @usuario_email,
            usuario_telefono = @usuario_telefono,
            usuario_direccion = @usuario_direccion,
            usuario_fecha_nac = @usuario_fecha_nac
      WHERE
            usuario_user = @usuario_user;


      UPDATE 
            [DENVER].[usuarios_roles]
      SET
            usuario_rol_rol_nombre = @usuario_rol,
            usuario_rol_created = @fecha_sistema
      WHERE
            usuario_rol_usuario_user = @usuario_user;

END
GO

CREATE PROCEDURE [DENVER].[buscar_usuario_completo]    
      @usuario_user nvarchar(50)
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  

      SELECT
            a.*,  b.usuario_rol_rol_nombre
      FROM 
            DENVER.usuarios AS a 
            JOIN DENVER.usuarios_roles b ON a.usuario_user = b.usuario_rol_usuario_user
      WHERE 
            a.usuario_user = @usuario_user
END
GO

CREATE PROCEDURE DENVER.loguin
      @usuario_user nvarchar(50),
      @usuario_pass varchar(50),
      @hotel_id smallint
AS   
BEGIN 

      SELECT count(*), usuario_apellido, usuario_nombre, usuario_user, usuario_login_fallidos, DENVER.cant_roles_usuario(usuario_user), usuario_rol_rol_nombre AS rol 
      FROM 
            DENVER.usuarios AS u 
            JOIN DENVER.usuarios_hoteles AS uh ON u.usuario_user = uh.usuario_usuario_user 
            JOIN DENVER.usuarios_roles AS r ON u.usuario_user = r.usuario_rol_usuario_user 
      WHERE 
            u.usuario_user = UPPER(@usuario_user) AND 
            u.usuario_pass = HASHBYTES('SHA2_256',UPPER(@usuario_pass)) AND 
            uh.usuario_hotel_id = @hotel_id AND 
            u.usuario_activo = 'S' 
      GROUP BY 
            usuario_apellido, usuario_nombre, usuario_user, usuario_login_fallidos, usuario_rol_rol_nombre;
END
GO

CREATE PROCEDURE [DENVER].[buscar_hotel_completo]    
      @hotel_id smallint

AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  

      SELECT hotel_nombre , hotel_calle, hotel_nro_calle, hotel_ciudad, hotel_pais_id,
               hotel_email, hotel_telefono , hotel_estrellas, hotel_regimen_regimen_id
      FROM 
            DENVER.hoteles
            join DENVER.hoteles_regimenes p on hotel_id = p.hotel_regimen_hotel_id
       WHERE hotel_id = @hotel_id   

END
GO

CREATE PROCEDURE [DENVER].[modificar_hotel]
      @hotel_id smallint,
      @hotel_nombre nvarchar(255),
      @hotel_mail nvarchar(255),
      @hotel_telefono nvarchar(255),
      @hotel_direccion nvarchar(255),
	  @hotel_numero numeric(18,0) = NULL,
      @hotel_estrellas smallint,
      @hotel_ciudad nvarchar(255),
      @hotel_pais smallint,
      @hotel_regimenes smallint,
      @hotel_creacion datetime

AS
BEGIN
      SET NOCOUNT ON;  

      UPDATE [DENVER].[hoteles]
      SET
      hotel_nombre = @hotel_nombre,
      hotel_email = @hotel_mail,
      hotel_telefono = @hotel_telefono,
      hotel_calle = @hotel_direccion,
      hotel_estrellas = @hotel_estrellas,
      hotel_ciudad = @hotel_ciudad,
      hotel_pais_id = @hotel_pais,
      hotel_created = @hotel_creacion
      
      WHERE
      hotel_id = @hotel_id 
 
      UPDATE [DENVER].[hoteles_regimenes]
      SET
      hotel_regimen_regimen_id = @hotel_regimenes
      WHERE hotel_regimen_hotel_id = @hotel_id

END
GO

CREATE PROCEDURE DENVER.obtener_facturable
      @fecha_salida datetime,
      @tipo_documento numeric(18,0),
      @nro_documento numeric(18,0),
      @hotel_id smallint,
      @total_factura numeric(18,0) OUTPUT
AS
BEGIN
      declare @nro_reserva numeric(18,0);
      declare @total_consumo numeric(18,0) = 0; 
      declare @total_estadia numeric(18,0) = 0; 

      -- obtengo nro_reserva
      select
            @nro_reserva = isnull(r.reserva_codigo,0)
      from
            DENVER.reservas as r
      where
            r.reserva_cliente_tipo_documento_id = @tipo_documento and r.reserva_cliente_pasaporte_nro = @nro_documento and r.reserva_hotel_id = @hotel_id and @fecha_salida between r.reserva_fecha_inicio and r.reserva_fecha_fin AND r.reserva_estado_id = 6;

      -- detalle de consumibles
      select
            c.consumible_id, c.consumible_descripcion as "Descripcion", c.consumible_precio as "Precio"
      from
            DENVER.consumibles_clientes as cc
            join DENVER.consumibles as c on cc.consumible_cliente_consumible_id = c.consumible_id
      where
            cc.consumible_cliente_reserva_codigo = @nro_reserva

      union all

      -- detalle del hospedaje
      SELECT
            9999, 'Estadia desde el '+convert(varchar(50),rh.reserva_habitaciones_fecha_inicio,103)+' hasta '+convert(varchar(50),rh.reserva_habitaciones_fecha_fin,103)+' en '+th.tipo_habitacion_descripcion+' y '+reg.regimen_descripcion as "Descripcion", rh.reserva_habitaciones_precio * DENVER.cant_pasajeros_tipo_habitacion(th.tipo_habitacion_id) as "Precio"
      FROM
            DENVER.reservas as r
            join DENVER.reservas_habitaciones as rh ON r.reserva_codigo = rh.reserva_habitaciones_reserva_codigo
            join DENVER.tipo_habitaciones as th on rh.reserva_habitaciones_tipo_habitacion_id = th.tipo_habitacion_id
            join DENVER.regimenes as reg on reg.regimen_id = rh.reserva_habitaciones_regimen_id
      WHERE
            r.reserva_codigo = @nro_reserva;


      -- Calculo el total de consumos
      select
            @total_consumo = isnull(sum(c.consumible_precio),0)
      from
            DENVER.consumibles_clientes as cc
            join DENVER.consumibles as c on cc.consumible_cliente_consumible_id = c.consumible_id
      where
            cc.consumible_cliente_reserva_codigo = @nro_reserva

      -- Calculo el total de la estadia
      SELECT
            @total_estadia = isnull(sum(rh.reserva_habitaciones_precio * DENVER.cant_pasajeros_tipo_habitacion(th.tipo_habitacion_id)),0)
      FROM
            DENVER.reservas as r
            join DENVER.reservas_habitaciones as rh ON r.reserva_codigo = rh.reserva_habitaciones_reserva_codigo
            join DENVER.tipo_habitaciones as th on rh.reserva_habitaciones_tipo_habitacion_id = th.tipo_habitacion_id
            join DENVER.regimenes as reg on reg.regimen_id = rh.reserva_habitaciones_regimen_id
      WHERE
            r.reserva_codigo = @nro_reserva;

      -- Calculo el total a facturar
      SET @total_factura = @total_estadia + @total_consumo;

END
GO

CREATE FUNCTION DENVER.hotel_en_mantenimiento (@hotel_id smallint)
RETURNS int
AS
BEGIN
      RETURN (SELECT count(*) FROM DENVER.hoteles WHERE hotel_id = @hotel_id
                                                                          AND hotel_activo = 'N' )

END
GO

CREATE PROCEDURE DENVER.buscar_habitacion
      @hotel_nombre smallint = NULL ,
      @hab_numero numeric(18,0) = NULL,
      @hab_piso numeric(18,0) = NULL
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  
       
       SELECT habitacion_nro AS Numero, habitacion_piso AS Piso, CASE WHEN habitacion_frente = 'S' THEN 'SI' ELSE 'NO' END AS 'Con Vista',
            hotel_nombre AS Hotel, tipo_habitacion_descripcion AS Descripcion, hotel_id , habitacion_activa
            FROM 
            DENVER.habitaciones h JOIN DENVER.tipo_habitaciones t ON h.habitacion_tipo_habitacion_id = t.tipo_habitacion_id
            JOIN DENVER.hoteles o ON h.habitacion_hotel_id = o.hotel_id       
          
            WHERE --hotel_nombre LIKE '%' + ISNULL(@hotel_nombre, hotel_nombre) + '%'
                  habitacion_hotel_id = ISNULL(@hotel_nombre, habitacion_hotel_id) 
            AND habitacion_nro = ISNULL(@hab_numero, habitacion_nro) 
            AND habitacion_piso = ISNULL(@hab_piso, habitacion_piso) ;
END         
GO

CREATE PROCEDURE DENVER.buscar_habitacion_completa
      @hotel_id smallint = NULL ,
      @hab_nro numeric(18,0) = NULL
      
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  
       
       SELECT * FROM DENVER.habitaciones 
        WHERE habitacion_nro = @hab_nro
         AND  habitacion_hotel_id = @hotel_id
END         
GO

CREATE PROCEDURE [DENVER].[modificar_habitacion]
      @habitacion_nro numeric(18,0),
      @habitacion_piso numeric(18,0),
      @habitacion_frente nvarchar(50),
      @habitacion_hotel_id smallint,
      @habitacion_descripcion ntext
   --   @fecha_sistema datetime
AS
BEGIN
      SET NOCOUNT ON;  
	  UPDATE denver.habitaciones SET
	  habitacion_piso = @habitacion_piso,
	  habitacion_frente = @habitacion_frente,
	  habitacion_descripcion = @habitacion_descripcion
	  WHERE 
	  habitacion_nro = @habitacion_nro AND
	  @habitacion_hotel_id = @habitacion_hotel_id


     
END
GO

CREATE PROCEDURE DENVER.buscar_reserva_hab_hotel
      @habitacion_nro numeric(18,0),
      @hotel_id smallint
      
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  
       
       SELECT * FROM DENVER.reservas_habitaciones h
                  join DENVER.reservas r on  h.reserva_habitaciones_reserva_codigo = r.reserva_codigo
                   
            WHERE (reserva_estado_id = 1 or reserva_estado_id = 2)
              AND reserva_habitacion_nro = @habitacion_nro
              AND reserva_hotel_id = @hotel_id 

END         
GO

CREATE PROCEDURE DENVER.existe_habitacion_hotel
      @habitacion_nro numeric(18,0),
      @hotel_id smallint
      
AS   
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  
       
       SELECT * FROM DENVER.habitaciones 
            WHERE habitacion_nro = @habitacion_nro
              AND habitacion_hotel_id = @hotel_id 

END         
GO

CREATE PROCEDURE DENVER.cargar_usuario_hotel
      @usuario_nombre nvarchar(50),
      @usuario_hotel smallint
      
AS   
BEGIN 

             INSERT INTO [DENVER].[usuarios_hoteles](
                 usuario_usuario_user,
                   usuario_hotel_id
                   
                   )
                   VALUES (
                   @usuario_nombre,
                   @usuario_hotel)


END
GO

CREATE PROCEDURE [DENVER].[buscar_regimen]    
      @nombre_regimen nvarchar(255) = NULL ,
      @estado nvarchar = NULL
      
AS     
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  
      
      SELECT  regimen_descripcion AS Nombre, regimen_precio AS 'Precio U$S',
                  CASE  WHEN regimen_activo = 'S' THEN 'ACTIVO' ELSE 'INACTIVO' END AS Estado 
      FROM 
            DENVER.regimenes
        WHERE regimen_descripcion LIKE '%' + ISNULL(@nombre_regimen, regimen_descripcion) + '%'
            AND regimen_activo = ISNULL(@estado, regimen_activo);
END
GO

CREATE PROCEDURE [DENVER].[alta_regimen]    
      @nombre_regimen nvarchar(255) ,
      @estado nvarchar,
      @precio decimal(18,2),
      @fecha_sistema datetime
      
AS     
BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
      SET NOCOUNT ON;  
      
      INSERT INTO DENVER.regimenes(
      regimen_descripcion,
      regimen_precio,
      regimen_activo,
      regimen_created)
      Values (
      @nombre_regimen,
      @precio,
      @estado,
      @fecha_sistema)


      
END
GO

CREATE PROCEDURE [DENVER].[buscar_reserva]    
      @reserva numeric(18,0)      
AS     
BEGIN 
      -- SET NOCOUNT ON added to prevent extra resultets from interfering with SELECT statements.
	SET NOCOUNT ON;  
	
	SELECT  reserva_codigo AS 'Cod Reserva', hotel_nombre AS Hotel
	FROM 
		denver.reservas a join denver.hoteles b on a.reserva_hotel_id = b.hotel_id 
	  WHERE reserva_codigo = @reserva
	    --and reserva_cliente_tipo_documento_id = @cliente_tipo_doc
		and reserva_estado_id NOT IN (3,4)
END
GO

CREATE PROCEDURE [DENVER].[cancelar_reserva]
      @cod_reserva numeric(18,0),
      @motivo ntext,
      @user nvarchar(50),
      @estado smallint,
      @fecha_sistema datetime
AS
BEGIN
      SET NOCOUNT ON;  

	  DECLARE @hotel_id smallint, @habitacion numeric(18,0), @tipo_hab numeric(18,0),
			  @fecha_inicio datetime, @fecha_fin datetime;
				
      UPDATE [denver].[reservas]
            SET reserva_estado_id = @estado,
                reserva_motivo_cancelacion = @motivo,
                  reserva_fecha_cancelacion = @fecha_sistema,
                  reserva_usuario_user_cancelacion = @user
      WHERE
            reserva_codigo = @cod_reserva;

      SELECT @hotel_id = a.reserva_hotel_id, @habitacion = b.reserva_habitacion_nro,
	         @tipo_hab = b.reserva_habitaciones_tipo_habitacion_id, @fecha_inicio = a.reserva_fecha_inicio,
			 @fecha_fin = a.reserva_fecha_fin
	   FROM denver.reservas a JOIN denver.reservas_habitaciones b
	   ON a.reserva_codigo = b.reserva_habitaciones_reserva_codigo
	   WHERE reserva_codigo = @cod_reserva;

	  UPDATE 
            denver.disponibilidades
      SET 
            disponibilidad_ocupado = 0
      where
            disponibilidad_hotel_id = @hotel_id and
            disponibilidad_habitacion_nro = @habitacion and
            disponibilidad_tipo_habitacion_id = @tipo_hab and
            disponibilidad_fecha BETWEEN @fecha_inicio AND @fecha_fin

	    
END
GO

CREATE FUNCTION [DENVER].[existe_reserva] (@reserva numeric(18,0))
RETURNS int
AS
BEGIN
      RETURN (SELECT count(*) FROM denver.reservas WHERE reserva_codigo = @reserva
													 AND reserva_estado_id IN (1,2))

END
GO

CREATE PROCEDURE [DENVER].[facturar_encabezado]
      @fecha_egreso datetime,
      @factura_total numeric(18,2),
      @factura_forma_pago_id smallint,
      @factura_detalle_pago nvarchar(150),
      @factura_cliente_tipo_documento smallint,
      @factura_pasaporte_nro numeric(18,0),
      @fecha_sistema datetime,
      @factura_hotel_id smallint,
      @factura_nro numeric(18,0)  OUTPUT,
      @nro_reserva numeric(18,0) OUTPUT
AS
BEGIN
      SET NOCOUNT ON;  

      declare @next_factura_nro numeric(18,0) = (SELECT TOP 1 factura_nro FROM DENVER.facturas ORDER BY factura_nro DESC)+1

      insert into DENVER.facturas (factura_nro,factura_fecha,factura_total,factura_forma_pago_id,factura_cliente_tipo_documento,factura_pasaporte_nro,factura_hotel_id,factura_created, factura_detalle_pago) values (@next_factura_nro,@fecha_sistema,@factura_total,@factura_forma_pago_id,@factura_cliente_tipo_documento,@factura_pasaporte_nro,@factura_hotel_id,@fecha_sistema,@factura_detalle_pago)

      SELECT @factura_nro = @next_factura_nro

      SELECT @nro_reserva = (SELECT TOP 1 reserva_codigo FROM [DENVER].[reservas] WHERE reserva_cliente_tipo_documento_id = @factura_cliente_tipo_documento AND reserva_cliente_pasaporte_nro = @factura_pasaporte_nro AND reserva_hotel_id = @factura_hotel_id AND 
            reserva_estado_id = 6 AND @fecha_egreso BETWEEN reserva_fecha_inicio AND reserva_fecha_fin)

END
GO

CREATE PROCEDURE [DENVER].[facturar_items]
      @factura_nro numeric(18,0),
      @factura_item_cant numeric(18,0),
      @factura_item_monto numeric(18,2),
      @factura_item_descripcion nvarchar(255),
      @factura_cliente_tipo_documento smallint,
      @factura_pasaporte_nro numeric(18,0),
      @factura_hotel_id smallint,
      @fecha_sistema datetime,
      @fecha_facturacion datetime,
      @factura_consumible_id numeric(18,0)
AS
BEGIN
      SET NOCOUNT ON;

      -- Busco el Nro de Reserva Original
      declare @nro_reserva numeric(18,0) = (SELECT TOP 1 reserva_codigo FROM [DENVER].[reservas] WHERE reserva_cliente_tipo_documento_id = @factura_cliente_tipo_documento AND reserva_cliente_pasaporte_nro = @factura_pasaporte_nro AND reserva_hotel_id = @factura_hotel_id AND 
            reserva_estado_id = 6 AND @fecha_facturacion BETWEEN reserva_fecha_inicio AND reserva_fecha_fin)
      
      insert into DENVER.facturas_items (factura_item_nro,factura_item_cant,factura_item_monto,factura_item_descripcion,factura_consumible_id,factura_reserva_codigo) values (@factura_nro,@factura_item_cant,@factura_item_monto,@factura_item_descripcion,@factura_consumible_id,@nro_reserva)

END
GO

CREATE PROCEDURE [DENVER].[habilitar_usuario] 
      @usuario_user nvarchar(50) = NULL
AS
BEGIN
      SET NOCOUNT ON;
      UPDATE usuarios SET usuario_activo = 'S' WHERE usuario_user = @usuario_user;
END
GO

CREATE PROCEDURE [DENVER].[cambiar_contrasena]
      @usuario_user nvarchar(50),
	  @pass varchar(50)
AS
BEGIN
      SET NOCOUNT ON;
      UPDATE usuarios SET usuario_pass = HASHBYTES('SHA2_256',UPPER(@pass)) WHERE usuario_user = @usuario_user;
END

GO

CREATE FUNCTION [DENVER].[dias_antes_reserva] (@nro_reserva numeric(18,0), @fecha_sistema datetime)
RETURNS int
AS
BEGIN
      RETURN (SELECT datediff(day,reserva_fecha_inicio,@fecha_sistema) FROM denver.reservas WHERE reserva_codigo = @nro_reserva)

END
GO

CREATE PROCEDURE [DENVER].[modificar_reserva]
      @original_fecha_inicio datetime,
      @original_fecha_fin datetime,
      @original_tipo_habitacion numeric(18,0),
      @original_regimen_id numeric(18,0),
      @original_habitacion_nro numeric(18, 0),
      @nueva_fecha_inicio datetime,
      @nueva_fecha_fin datetime,
      @nueva_tipo_habitacion numeric(18,0),
      @nueva_regimen_id numeric(18,0),      
      @nueva_precio numeric(18, 2),
      @nueva_habitacion_nro numeric(18, 0),
      @reserva_hotel_id smallint,
      @reserva_usuario_user nvarchar(50),
      @fecha_sistema datetime,
      @nro_reserva numeric(18,0)
AS
BEGIN
      SET NOCOUNT ON;

      -- Libero la disponibilidad de las fechas anteriores            
      declare @fecha_actual datetime = @original_fecha_inicio
      while (@fecha_actual <= @original_fecha_fin)
      begin
            exec DENVER.liberar_disponibilidad @fecha_actual, @reserva_hotel_id, @original_tipo_habitacion, @original_habitacion_nro
            set @fecha_actual = dateadd(day, 1, @fecha_actual)
      end

      -- Actualizo la Reserva Anterior (reservas_habitaciones)
      UPDATE 
            DENVER.reservas_habitaciones
      SET
            reserva_habitaciones_fecha_inicio = @nueva_fecha_inicio,
            reserva_habitaciones_fecha_fin = @nueva_fecha_fin,
            reserva_habitaciones_tipo_habitacion_id = @nueva_tipo_habitacion,
            reserva_habitaciones_regimen_id = @nueva_regimen_id,
            reserva_habitacion_nro = @nueva_habitacion_nro,
            reserva_habitaciones_precio = @nueva_precio
      WHERE 
            reserva_habitaciones_reserva_codigo = @nro_reserva AND
            reserva_habitaciones_fecha_inicio = @original_fecha_inicio AND
            reserva_habitaciones_fecha_fin = @original_fecha_fin AND
            reserva_habitaciones_tipo_habitacion_id = @original_tipo_habitacion AND
            reserva_habitaciones_regimen_id = @original_regimen_id AND
            reserva_habitacion_nro = @original_habitacion_nro


      -- Actualizo el rango de fechas de la Reserva (reservas)            
      UPDATE
            DENVER.reservas
      SET
            reserva_fecha_inicio = @nueva_fecha_inicio, 
            reserva_fecha_fin = @nueva_fecha_fin,
            reserva_cant_noches = datediff(day,@nueva_fecha_fin,@nueva_fecha_inicio)
      WHERE 
            reserva_codigo = @nro_reserva

      -- Ocupo la disponibilidad de las fechas nuevas
      declare @fecha_actual2 datetime = @nueva_fecha_inicio
      while (@fecha_actual2 <= @nueva_fecha_fin)
      begin
            exec DENVER.ocupar_disponibilidad @fecha_actual2, @reserva_hotel_id, @nueva_tipo_habitacion, @nueva_habitacion_nro
            set @fecha_actual2 = dateadd(day, 1, @fecha_actual2)
      end

END
GO

CREATE PROCEDURE DENVER.habilitar_disponibilidad 
      @fecha_desde datetime = NULL,
      @fecha_hasta datetime = NULL
AS
BEGIN
      SET NOCOUNT ON;
      declare @fecha_actual datetime = @fecha_desde

      while (@fecha_actual < @fecha_hasta)
      begin


            insert into DENVER.disponibilidades (disponibilidad_hotel_id, disponibilidad_habitacion_nro, disponibilidad_tipo_habitacion_id, disponibilidad_ocupado, disponibilidad_fecha) 
            (
                  SELECT
                        ho.hotel_id, hab.habitacion_nro, th.tipo_habitacion_id, 0, @fecha_actual
                  FROM 
                  DENVER.habitaciones AS hab
                  join DENVER.hoteles as ho on ho.hotel_id = hab.habitacion_hotel_id
                  join DENVER.tipo_habitaciones as th on ho.hotel_id = hab.habitacion_hotel_id
            )
                  set @fecha_actual = dateadd(day, 1, @fecha_actual)
      end
END
GO

CREATE PROCEDURE [DENVER].[actualizar_disponibilidad_migracion]
AS
BEGIN
      SET NOCOUNT ON;
      
      declare cursor_reservas CURSOR for (SELECT  Reserva_Fecha_Inicio, Habitacion_Tipo_Codigo, Habitacion_Numero, (SELECT distinct top 1 t1.hotel_id FROM DENVER.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad)
            FROM         gd_esquema.Maestra
            WHERE
                  Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
                  59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
                  88559381,89094646,90135406,91296720,95744921)
            group by Reserva_Fecha_Inicio, Habitacion_Tipo_Codigo, Habitacion_Numero, Hotel_Calle, Hotel_Ciudad)


      declare @fecha datetime
      declare @hotel_id smallint
      declare @tipo_habitacion numeric(18,0)
      declare @habitacion_nro numeric(18, 0)

      open cursor_reservas
      fetch next from cursor_reservas into @fecha, @tipo_habitacion, @habitacion_nro, @hotel_id

      while (@@FETCH_STATUS = 0)
      BEGIN
            exec DENVER.ocupar_disponibilidad @fecha, @hotel_id, @tipo_habitacion, @habitacion_nro
            fetch next from cursor_reservas into @fecha, @tipo_habitacion, @habitacion_nro, @hotel_id
      end
      close cursor_reservas
      deallocate cursor_reservas   
END
GO

-- Habilito las disponibilidades
exec DENVER.habilitar_disponibilidad '20170101', '20201231'
GO

-- Actualizo las disponibilidades de las Reservas existentes
exec [DENVER].[actualizar_disponibilidad_migracion]
--GO
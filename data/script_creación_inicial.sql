/*  --------------------------------------------------------------------------------
ELIMINACION DE TODOS LAS CONSTRAINT
-------------------------------------------------------------------------------- */
USE [GD1C2018]
GO

ALTER TABLE [dbo].[clientes] DROP CONSTRAINT [FK_clientes_tipo_documentos];
ALTER TABLE [dbo].[clientes] DROP CONSTRAINT [FK_clientes_paises];
ALTER TABLE [dbo].[clientes] DROP CONSTRAINT [DF_clientes_cliente_activo];
ALTER TABLE [dbo].[estadias] DROP CONSTRAINT [FK_estadias_usuarios1];
ALTER TABLE [dbo].[estadias] DROP CONSTRAINT [FK_estadias_reservas];
ALTER TABLE [dbo].[estadias] DROP CONSTRAINT [FK_estadias_hoteles];
ALTER TABLE [dbo].[estadias] DROP CONSTRAINT [FK_estadias_clientes];
ALTER TABLE [dbo].[facturas] DROP CONSTRAINT [FK_facturas_formas_pago];
ALTER TABLE [dbo].[facturas] DROP CONSTRAINT [FK_facturas_clientes];
ALTER TABLE [dbo].[habitaciones] DROP CONSTRAINT [FK_habitaciones_tipo_habitaciones];
ALTER TABLE [dbo].[habitaciones] DROP CONSTRAINT [FK_habitaciones_hoteles];
ALTER TABLE [dbo].[habitaciones] DROP CONSTRAINT [DF_habitaciones_habitacion_activa];
ALTER TABLE [dbo].[hoteles] DROP CONSTRAINT [FK_hoteles_paises];
ALTER TABLE [dbo].[hoteles] DROP CONSTRAINT [DF_hoteles_hotel_activo];
ALTER TABLE [dbo].[hoteles_regimenes] DROP CONSTRAINT [FK_hoteles_regimenes_regimenes];
ALTER TABLE [dbo].[hoteles_regimenes] DROP CONSTRAINT [FK_hoteles_regimenes_hoteles];
ALTER TABLE [dbo].[regimenes] DROP CONSTRAINT [DF_regimenes_regimen_activo];
ALTER TABLE [dbo].[reservas] DROP CONSTRAINT [FK_reservas_usuarios1];
ALTER TABLE [dbo].[reservas] DROP CONSTRAINT [FK_reservas_usuarios];
ALTER TABLE [dbo].[reservas] DROP CONSTRAINT [FK_reservas_hoteles];
ALTER TABLE [dbo].[reservas] DROP CONSTRAINT [FK_reservas_estados];
ALTER TABLE [dbo].[reservas] DROP CONSTRAINT [FK_reservas_clientes];
ALTER TABLE [dbo].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones];
ALTER TABLE [dbo].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_reservas];
ALTER TABLE [dbo].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_regimenes];
ALTER TABLE [dbo].[roles] DROP CONSTRAINT [DF_roles1_rol_activo];
ALTER TABLE [dbo].[roles_funcionalidades] DROP CONSTRAINT [FK_roles_funcionalidades_roles];
ALTER TABLE [dbo].[roles_funcionalidades] DROP CONSTRAINT [FK_roles_funcionalidades_funcionalidades];
ALTER TABLE [dbo].[usuarios] DROP CONSTRAINT [DF_usuarios_usuario_activo];
ALTER TABLE [dbo].[usuarios] DROP CONSTRAINT [DF_usuarios_usuario_login_fallidos];
ALTER TABLE [dbo].[usuarios_hoteles] DROP CONSTRAINT [FK_usuarios_hoteles_usuarios];
ALTER TABLE [dbo].[usuarios_hoteles] DROP CONSTRAINT [FK_usuarios_hoteles_hoteles];
ALTER TABLE [dbo].[usuarios_roles] DROP CONSTRAINT [FK_usuarios_roles_usuarios];
ALTER TABLE [dbo].[usuarios_roles] DROP CONSTRAINT [FK_usuarios_roles_roles];
ALTER TABLE [dbo].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_consumibles];
ALTER TABLE [dbo].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_clientes];
ALTER TABLE [dbo].[facturas_items] DROP CONSTRAINT [FK_facturas_items_reservas];
ALTER TABLE [dbo].[facturas_items] DROP CONSTRAINT [FK_facturas_items_facturas];
ALTER TABLE [dbo].[facturas_items] DROP CONSTRAINT [FK_facturas_items_consumibles];
ALTER TABLE [dbo].[mantenimientos] DROP CONSTRAINT [FK_mantenimientos_hoteles];

/*  --------------------------------------------------------------------------------
ELIMINACION TODAS LAS TABLAS
-------------------------------------------------------------------------------- */

DROP TABLE [dbo].[clientes];
DROP TABLE [dbo].[consumibles];
DROP TABLE [dbo].[consumibles_clientes];
DROP TABLE [dbo].[estadias];
DROP TABLE [dbo].[estados];
DROP TABLE [dbo].[facturas];
DROP TABLE [dbo].[facturas_items];
DROP TABLE [dbo].[formas_pago];
DROP TABLE [dbo].[funcionalidades];
DROP TABLE [dbo].[habitaciones];
DROP TABLE [dbo].[hoteles];
DROP TABLE [dbo].[hoteles_regimenes];
DROP TABLE [dbo].[paises];
DROP TABLE [dbo].[regimenes];
DROP TABLE [dbo].[reservas];
DROP TABLE [dbo].[reservas_habitaciones];
DROP TABLE [dbo].[roles];
DROP TABLE [dbo].[roles_funcionalidades];
DROP TABLE [dbo].[tipo_documentos];
DROP TABLE [dbo].[tipo_habitaciones];
DROP TABLE [dbo].[usuarios];
DROP TABLE [dbo].[usuarios_hoteles];
DROP TABLE [dbo].[usuarios_roles];
DROP TABLE [dbo].[mantenimientos];

/*  --------------------------------------------------------------------------------
CREACION DE TODA LA ESTRUCUTRA NUEVA
-------------------------------------------------------------------------------- */

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[clientes](
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
      [cliente_created] [datetime] NULL,
      [cliente_activo] [char](1) NULL,
      [cliente_pais_id] [smallint] NULL,
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


CREATE TABLE [dbo].[consumibles](
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


CREATE TABLE [dbo].[consumibles_clientes](
      [consumible_cliente_consumible_id] [numeric](18, 0) NULL,
      [consumible_cliente_tipo_documento_id] [smallint] NULL,
      [consumible_cliente_pasaporte_nro] [numeric](18, 0) NULL,
      [consumible_cliente_fecha_consumo] [datetime] NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[estadias](
      [estadia_fecha_inicio] [datetime] NULL,
      [estadia_cant_noches] [numeric](18, 0) NULL,
      [estadia_cliente_tipo_documento_id] [smallint] NULL,
      [estadia_cliente_pasaporte_nro] [numeric](18, 0) NULL,
      [estadia_fecha_fin] [datetime] NULL,
      [estadia_hotel_id] [smallint] NULL,
      [estadia_reserva_codigo] [numeric](18, 0) NULL,
      [estadia_usuario_user] [nvarchar](50) NULL,
      [estadia_created] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[estados](
      [estado_id] [smallint] NOT NULL,
      [estado_nombre] [nvarchar](150) NULL,
 CONSTRAINT [PK_estados] PRIMARY KEY CLUSTERED 
(
      [estado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[facturas](
      [factura_nro] [numeric](18, 0) NOT NULL,
      [factura_fecha] [datetime] NULL,
      [factura_total] [numeric](18, 2) NULL,
      [factura_forma_pago_id] [smallint] NULL,
      [factura_cliente_tipo_documento] [smallint] NULL,
      [factura_pasaporte_nro] [numeric](18, 0) NULL,
      [factura_created] [datetime] NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
      [factura_nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[facturas_items](
      [factura_item_cant] [numeric](18, 0) NULL,
      [factura_item_nro] [numeric](18, 0) NULL,
      [factura_item_monto] [numeric](18, 2) NULL,
      [factura_item_descripcion] [nvarchar](255) NULL,
      [factura_consumible_id] [numeric](18, 0) NULL,
      [factura_reserva_codigo] [numeric](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[formas_pago](
      [forma_pago_id] [smallint] NOT NULL,
      [forma_pago_nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_formas_pago] PRIMARY KEY CLUSTERED 
(
      [forma_pago_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[funcionalidades](
      [funcionalidad_id] [smallint] IDENTITY(1,1) NOT NULL,
      [funcionalidad_nombre] [nvarchar](255) NULL,
      [funcionalidad_created] [datetime] NULL,
 CONSTRAINT [PK_funcionalidades] PRIMARY KEY CLUSTERED 
(
      [funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[habitaciones](
      [habitacion_nro] [numeric](18, 0) NOT NULL,
      [habitacion_piso] [numeric](18, 0) NULL,
      [habitacion_frente] [nvarchar](50) NULL,
      [habitacion_tipo_habitacion_id] [numeric](18, 0) NULL,
      [habitacion_created] [datetime] NULL,
      [habitacion_descripcion] [ntext] NULL,
      [habitacion_hotel_id] [smallint] NOT NULL,
      [habitacion_activa] [char](1) NULL,
 CONSTRAINT [PK_habitaciones] PRIMARY KEY NONCLUSTERED 
(
      [habitacion_nro] ASC,
      [habitacion_hotel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[hoteles](
      [hotel_id] [smallint] IDENTITY(1,1) NOT NULL,
      [hotel_calle] [nvarchar](255) NULL,
      [hotel_nro_calle] [numeric](18, 0) NULL,
      [hotel_ciudad] [nvarchar](255) NULL,
      [hotel_estrellas] [numeric](18, 0) NULL,
      [hotel_recarga_estrella] [numeric](18, 0) NULL,
      [hotel_created] [datetime] NULL,
      [hotel_nombre] [nvarchar](255) NULL,
      [hotel_email] [nvarchar](255) NULL,
      [hotel_telefono] [nvarchar](255) NULL,
      [hotel_pais_id] [smallint] NULL,
      [hotel_activo] [char](1) NULL,
 CONSTRAINT [PK_hoteles] PRIMARY KEY CLUSTERED 
(
      [hotel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[hoteles_regimenes](
      [hotel_regimen_hotel_id] [smallint] NULL,
      [hotel_regimen_regimen_id] [numeric](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[paises](
      [pais_id] [smallint] NOT NULL,
      [pais_nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_paises] PRIMARY KEY CLUSTERED 
(
      [pais_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[regimenes](
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

CREATE TABLE [dbo].[reservas](
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
      [reserva_created] [nchar](10) NULL,      
 CONSTRAINT [PK_reservas] PRIMARY KEY CLUSTERED 
(
      [reserva_codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[reservas_habitaciones](
      [reserva_habitaciones_reserva_codigo] [numeric](18, 0) NULL,
      [reserva_habitaciones_fecha_inicio] [datetime] NULL,
      [reserva_habitaciones_fecha_fin] [datetime] NULL,
      [reserva_habitaciones_tipo_habitacion_id] [numeric](18, 0) NULL,
      [reserva_habitaciones_cant_noches] [numeric](18, 0) NULL,
      [reserva_habitaciones_regimen_id] [numeric](18, 0) NULL,
      [reserva_habitaciones_precio] [numeric](18, 2) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[roles](
      [rol_nombre] [nvarchar](255) NOT NULL,
      [rol_activo] [char](1) NOT NULL,
      [rol_created] [datetime] NULL,
 CONSTRAINT [PK_roles1] PRIMARY KEY CLUSTERED 
(
      [rol_nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[roles_funcionalidades](
      [rol_funcionalidad_rol_nombre] [nvarchar](255) NULL,
      [rol_funcionalidad_funcionalidad_id] [smallint] NULL,
 CONSTRAINT [IX_roles_funcionalidades] UNIQUE NONCLUSTERED 
(
      [rol_funcionalidad_rol_nombre] ASC,
      [rol_funcionalidad_funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[tipo_documentos](
      [tipo_documento_id] [smallint] NOT NULL,
      [tipo_documento_nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_tipo_documentos] PRIMARY KEY CLUSTERED 
(
      [tipo_documento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tipo_habitaciones](
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


CREATE TABLE [dbo].[usuarios](
      [usuario_user] [nvarchar](50) NOT NULL,
      [usuario_pass] [nvarchar](50) NULL,
      [usuario_created] [datetime] NULL,
      [usuario_login_fallidos] [smallint] NOT NULL,
      [usuario_activo] [char](1) NOT NULL,
      [usuario_nombre] [nvarchar](255) NULL,
      [usuario_apellido] [nvarchar](255) NULL,
      [usuario_tipo_documento_id] [smallint] NULL,
      [usuario_nro_documento] [nvarchar](255) NULL,
      [usuario_email] [nvarchar](255) NULL,
      [usuario_telefono] [nvarchar](255) NULL,
      [usuario_direccion] [nvarchar](255) NULL,
      [usuario_fecha_nac] [datetime] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
      [usuario_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[usuarios_hoteles](
      [usuario_hotel_id] [smallint] NULL,
      [usuario_usuario_user] [nvarchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[usuarios_roles](
      [usuario_rol_usuario_user] [nvarchar](50) NOT NULL,
      [usuario_rol_rol_nombre] [nvarchar](255) NOT NULL,
      [usuario_rol_created] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[mantenimientos](
      [mantenimiento_hotel_id] [smallint] NULL,
      [mantenimiento_fecha_desde] [datetime] NULL,
      [mantenimiento_fecha_hasta] [datetime] NULL,
      [mantenimiento_motivo] [nvarchar](255) NULL,
      [mantenimiento_created] [datetime] NULL
) ON [PRIMARY]
GO


SET ANSI_PADDING OFF
GO

/*  --------------------------------------------------------------------------------
CREACION DE LOS CONSTRAINT
-------------------------------------------------------------------------------- */

ALTER TABLE [dbo].[regimenes] ADD  CONSTRAINT [DF_regimenes_regimen_activo]  DEFAULT ('S') FOR [regimen_activo]
GO


ALTER TABLE [dbo].[reservas]  WITH NOCHECK ADD  CONSTRAINT [FK_reservas_clientes] FOREIGN KEY([reserva_cliente_tipo_documento_id], [reserva_cliente_pasaporte_nro])
REFERENCES [dbo].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [dbo].[reservas] NOCHECK CONSTRAINT [FK_reservas_clientes]
GO

ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_estados] FOREIGN KEY([reserva_estado_id])
REFERENCES [dbo].[estados] ([estado_id])
GO

ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_estados]
GO

ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_hoteles] FOREIGN KEY([reserva_hotel_id])
REFERENCES [dbo].[hoteles] ([hotel_id])
GO

ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_hoteles]
GO

ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_usuarios] FOREIGN KEY([reserva_usuario_user])
REFERENCES [dbo].[usuarios] ([usuario_user])
GO

ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_usuarios]
GO

ALTER TABLE [dbo].[reservas]  WITH NOCHECK ADD  CONSTRAINT [FK_reservas_usuarios1] FOREIGN KEY([reserva_usuario_user_cancelacion])
REFERENCES [dbo].[usuarios] ([usuario_user])
GO

ALTER TABLE [dbo].[reservas] NOCHECK CONSTRAINT [FK_reservas_usuarios1]
GO

ALTER TABLE [dbo].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_regimenes] FOREIGN KEY([reserva_habitaciones_regimen_id])
REFERENCES [dbo].[regimenes] ([regimen_id])
GO

ALTER TABLE [dbo].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_regimenes]
GO

ALTER TABLE [dbo].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_reservas] FOREIGN KEY([reserva_habitaciones_reserva_codigo])
REFERENCES [dbo].[reservas] ([reserva_codigo])
GO

ALTER TABLE [dbo].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_reservas]
GO

ALTER TABLE [dbo].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones] FOREIGN KEY([reserva_habitaciones_tipo_habitacion_id])
REFERENCES [dbo].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [dbo].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones]
GO

ALTER TABLE [dbo].[roles] ADD  CONSTRAINT [DF_roles1_rol_activo]  DEFAULT ('S') FOR [rol_activo]
GO


ALTER TABLE [dbo].[roles_funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_roles_funcionalidades_funcionalidades] FOREIGN KEY([rol_funcionalidad_funcionalidad_id])
REFERENCES [dbo].[funcionalidades] ([funcionalidad_id])
GO

ALTER TABLE [dbo].[roles_funcionalidades] CHECK CONSTRAINT [FK_roles_funcionalidades_funcionalidades]
GO

ALTER TABLE [dbo].[roles_funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_roles_funcionalidades_roles] FOREIGN KEY([rol_funcionalidad_rol_nombre])
REFERENCES [dbo].[roles] ([rol_nombre])
GO

ALTER TABLE [dbo].[roles_funcionalidades] CHECK CONSTRAINT [FK_roles_funcionalidades_roles]
GO


ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_usuario_login_fallidos]  DEFAULT ((0)) FOR [usuario_login_fallidos]
GO

ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_usuario_activo]  DEFAULT ('S') FOR [usuario_activo]
GO

ALTER TABLE [dbo].[usuarios_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_hoteles_hoteles] FOREIGN KEY([usuario_hotel_id])
REFERENCES [dbo].[hoteles] ([hotel_id])
GO

ALTER TABLE [dbo].[usuarios_hoteles] CHECK CONSTRAINT [FK_usuarios_hoteles_hoteles]
GO

ALTER TABLE [dbo].[usuarios_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_hoteles_usuarios] FOREIGN KEY([usuario_usuario_user])
REFERENCES [dbo].[usuarios] ([usuario_user])
GO

ALTER TABLE [dbo].[usuarios_hoteles] CHECK CONSTRAINT [FK_usuarios_hoteles_usuarios]
GO

ALTER TABLE [dbo].[usuarios_roles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles_roles] FOREIGN KEY([usuario_rol_rol_nombre])
REFERENCES [dbo].[roles] ([rol_nombre])
GO

ALTER TABLE [dbo].[usuarios_roles] CHECK CONSTRAINT [FK_usuarios_roles_roles]
GO

ALTER TABLE [dbo].[usuarios_roles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles_usuarios] FOREIGN KEY([usuario_rol_usuario_user])
REFERENCES [dbo].[usuarios] ([usuario_user])
GO

ALTER TABLE [dbo].[usuarios_roles] CHECK CONSTRAINT [FK_usuarios_roles_usuarios]
GO

ALTER TABLE [dbo].[mantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_mantenimientos_hoteles] FOREIGN KEY([mantenimiento_hotel_id])
REFERENCES [dbo].[hoteles] ([hotel_id])
GO

ALTER TABLE [dbo].[mantenimientos] CHECK CONSTRAINT [FK_mantenimientos_hoteles]
GO

ALTER TABLE [dbo].[hoteles_regimenes]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_regimenes_hoteles] FOREIGN KEY([hotel_regimen_hotel_id])
REFERENCES [dbo].[hoteles] ([hotel_id])
GO

ALTER TABLE [dbo].[hoteles_regimenes] CHECK CONSTRAINT [FK_hoteles_regimenes_hoteles]
GO

ALTER TABLE [dbo].[hoteles_regimenes]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_regimenes_regimenes] FOREIGN KEY([hotel_regimen_regimen_id])
REFERENCES [dbo].[regimenes] ([regimen_id])
GO

ALTER TABLE [dbo].[hoteles_regimenes] CHECK CONSTRAINT [FK_hoteles_regimenes_regimenes]
GO

ALTER TABLE [dbo].[hoteles] ADD  CONSTRAINT [DF_hoteles_hotel_activo]  DEFAULT ('S') FOR [hotel_activo]
GO

ALTER TABLE [dbo].[hoteles]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_paises] FOREIGN KEY([hotel_pais_id])
REFERENCES [dbo].[paises] ([pais_id])
GO

ALTER TABLE [dbo].[hoteles] CHECK CONSTRAINT [FK_hoteles_paises]
GO

ALTER TABLE [dbo].[habitaciones] ADD  CONSTRAINT [DF_habitaciones_habitacion_activa]  DEFAULT ('S') FOR [habitacion_activa]
GO

ALTER TABLE [dbo].[habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_habitaciones_hoteles] FOREIGN KEY([habitacion_hotel_id])
REFERENCES [dbo].[hoteles] ([hotel_id])
GO

ALTER TABLE [dbo].[habitaciones] CHECK CONSTRAINT [FK_habitaciones_hoteles]
GO

ALTER TABLE [dbo].[habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_habitaciones_tipo_habitaciones] FOREIGN KEY([habitacion_tipo_habitacion_id])
REFERENCES [dbo].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [dbo].[habitaciones] CHECK CONSTRAINT [FK_habitaciones_tipo_habitaciones]
GO

ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF_clientes_cliente_activo]  DEFAULT ('S') FOR [cliente_activo]
GO

ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_paises] FOREIGN KEY([cliente_pais_id])
REFERENCES [dbo].[paises] ([pais_id])
GO

ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_paises]
GO

ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tipo_documentos] FOREIGN KEY([cliente_tipo_documento_id])
REFERENCES [dbo].[tipo_documentos] ([tipo_documento_id])
GO

ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_tipo_documentos]
GO

ALTER TABLE [dbo].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_clientes] FOREIGN KEY([consumible_cliente_tipo_documento_id], [consumible_cliente_pasaporte_nro])
REFERENCES [dbo].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [dbo].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_clientes]
GO

ALTER TABLE [dbo].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_consumibles] FOREIGN KEY([consumible_cliente_consumible_id])
REFERENCES [dbo].[consumibles] ([consumible_id])
GO

ALTER TABLE [dbo].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_consumibles]
GO

ALTER TABLE [dbo].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_clientes] FOREIGN KEY([estadia_cliente_tipo_documento_id], [estadia_cliente_pasaporte_nro])
REFERENCES [dbo].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [dbo].[estadias] CHECK CONSTRAINT [FK_estadias_clientes]
GO

ALTER TABLE [dbo].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_hoteles] FOREIGN KEY([estadia_hotel_id])
REFERENCES [dbo].[hoteles] ([hotel_id])
GO

ALTER TABLE [dbo].[estadias] CHECK CONSTRAINT [FK_estadias_hoteles]
GO

ALTER TABLE [dbo].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_reservas] FOREIGN KEY([estadia_reserva_codigo])
REFERENCES [dbo].[reservas] ([reserva_codigo])
GO

ALTER TABLE [dbo].[estadias] CHECK CONSTRAINT [FK_estadias_reservas]
GO

ALTER TABLE [dbo].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_usuarios1] FOREIGN KEY([estadia_usuario_user])
REFERENCES [dbo].[usuarios] ([usuario_user])
GO

ALTER TABLE [dbo].[estadias] CHECK CONSTRAINT [FK_estadias_usuarios1]
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_clientes] FOREIGN KEY([factura_cliente_tipo_documento], [factura_pasaporte_nro])
REFERENCES [dbo].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [FK_facturas_clientes]
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_formas_pago] FOREIGN KEY([factura_forma_pago_id])
REFERENCES [dbo].[formas_pago] ([forma_pago_id])
GO

ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [FK_facturas_formas_pago]
GO

ALTER TABLE [dbo].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_consumibles] FOREIGN KEY([factura_consumible_id])
REFERENCES [dbo].[consumibles] ([consumible_id])
GO

ALTER TABLE [dbo].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_consumibles]
GO

ALTER TABLE [dbo].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_facturas] FOREIGN KEY([factura_item_nro])
REFERENCES [dbo].[facturas] ([factura_nro])
GO

ALTER TABLE [dbo].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_facturas]
GO

ALTER TABLE [dbo].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_reservas] FOREIGN KEY([factura_reserva_codigo])
REFERENCES [dbo].[reservas] ([reserva_codigo])
GO

ALTER TABLE [dbo].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_reservas]
GO


/****** PAISES  ******/
INSERT INTO paises VALUES (1, 'ARGENTINA');
INSERT INTO paises VALUES (2, 'CHILE');
INSERT INTO paises VALUES (3, 'URUGUAY');
INSERT INTO paises VALUES (4, 'PARAGUAY');
INSERT INTO paises VALUES (5, 'BOLIVIA');
INSERT INTO paises VALUES (6, 'COLOMBIA');
INSERT INTO paises VALUES (7, 'PERÚ');
INSERT INTO paises VALUES (8, 'BRASIL');
INSERT INTO paises VALUES (9, 'ECUADOR');
INSERT INTO paises VALUES (10, 'VENEZUELA');
INSERT INTO paises VALUES (11, 'PANAMÁ');
INSERT INTO paises VALUES (12, 'COSTA RICA');
INSERT INTO paises VALUES (13, 'HONDURAS');
INSERT INTO paises VALUES (14, 'GUATEMALA');
INSERT INTO paises VALUES (15, 'MÉXICO');
INSERT INTO paises VALUES (16, 'CUBA');
INSERT INTO paises VALUES (17, 'NICARAGUA');
INSERT INTO paises VALUES (18, 'EL SALVADOR');
INSERT INTO paises VALUES (19, 'HAITÍ');
INSERT INTO paises VALUES (20, 'REPÚBLICA DOMINICANA');
INSERT INTO paises VALUES (21, 'PUERTO RICO');
INSERT INTO paises VALUES (22, 'ESPAÑA');
GO

/****** FORMAS_PAGO  ******/
INSERT INTO formas_pago VALUES (1, 'EFECTIVO');
INSERT INTO formas_pago VALUES (2, 'TARJETA DE CREDITO');
INSERT INTO formas_pago VALUES (3, 'TARJETA DE DEBITO');
INSERT INTO formas_pago VALUES (4, 'CHEQUE');
GO

/****** ESTADOS  ******/
INSERT INTO estados VALUES (1, 'RESERVA CORRECTA');
INSERT INTO estados VALUES (2, 'RESERVA MODIFICADA');
INSERT INTO estados VALUES (3, 'RESERVA CANCELADA POR RECEPCIÓN');
INSERT INTO estados VALUES (4, 'RESERVA CANCELADA POR CLIENTE');
INSERT INTO estados VALUES (5, 'RESERVA CANCELADA POR NO-SHOW');
INSERT INTO estados VALUES (6, 'RESERVA CON INGRESO (EFECTIVIZADA)');
GO

/****** tipo_documentos  ******/
INSERT INTO tipo_documentos VALUES (1, 'PASAPORTE');
INSERT INTO tipo_documentos VALUES (2, 'DNI');
INSERT INTO tipo_documentos VALUES (3, 'LE');
INSERT INTO tipo_documentos VALUES (4, 'LC');
INSERT INTO tipo_documentos VALUES (5, 'CEDULA POLICIAL');
GO

/****** usuarios  ******/
INSERT INTO usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('GUEST', 'GUEST','GUEST','GUEST');
INSERT INTO usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('MIGRATION', 'MIGRATION','MIGRATION','MIGRATION');
INSERT INTO usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('ADMIN', 'ADMIN','ADMIN','ADMIN');
INSERT INTO usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('RECEPCION', 'RECEPCION','RECEPCION','RECEPCION');
GO


/****** roles  ******/
INSERT INTO roles (rol_nombre, rol_created) VALUES ('ADMINISTRADOR',GETDATE());
INSERT INTO roles (rol_nombre, rol_created) VALUES ('RECEPCIONISTA',GETDATE());
INSERT INTO roles (rol_nombre, rol_created) VALUES ('GUEST',GETDATE());
GO

/****** usuarios_roles  ******/
INSERT INTO usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('ADMIN','ADMINISTRADOR',GETDATE());
INSERT INTO usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('RECEPCION','RECEPCIONISTA',GETDATE());
INSERT INTO usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('GUEST','GUEST',GETDATE());
GO

/****** funcionalidades  ******/
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE ROL', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE USUARIO', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE CLIENTE', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE HOTEL', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE HABITACIÓN', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM RÉGIMEN DE ESTADÍA', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('GENERAR O MODIFICAR UN RESERVA', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('CANCELAR RESERVA', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('REGISTRAR ESTADÍA (CHECK-IN/CHECK-OUT)', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('REGISTRAR CONSUMIBLES', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('FACTURAR ESTADÍA', GETDATE());
INSERT INTO funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('LISTADO ESTADÍSTICO', GETDATE());
GO

/****** CLIENTES ******/
/*
EXISTEN REGISTROS CON PASAPORTES DUPLICADOS Y PERTENECIENTES A PERSONAS DIFERENTES. SE EXCLUYERON. TAMBIEN SE PUSO COMO EMAIL EL NRO DE PASAPORTE 
PARA GARANTIZAR QUE NO HAYA DUPLICADOS. EN OTRO PROCESO SE REEMPLAZARAN ESTOS VALORES POR AL MENOS UN EMAIL VALIDO

*/
INSERT INTO clientes (cliente_pasaporte_nro,cliente_apellido,cliente_nombre,cliente_fecha_nac,cliente_email,cliente_dom_calle,
cliente_dom_nro,cliente_piso,cliente_dpto,cliente_nacionalidad,cliente_tipo_documento_id, cliente_pais_id, cliente_created)  (

SELECT 
      [Cliente_Pasaporte_Nro]
      ,[Cliente_Apellido]
      ,[Cliente_Nombre]
      ,[Cliente_Fecha_Nac]
        ,[Cliente_Pasaporte_Nro]
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
INSERT INTO hoteles 
(hotel_ciudad, hotel_calle, hotel_nro_calle, hotel_estrellas, hotel_recarga_estrella, hotel_pais_id, hotel_created)
( 
SELECT     Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 1, GETDATE()
FROM         gd_esquema.Maestra
GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella
)
GO


/****** usuarios_hoteles  ******/
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'GUEST');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'MIGRATION');
INSERT INTO usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'MIGRATION');
GO

/****** TIPO_HABITACIONES ******/
INSERT INTO tipo_habitaciones (tipo_habitacion_descripcion, tipo_habitacion_porcentual, tipo_habitacion_id, tipo_habitacion_created)
(
SELECT  DISTINCT   Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual, Habitacion_Tipo_Codigo, GETDATE()
FROM         gd_esquema.Maestra

)
GO

/****** HABITACIONES ******/
INSERT INTO habitaciones 
(habitacion_nro, habitacion_piso, habitacion_frente, habitacion_created, habitacion_hotel_id, habitacion_tipo_habitacion_id)
(
SELECT distinct Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, GETDATE(), (SELECT distinct t1.hotel_id FROM hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad), Habitacion_Tipo_Codigo
FROM         gd_esquema.Maestra

)
GO

/****** CONSUMIBLES ******/
INSERT INTO consumibles
(consumible_id, consumible_descripcion, consumible_precio, consumible_created)
(
SELECT     Consumible_Codigo, Consumible_Descripcion, Consumible_Precio, GETDATE()
FROM         gd_esquema.Maestra
WHERE Consumible_Codigo is not null
GROUP BY Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
)
GO

/****** REGIMENES ******/
INSERT INTO regimenes
(regimen_descripcion,regimen_precio,regimen_created)
(
SELECT     Regimen_Descripcion, Regimen_Precio, GETDATE()
FROM         gd_esquema.Maestra
group by Regimen_Descripcion, Regimen_Precio
)
GO


/****** CONSUMIBLES_CLIENTES ******/
INSERT INTO consumibles_clientes
(consumible_cliente_consumible_id, consumible_cliente_pasaporte_nro, consumible_cliente_tipo_documento_id, consumible_cliente_fecha_consumo)
(
SELECT     Consumible_Codigo, Cliente_Pasaporte_Nro, 1, NULL
FROM         gd_esquema.Maestra
WHERE
      Consumible_Codigo IS NOT NULL AND  Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)
GROUP BY
      Consumible_Codigo, Cliente_Pasaporte_Nro
)
GO


/****** HOTELES_REGIMENES ******/
INSERT INTO hoteles_regimenes
(hotel_regimen_hotel_id,hotel_regimen_regimen_id)
(
SELECT DISTINCT    
(SELECT distinct t1.hotel_id FROM hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad),
(SELECT distinct t1.regimen_id FROM regimenes as t1 WHERE t1.regimen_descripcion = gd_esquema.Maestra.Regimen_Descripcion)
 
FROM gd_esquema.Maestra
)
GO


/****** RESERVAS ******/
INSERT INTO reservas
(reserva_fecha_inicio, reserva_fecha_fin,reserva_codigo,reserva_cant_noches, reserva_cliente_tipo_documento_id, reserva_cliente_pasaporte_nro, reserva_hotel_id, reserva_usuario_user, reserva_estado_id)
(
SELECT     Reserva_Fecha_Inicio, (Reserva_Fecha_Inicio+Reserva_Cant_Noches), Reserva_Codigo, Reserva_Cant_Noches, 1, Cliente_Pasaporte_Nro, (SELECT distinct t1.hotel_id FROM hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad), 'MIGRATION',1
FROM         gd_esquema.Maestra
WHERE
      Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)
  GROUP BY
      Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Hotel_Calle, Hotel_Ciudad
)
GO

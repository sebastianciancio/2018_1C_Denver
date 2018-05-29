USE [GD1C2018]
GO

/*  --------------------------------------------------------------------------------
CREACION DEL SCHEMA 
-------------------------------------------------------------------------------- */

if NOT EXISTS (SELECT * FROM sys.schemas  WHERE name = 'denver')
	EXEC('CREATE SCHEMA [denver] AUTHORIZATION [dbo]') 

/*  --------------------------------------------------------------------------------
ELIMINACION DE TODOS LAS CONSTRAINT
-------------------------------------------------------------------------------- */

ALTER TABLE [denver].[clientes] DROP CONSTRAINT [FK_clientes_tipo_documentos];
ALTER TABLE [denver].[clientes] DROP CONSTRAINT [FK_clientes_paises];
ALTER TABLE [denver].[clientes] DROP CONSTRAINT [DF_clientes_cliente_activo];
ALTER TABLE [denver].[estadias] DROP CONSTRAINT [FK_estadias_usuarios1];
ALTER TABLE [denver].[estadias] DROP CONSTRAINT [FK_estadias_reservas];
ALTER TABLE [denver].[estadias] DROP CONSTRAINT [FK_estadias_hoteles];
ALTER TABLE [denver].[estadias] DROP CONSTRAINT [FK_estadias_clientes];
ALTER TABLE [denver].[facturas] DROP CONSTRAINT [FK_facturas_formas_pago];
ALTER TABLE [denver].[facturas] DROP CONSTRAINT [FK_facturas_clientes];
ALTER TABLE [denver].[habitaciones] DROP CONSTRAINT [FK_habitaciones_tipo_habitaciones];
ALTER TABLE [denver].[habitaciones] DROP CONSTRAINT [FK_habitaciones_hoteles];
ALTER TABLE [denver].[habitaciones] DROP CONSTRAINT [DF_habitaciones_habitacion_activa];
ALTER TABLE [denver].[hoteles] DROP CONSTRAINT [FK_hoteles_paises];
ALTER TABLE [denver].[hoteles] DROP CONSTRAINT [DF_hoteles_hotel_activo];
ALTER TABLE [denver].[hoteles_regimenes] DROP CONSTRAINT [FK_hoteles_regimenes_regimenes];
ALTER TABLE [denver].[hoteles_regimenes] DROP CONSTRAINT [FK_hoteles_regimenes_hoteles];
ALTER TABLE [denver].[regimenes] DROP CONSTRAINT [DF_regimenes_regimen_activo];
ALTER TABLE [denver].[reservas] DROP CONSTRAINT [FK_reservas_usuarios1];
ALTER TABLE [denver].[reservas] DROP CONSTRAINT [FK_reservas_usuarios];
ALTER TABLE [denver].[reservas] DROP CONSTRAINT [FK_reservas_hoteles];
ALTER TABLE [denver].[reservas] DROP CONSTRAINT [FK_reservas_estados];
ALTER TABLE [denver].[reservas] DROP CONSTRAINT [FK_reservas_clientes];
ALTER TABLE [denver].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones];
ALTER TABLE [denver].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_reservas];
ALTER TABLE [denver].[reservas_habitaciones] DROP CONSTRAINT [FK_reservas_habitaciones_regimenes];
ALTER TABLE [denver].[roles] DROP CONSTRAINT [DF_roles1_rol_activo];
ALTER TABLE [denver].[roles_funcionalidades] DROP CONSTRAINT [FK_roles_funcionalidades_roles];
ALTER TABLE [denver].[roles_funcionalidades] DROP CONSTRAINT [FK_roles_funcionalidades_funcionalidades];
ALTER TABLE [denver].[usuarios] DROP CONSTRAINT [DF_usuarios_usuario_activo];
ALTER TABLE [denver].[usuarios] DROP CONSTRAINT [DF_usuarios_usuario_login_fallidos];
ALTER TABLE [denver].[usuarios_hoteles] DROP CONSTRAINT [FK_usuarios_hoteles_usuarios];
ALTER TABLE [denver].[usuarios_hoteles] DROP CONSTRAINT [FK_usuarios_hoteles_hoteles];
ALTER TABLE [denver].[usuarios_roles] DROP CONSTRAINT [FK_usuarios_roles_usuarios];
ALTER TABLE [denver].[usuarios_roles] DROP CONSTRAINT [FK_usuarios_roles_roles];
ALTER TABLE [denver].[facturas_items] DROP CONSTRAINT [FK_facturas_items_reservas];
ALTER TABLE [denver].[facturas_items] DROP CONSTRAINT [FK_facturas_items_facturas];
ALTER TABLE [denver].[facturas_items] DROP CONSTRAINT [FK_facturas_items_consumibles];
ALTER TABLE [denver].[mantenimientos] DROP CONSTRAINT [FK_mantenimientos_hoteles];
ALTER TABLE [denver].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_reservas]
ALTER TABLE [denver].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_consumibles]
ALTER TABLE [denver].[consumibles_clientes] DROP CONSTRAINT [FK_consumibles_clientes_clientes]
ALTER TABLE [denver].[disponibilidades] DROP CONSTRAINT [FK_disponibilidades_tipo_habitaciones]
ALTER TABLE [denver].[disponibilidades] DROP CONSTRAINT [FK_disponibilidades_habitaciones]
ALTER TABLE [denver].[disponibilidades] DROP CONSTRAINT [DF_disponibilidades_disponibilidad_ocupado]

/*  --------------------------------------------------------------------------------
ELIMINACION TODAS LAS TABLAS
-------------------------------------------------------------------------------- */

DROP TABLE [denver].[clientes];
DROP TABLE [denver].[consumibles];
DROP TABLE [denver].[consumibles_clientes];
DROP TABLE [denver].[estadias];
DROP TABLE [denver].[estados];
DROP TABLE [denver].[facturas];
DROP TABLE [denver].[facturas_items];
DROP TABLE [denver].[formas_pago];
DROP TABLE [denver].[funcionalidades];
DROP TABLE [denver].[habitaciones];
DROP TABLE [denver].[hoteles];
DROP TABLE [denver].[hoteles_regimenes];
DROP TABLE [denver].[paises];
DROP TABLE [denver].[regimenes];
DROP TABLE [denver].[reservas];
DROP TABLE [denver].[reservas_habitaciones];
DROP TABLE [denver].[roles];
DROP TABLE [denver].[roles_funcionalidades];
DROP TABLE [denver].[tipo_documentos];
DROP TABLE [denver].[tipo_habitaciones];
DROP TABLE [denver].[usuarios];
DROP TABLE [denver].[usuarios_hoteles];
DROP TABLE [denver].[usuarios_roles];
DROP TABLE [denver].[mantenimientos];
DROP TABLE [denver].[disponibilidades]

/*  --------------------------------------------------------------------------------
CREACION DE TODA LA ESTRUCUTRA NUEVA
-------------------------------------------------------------------------------- */

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [denver].[clientes](
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


CREATE TABLE [denver].[consumibles](
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


CREATE TABLE [denver].[consumibles_clientes](
      [consumible_cliente_consumible_id] [numeric](18, 0) NULL,
      [consumible_cliente_tipo_documento_id] [smallint] NULL,
      [consumible_cliente_pasaporte_nro] [numeric](18, 0) NULL,
      [consumible_cliente_fecha_consumo] [datetime] NULL,
      [consumible_cliente_reserva_codigo] [numeric](18, 0) NULL
) ON [PRIMARY]
GO


CREATE TABLE [denver].[estadias](
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

CREATE TABLE [denver].[estados](
      [estado_id] [smallint] NOT NULL,
      [estado_nombre] [nvarchar](150) NULL,
 CONSTRAINT [PK_estados] PRIMARY KEY CLUSTERED 
(
      [estado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [denver].[facturas](
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

CREATE TABLE [denver].[facturas_items](
      [factura_item_nro] [numeric](18, 0) NULL,      
      [factura_item_cant] [numeric](18, 0) NULL,
      [factura_item_monto] [numeric](18, 2) NULL,
      [factura_item_descripcion] [nvarchar](255) NULL,
      [factura_consumible_id] [numeric](18, 0) NULL,
      [factura_reserva_codigo] [numeric](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [denver].[formas_pago](
      [forma_pago_id] [smallint] NOT NULL,
      [forma_pago_nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_formas_pago] PRIMARY KEY CLUSTERED 
(
      [forma_pago_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [denver].[funcionalidades](
      [funcionalidad_id] [smallint] IDENTITY(1,1) NOT NULL,
      [funcionalidad_nombre] [nvarchar](255) NULL,
      [funcionalidad_created] [datetime] NULL,
 CONSTRAINT [PK_funcionalidades] PRIMARY KEY CLUSTERED 
(
      [funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [denver].[habitaciones](
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


CREATE TABLE [denver].[hoteles](
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


CREATE TABLE [denver].[hoteles_regimenes](
      [hotel_regimen_hotel_id] [smallint] NULL,
      [hotel_regimen_regimen_id] [numeric](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [denver].[paises](
      [pais_id] [smallint] NOT NULL,
      [pais_nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_paises] PRIMARY KEY CLUSTERED 
(
      [pais_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [denver].[regimenes](
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

CREATE TABLE [denver].[reservas](
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


CREATE TABLE [denver].[reservas_habitaciones](
      [reserva_habitaciones_reserva_codigo] [numeric](18, 0) NULL,
      [reserva_habitaciones_fecha_inicio] [datetime] NULL,
      [reserva_habitaciones_fecha_fin] [datetime] NULL,
      [reserva_habitaciones_tipo_habitacion_id] [numeric](18, 0) NULL,
      [reserva_habitaciones_cant_noches] [numeric](18, 0) NULL,
      [reserva_habitaciones_regimen_id] [numeric](18, 0) NULL,
      [reserva_habitaciones_precio] [numeric](18, 2) NULL
) ON [PRIMARY]
GO


CREATE TABLE [denver].[roles](
      [rol_nombre] [nvarchar](255) NOT NULL,
      [rol_activo] [char](1) NOT NULL,
      [rol_created] [datetime] NULL,
 CONSTRAINT [PK_roles1] PRIMARY KEY CLUSTERED 
(
      [rol_nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [denver].[roles_funcionalidades](
      [rol_funcionalidad_rol_nombre] [nvarchar](255) NULL,
      [rol_funcionalidad_funcionalidad_id] [smallint] NULL,
 CONSTRAINT [IX_roles_funcionalidades] UNIQUE NONCLUSTERED 
(
      [rol_funcionalidad_rol_nombre] ASC,
      [rol_funcionalidad_funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [denver].[tipo_documentos](
      [tipo_documento_id] [smallint] NOT NULL,
      [tipo_documento_nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_tipo_documentos] PRIMARY KEY CLUSTERED 
(
      [tipo_documento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [denver].[tipo_habitaciones](
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


CREATE TABLE [denver].[usuarios](
      [usuario_user] [nvarchar](50) NOT NULL,
      [usuario_pass] [nvarchar](50) NULL,
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

CREATE TABLE [denver].[usuarios_hoteles](
      [usuario_hotel_id] [smallint] NULL,
      [usuario_usuario_user] [nvarchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [denver].[usuarios_roles](
      [usuario_rol_usuario_user] [nvarchar](50) NOT NULL,
      [usuario_rol_rol_nombre] [nvarchar](255) NOT NULL,
      [usuario_rol_created] [datetime] NULL
) ON [PRIMARY]
GO

CREATE TABLE [denver].[mantenimientos](
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

CREATE TABLE [denver].[disponibilidades](
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

ALTER TABLE [denver].[regimenes] ADD  CONSTRAINT [DF_regimenes_regimen_activo]  DEFAULT ('S') FOR [regimen_activo]
GO


ALTER TABLE [denver].[reservas]  WITH NOCHECK ADD  CONSTRAINT [FK_reservas_clientes] FOREIGN KEY([reserva_cliente_tipo_documento_id], [reserva_cliente_pasaporte_nro])
REFERENCES [denver].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [denver].[reservas] NOCHECK CONSTRAINT [FK_reservas_clientes]
GO

ALTER TABLE [denver].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_estados] FOREIGN KEY([reserva_estado_id])
REFERENCES [denver].[estados] ([estado_id])
GO

ALTER TABLE [denver].[reservas] CHECK CONSTRAINT [FK_reservas_estados]
GO

ALTER TABLE [denver].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_hoteles] FOREIGN KEY([reserva_hotel_id])
REFERENCES [denver].[hoteles] ([hotel_id])
GO

ALTER TABLE [denver].[reservas] CHECK CONSTRAINT [FK_reservas_hoteles]
GO

ALTER TABLE [denver].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_usuarios] FOREIGN KEY([reserva_usuario_user])
REFERENCES [denver].[usuarios] ([usuario_user])
GO

ALTER TABLE [denver].[reservas] CHECK CONSTRAINT [FK_reservas_usuarios]
GO

ALTER TABLE [denver].[reservas]  WITH NOCHECK ADD  CONSTRAINT [FK_reservas_usuarios1] FOREIGN KEY([reserva_usuario_user_cancelacion])
REFERENCES [denver].[usuarios] ([usuario_user])
GO

ALTER TABLE [denver].[reservas] NOCHECK CONSTRAINT [FK_reservas_usuarios1]
GO

ALTER TABLE [denver].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_regimenes] FOREIGN KEY([reserva_habitaciones_regimen_id])
REFERENCES [denver].[regimenes] ([regimen_id])
GO

ALTER TABLE [denver].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_regimenes]
GO

ALTER TABLE [denver].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_reservas] FOREIGN KEY([reserva_habitaciones_reserva_codigo])
REFERENCES [denver].[reservas] ([reserva_codigo])
GO

ALTER TABLE [denver].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_reservas]
GO

ALTER TABLE [denver].[reservas_habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones] FOREIGN KEY([reserva_habitaciones_tipo_habitacion_id])
REFERENCES [denver].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [denver].[reservas_habitaciones] CHECK CONSTRAINT [FK_reservas_habitaciones_tipo_habitaciones]
GO

ALTER TABLE [denver].[roles] ADD  CONSTRAINT [DF_roles1_rol_activo]  DEFAULT ('S') FOR [rol_activo]
GO


ALTER TABLE [denver].[roles_funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_roles_funcionalidades_funcionalidades] FOREIGN KEY([rol_funcionalidad_funcionalidad_id])
REFERENCES [denver].[funcionalidades] ([funcionalidad_id])
GO

ALTER TABLE [denver].[roles_funcionalidades] CHECK CONSTRAINT [FK_roles_funcionalidades_funcionalidades]
GO

ALTER TABLE [denver].[roles_funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_roles_funcionalidades_roles] FOREIGN KEY([rol_funcionalidad_rol_nombre])
REFERENCES [denver].[roles] ([rol_nombre])
GO

ALTER TABLE [denver].[roles_funcionalidades] CHECK CONSTRAINT [FK_roles_funcionalidades_roles]
GO


ALTER TABLE [denver].[usuarios] ADD  CONSTRAINT [DF_usuarios_usuario_login_fallidos]  DEFAULT ((0)) FOR [usuario_login_fallidos]
GO

ALTER TABLE [denver].[usuarios] ADD  CONSTRAINT [DF_usuarios_usuario_activo]  DEFAULT ('S') FOR [usuario_activo]
GO

ALTER TABLE [denver].[usuarios_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_hoteles_hoteles] FOREIGN KEY([usuario_hotel_id])
REFERENCES [denver].[hoteles] ([hotel_id])
GO

ALTER TABLE [denver].[usuarios_hoteles] CHECK CONSTRAINT [FK_usuarios_hoteles_hoteles]
GO

ALTER TABLE [denver].[usuarios_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_hoteles_usuarios] FOREIGN KEY([usuario_usuario_user])
REFERENCES [denver].[usuarios] ([usuario_user])
GO

ALTER TABLE [denver].[usuarios_hoteles] CHECK CONSTRAINT [FK_usuarios_hoteles_usuarios]
GO

ALTER TABLE [denver].[usuarios_roles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles_roles] FOREIGN KEY([usuario_rol_rol_nombre])
REFERENCES [denver].[roles] ([rol_nombre])
GO

ALTER TABLE [denver].[usuarios_roles] CHECK CONSTRAINT [FK_usuarios_roles_roles]
GO

ALTER TABLE [denver].[usuarios_roles]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles_usuarios] FOREIGN KEY([usuario_rol_usuario_user])
REFERENCES [denver].[usuarios] ([usuario_user])
GO

ALTER TABLE [denver].[usuarios_roles] CHECK CONSTRAINT [FK_usuarios_roles_usuarios]
GO

ALTER TABLE [denver].[mantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_mantenimientos_hoteles] FOREIGN KEY([mantenimiento_hotel_id])
REFERENCES [denver].[hoteles] ([hotel_id])
GO

ALTER TABLE [denver].[mantenimientos] CHECK CONSTRAINT [FK_mantenimientos_hoteles]
GO

ALTER TABLE [denver].[hoteles_regimenes]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_regimenes_hoteles] FOREIGN KEY([hotel_regimen_hotel_id])
REFERENCES [denver].[hoteles] ([hotel_id])
GO

ALTER TABLE [denver].[hoteles_regimenes] CHECK CONSTRAINT [FK_hoteles_regimenes_hoteles]
GO

ALTER TABLE [denver].[hoteles_regimenes]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_regimenes_regimenes] FOREIGN KEY([hotel_regimen_regimen_id])
REFERENCES [denver].[regimenes] ([regimen_id])
GO

ALTER TABLE [denver].[hoteles_regimenes] CHECK CONSTRAINT [FK_hoteles_regimenes_regimenes]
GO

ALTER TABLE [denver].[hoteles] ADD  CONSTRAINT [DF_hoteles_hotel_activo]  DEFAULT ('S') FOR [hotel_activo]
GO

ALTER TABLE [denver].[hoteles]  WITH CHECK ADD  CONSTRAINT [FK_hoteles_paises] FOREIGN KEY([hotel_pais_id])
REFERENCES [denver].[paises] ([pais_id])
GO

ALTER TABLE [denver].[hoteles] CHECK CONSTRAINT [FK_hoteles_paises]
GO

ALTER TABLE [denver].[habitaciones] ADD  CONSTRAINT [DF_habitaciones_habitacion_activa]  DEFAULT ('S') FOR [habitacion_activa]
GO

ALTER TABLE [denver].[habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_habitaciones_hoteles] FOREIGN KEY([habitacion_hotel_id])
REFERENCES [denver].[hoteles] ([hotel_id])
GO

ALTER TABLE [denver].[habitaciones] CHECK CONSTRAINT [FK_habitaciones_hoteles]
GO

ALTER TABLE [denver].[habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_habitaciones_tipo_habitaciones] FOREIGN KEY([habitacion_tipo_habitacion_id])
REFERENCES [denver].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [denver].[habitaciones] CHECK CONSTRAINT [FK_habitaciones_tipo_habitaciones]
GO

ALTER TABLE [denver].[clientes] ADD  CONSTRAINT [DF_clientes_cliente_activo]  DEFAULT ('S') FOR [cliente_activo]
GO

ALTER TABLE [denver].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_paises] FOREIGN KEY([cliente_pais_id])
REFERENCES [denver].[paises] ([pais_id])
GO

ALTER TABLE [denver].[clientes] CHECK CONSTRAINT [FK_clientes_paises]
GO

ALTER TABLE [denver].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tipo_documentos] FOREIGN KEY([cliente_tipo_documento_id])
REFERENCES [denver].[tipo_documentos] ([tipo_documento_id])
GO

ALTER TABLE [denver].[clientes] CHECK CONSTRAINT [FK_clientes_tipo_documentos]
GO


ALTER TABLE [denver].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_clientes] FOREIGN KEY([consumible_cliente_tipo_documento_id], [consumible_cliente_pasaporte_nro])
REFERENCES [denver].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [denver].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_clientes]
GO

ALTER TABLE [denver].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_consumibles] FOREIGN KEY([consumible_cliente_consumible_id])
REFERENCES [denver].[consumibles] ([consumible_id])
GO

ALTER TABLE [denver].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_consumibles]
GO

ALTER TABLE [denver].[consumibles_clientes]  WITH CHECK ADD  CONSTRAINT [FK_consumibles_clientes_reservas] FOREIGN KEY([consumible_cliente_reserva_codigo])
REFERENCES [denver].[reservas] ([reserva_codigo])
GO

ALTER TABLE [denver].[consumibles_clientes] CHECK CONSTRAINT [FK_consumibles_clientes_reservas]
GO


ALTER TABLE [denver].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_clientes] FOREIGN KEY([estadia_cliente_tipo_documento_id], [estadia_cliente_pasaporte_nro])
REFERENCES [denver].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [denver].[estadias] CHECK CONSTRAINT [FK_estadias_clientes]
GO

ALTER TABLE [denver].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_hoteles] FOREIGN KEY([estadia_hotel_id])
REFERENCES [denver].[hoteles] ([hotel_id])
GO

ALTER TABLE [denver].[estadias] CHECK CONSTRAINT [FK_estadias_hoteles]
GO

ALTER TABLE [denver].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_reservas] FOREIGN KEY([estadia_reserva_codigo])
REFERENCES [denver].[reservas] ([reserva_codigo])
GO

ALTER TABLE [denver].[estadias] CHECK CONSTRAINT [FK_estadias_reservas]
GO

ALTER TABLE [denver].[estadias]  WITH CHECK ADD  CONSTRAINT [FK_estadias_usuarios1] FOREIGN KEY([estadia_usuario_user])
REFERENCES [denver].[usuarios] ([usuario_user])
GO

ALTER TABLE [denver].[estadias] CHECK CONSTRAINT [FK_estadias_usuarios1]
GO

ALTER TABLE [denver].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_clientes] FOREIGN KEY([factura_cliente_tipo_documento], [factura_pasaporte_nro])
REFERENCES [denver].[clientes] ([cliente_tipo_documento_id], [cliente_pasaporte_nro])
GO

ALTER TABLE [denver].[facturas] CHECK CONSTRAINT [FK_facturas_clientes]
GO

ALTER TABLE [denver].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_formas_pago] FOREIGN KEY([factura_forma_pago_id])
REFERENCES [denver].[formas_pago] ([forma_pago_id])
GO

ALTER TABLE [denver].[facturas] CHECK CONSTRAINT [FK_facturas_formas_pago]
GO

ALTER TABLE [denver].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_consumibles] FOREIGN KEY([factura_consumible_id])
REFERENCES [denver].[consumibles] ([consumible_id])
GO

ALTER TABLE [denver].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_consumibles]
GO

ALTER TABLE [denver].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_facturas] FOREIGN KEY([factura_item_nro])
REFERENCES [denver].[facturas] ([factura_nro])
GO

ALTER TABLE [denver].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_facturas]
GO

ALTER TABLE [denver].[facturas_items]  WITH CHECK ADD  CONSTRAINT [FK_facturas_items_reservas] FOREIGN KEY([factura_reserva_codigo])
REFERENCES [denver].[reservas] ([reserva_codigo])
GO

ALTER TABLE [denver].[facturas_items] CHECK CONSTRAINT [FK_facturas_items_reservas]
GO

ALTER TABLE [denver].[disponibilidades] ADD  CONSTRAINT [DF_disponibilidades_disponibilidad_ocupado]  DEFAULT ('N') FOR [disponibilidad_ocupado]
GO

ALTER TABLE [denver].[disponibilidades]  WITH CHECK ADD  CONSTRAINT [FK_disponibilidades_habitaciones] FOREIGN KEY([disponibilidad_habitacion_nro], [disponibilidad_hotel_id])
REFERENCES [denver].[habitaciones] ([habitacion_nro], [habitacion_hotel_id])
GO

ALTER TABLE [denver].[disponibilidades] CHECK CONSTRAINT [FK_disponibilidades_habitaciones]
GO

ALTER TABLE [denver].[disponibilidades]  WITH CHECK ADD  CONSTRAINT [FK_disponibilidades_tipo_habitaciones] FOREIGN KEY([disponibilidad_tipo_habitacion_id])
REFERENCES [denver].[tipo_habitaciones] ([tipo_habitacion_id])
GO

ALTER TABLE [denver].[disponibilidades] CHECK CONSTRAINT [FK_disponibilidades_tipo_habitaciones]
GO


/****** PAISES  ******/
INSERT INTO denver.paises VALUES (1, 'ARGENTINA');
INSERT INTO denver.paises VALUES (2, 'CHILE');
INSERT INTO denver.paises VALUES (3, 'URUGUAY');
INSERT INTO denver.paises VALUES (4, 'PARAGUAY');
INSERT INTO denver.paises VALUES (5, 'BOLIVIA');
INSERT INTO denver.paises VALUES (6, 'COLOMBIA');
INSERT INTO denver.paises VALUES (7, 'PERÚ');
INSERT INTO denver.paises VALUES (8, 'BRASIL');
INSERT INTO denver.paises VALUES (9, 'ECUADOR');
INSERT INTO denver.paises VALUES (10, 'VENEZUELA');
INSERT INTO denver.paises VALUES (11, 'PANAMÁ');
INSERT INTO denver.paises VALUES (12, 'COSTA RICA');
INSERT INTO denver.paises VALUES (13, 'HONDURAS');
INSERT INTO denver.paises VALUES (14, 'GUATEMALA');
INSERT INTO denver.paises VALUES (15, 'MÉXICO');
INSERT INTO denver.paises VALUES (16, 'CUBA');
INSERT INTO denver.paises VALUES (17, 'NICARAGUA');
INSERT INTO denver.paises VALUES (18, 'EL SALVADOR');
INSERT INTO denver.paises VALUES (19, 'HAITÍ');
INSERT INTO denver.paises VALUES (20, 'REPÚBLICA DOMINICANA');
INSERT INTO denver.paises VALUES (21, 'PUERTO RICO');
INSERT INTO denver.paises VALUES (22, 'ESPAÑA');
GO

/****** FORMAS_PAGO  ******/
INSERT INTO denver.formas_pago VALUES (1, 'EFECTIVO');
INSERT INTO denver.formas_pago VALUES (2, 'TARJETA DE CREDITO');
INSERT INTO denver.formas_pago VALUES (3, 'TARJETA DE DEBITO');
INSERT INTO denver.formas_pago VALUES (4, 'CHEQUE');
GO

/****** ESTADOS  ******/
INSERT INTO denver.estados VALUES (1, 'RESERVA CORRECTA');
INSERT INTO denver.estados VALUES (2, 'RESERVA MODIFICADA');
INSERT INTO denver.estados VALUES (3, 'RESERVA CANCELADA POR RECEPCIÓN');
INSERT INTO denver.estados VALUES (4, 'RESERVA CANCELADA POR CLIENTE');
INSERT INTO denver.estados VALUES (5, 'RESERVA CANCELADA POR NO-SHOW');
INSERT INTO denver.estados VALUES (6, 'RESERVA CON INGRESO (EFECTIVIZADA)');
GO

/****** tipo_documentos  ******/
INSERT INTO denver.tipo_documentos VALUES (1, 'PASAPORTE');
INSERT INTO denver.tipo_documentos VALUES (2, 'DNI');
INSERT INTO denver.tipo_documentos VALUES (3, 'LE');
INSERT INTO denver.tipo_documentos VALUES (4, 'LC');
INSERT INTO denver.tipo_documentos VALUES (5, 'CEDULA POLICIAL');
GO

/****** usuarios  ******/
INSERT INTO denver.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('GUEST', HASHBYTES('SHA2_256','GUEST'),'GUEST','GUEST');
INSERT INTO denver.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('MIGRATION', HASHBYTES('SHA2_256','MIGRATION'),'MIGRATION','MIGRATION');
INSERT INTO denver.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('ADMIN', HASHBYTES('SHA2_256','ADMIN'),'ADMIN','ADMIN');
INSERT INTO denver.usuarios (usuario_user, usuario_pass, usuario_nombre, usuario_apellido) VALUES ('RECEPCION', HASHBYTES('SHA2_256','RECEPCION'),'RECEPCION','RECEPCION');
GO


/****** roles  ******/
INSERT INTO denver.roles (rol_nombre, rol_created) VALUES ('ADMINISTRADOR',GETDATE());
INSERT INTO denver.roles (rol_nombre, rol_created) VALUES ('RECEPCIONISTA',GETDATE());
INSERT INTO denver.roles (rol_nombre, rol_created) VALUES ('GUEST',GETDATE());
GO

/****** usuarios_roles  ******/
INSERT INTO denver.usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('ADMIN','ADMINISTRADOR',GETDATE());
INSERT INTO denver.usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('RECEPCION','RECEPCIONISTA',GETDATE());
INSERT INTO denver.usuarios_roles (usuario_rol_usuario_user, usuario_rol_rol_nombre, usuario_rol_created) VALUES ('GUEST','GUEST',GETDATE());
GO

/****** funcionalidades  ******/
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE ROL', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE USUARIO', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE CLIENTE', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE HOTEL', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM DE HABITACIÓN', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('ABM RÉGIMEN DE ESTADÍA', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('GENERAR O MODIFICAR UN RESERVA', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('CANCELAR RESERVA', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('REGISTRAR ESTADÍA (CHECK-IN/CHECK-OUT)', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('REGISTRAR CONSUMIBLES', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('FACTURAR ESTADÍA', GETDATE());
INSERT INTO denver.funcionalidades (funcionalidad_nombre, funcionalidad_created) VALUES ('LISTADO ESTADÍSTICO', GETDATE());
GO

/****** CLIENTES ******/
/*
EXISTEN REGISTROS CON PASAPORTES DUPLICADOS Y PERTENECIENTES A PERSONAS DIFERENTES. SE EXCLUYERON. TAMBIEN SE PUSO COMO EMAIL EL NRO DE PASAPORTE 
PARA GARANTIZAR QUE NO HAYA DUPLICADOS. EN OTRO PROCESO SE REEMPLAZARAN ESTOS VALORES POR AL MENOS UN EMAIL VALIDO

*/
INSERT INTO denver.clientes (cliente_pasaporte_nro,cliente_apellido,cliente_nombre,cliente_fecha_nac,cliente_email,cliente_dom_calle,
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
INSERT INTO denver.hoteles 
(hotel_ciudad, hotel_calle, hotel_nro_calle, hotel_estrellas, hotel_recarga_estrella, hotel_pais_id, hotel_created)
( 
SELECT     Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, 1, GETDATE()
FROM         gd_esquema.Maestra
GROUP BY Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella
)
GO


/****** usuarios_hoteles  ******/
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'GUEST');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (1,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (2,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (3,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (4,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (5,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (6,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (7,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (8,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (9,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (10,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (11,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (12,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (13,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (14,'MIGRATION');
INSERT INTO denver.usuarios_hoteles (usuario_hotel_id, usuario_usuario_user) VALUES (15,'MIGRATION');
GO

/****** TIPO_HABITACIONES ******/
INSERT INTO denver.tipo_habitaciones (tipo_habitacion_descripcion, tipo_habitacion_porcentual, tipo_habitacion_id, tipo_habitacion_created)
(
SELECT  DISTINCT   Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual, Habitacion_Tipo_Codigo, GETDATE()
FROM         gd_esquema.Maestra

)
GO

/****** HABITACIONES ******/
INSERT INTO denver.habitaciones 
(habitacion_nro, habitacion_piso, habitacion_frente, habitacion_created, habitacion_hotel_id, habitacion_tipo_habitacion_id)
(
SELECT distinct Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, GETDATE(), (SELECT distinct t1.hotel_id FROM denver.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad), Habitacion_Tipo_Codigo
FROM         gd_esquema.Maestra

)
GO

/****** CONSUMIBLES ******/
INSERT INTO denver.consumibles
(consumible_id, consumible_descripcion, consumible_precio, consumible_created)
(
SELECT     Consumible_Codigo, Consumible_Descripcion, Consumible_Precio, GETDATE()
FROM         gd_esquema.Maestra
WHERE Consumible_Codigo is not null
GROUP BY Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
)
GO

/****** REGIMENES ******/
INSERT INTO denver.regimenes
(regimen_descripcion,regimen_precio,regimen_created)
(
SELECT     Regimen_Descripcion, Regimen_Precio, GETDATE()
FROM         gd_esquema.Maestra
group by Regimen_Descripcion, Regimen_Precio
)
GO


/****** HOTELES_REGIMENES ******/
INSERT INTO denver.hoteles_regimenes
(hotel_regimen_hotel_id,hotel_regimen_regimen_id)
(
SELECT DISTINCT    
(SELECT distinct t1.hotel_id FROM denver.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad),
(SELECT distinct t1.regimen_id FROM denver.regimenes as t1 WHERE t1.regimen_descripcion = gd_esquema.Maestra.Regimen_Descripcion)
 
FROM gd_esquema.Maestra
)
GO


/****** RESERVAS ******/
INSERT INTO denver.reservas
(reserva_fecha_inicio, reserva_fecha_fin,reserva_codigo,reserva_cant_noches, reserva_cliente_tipo_documento_id, reserva_cliente_pasaporte_nro, reserva_hotel_id, reserva_usuario_user, reserva_estado_id)
(
SELECT     Reserva_Fecha_Inicio, (Reserva_Fecha_Inicio+Reserva_Cant_Noches), Reserva_Codigo, Reserva_Cant_Noches, 1, Cliente_Pasaporte_Nro, (SELECT distinct t1.hotel_id FROM denver.hoteles as t1 WHERE t1.hotel_calle = gd_esquema.Maestra.Hotel_Calle AND t1.hotel_ciudad = gd_esquema.Maestra.Hotel_Ciudad), 'MIGRATION',1
FROM         gd_esquema.Maestra
WHERE
      Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)
  GROUP BY
      Reserva_Fecha_Inicio, Reserva_Codigo, Reserva_Cant_Noches, Cliente_Pasaporte_Nro, Hotel_Calle, Hotel_Ciudad
)
GO



/****** CONSUMIBLES_CLIENTES ******/
INSERT INTO denver.consumibles_clientes
(consumible_cliente_consumible_id, consumible_cliente_pasaporte_nro, consumible_cliente_tipo_documento_id, consumible_cliente_fecha_consumo, consumible_cliente_reserva_codigo)
(
SELECT     Consumible_Codigo, Cliente_Pasaporte_Nro, 1, NULL, (SELECT TOP 1 reserva_codigo FROM denver.reservas WHERE reserva_cliente_pasaporte_nro = gd_esquema.Maestra.Cliente_Pasaporte_Nro)
FROM         gd_esquema.Maestra
WHERE
      Consumible_Codigo IS NOT NULL AND  Cliente_Pasaporte_Nro NOT IN(5833450,8573690,9616602,10968810,13197523,17144724,17993372,19944671,25170042,27682640,28333918,28766839,33462772,33467493,40407965,41118734,49848816,52451739,56505775,58145810,58685660,
      59187942,59790782,65047886,69110399,72231403,74872928, 74899834,75898906,82103542,82337502,83630142,85044064,87591511,
      88559381,89094646,90135406,91296720,95744921)
GROUP BY
      Consumible_Codigo, Cliente_Pasaporte_Nro
)
GO

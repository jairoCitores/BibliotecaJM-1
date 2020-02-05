USE [master]
GO
/****** Object:  Database [BibliotecaJM]    Script Date: 05/02/2020 0:31:41 ******/
CREATE DATABASE [BibliotecaJM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BibliotecaJM', FILENAME = N'C:\Users\admin\BibliotecaJM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BibliotecaJM_log', FILENAME = N'C:\Users\admin\BibliotecaJM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BibliotecaJM] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BibliotecaJM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BibliotecaJM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BibliotecaJM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BibliotecaJM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BibliotecaJM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BibliotecaJM] SET ARITHABORT OFF 
GO
ALTER DATABASE [BibliotecaJM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BibliotecaJM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BibliotecaJM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BibliotecaJM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BibliotecaJM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BibliotecaJM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BibliotecaJM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BibliotecaJM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BibliotecaJM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BibliotecaJM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BibliotecaJM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BibliotecaJM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BibliotecaJM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BibliotecaJM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BibliotecaJM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BibliotecaJM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BibliotecaJM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BibliotecaJM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BibliotecaJM] SET  MULTI_USER 
GO
ALTER DATABASE [BibliotecaJM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BibliotecaJM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BibliotecaJM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BibliotecaJM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BibliotecaJM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BibliotecaJM] SET QUERY_STORE = OFF
GO
USE [BibliotecaJM]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [BibliotecaJM]
GO
/****** Object:  Table [dbo].[libros]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libros](
	[id_lib] [int] IDENTITY(1,1) NOT NULL,
	[titulo_lib] [nvarchar](50) NULL,
	[autor_lib] [nvarchar](50) NULL,
	[seccion_lib] [int] NULL,
	[prestado_sn_lib] [nchar](1) NULL,
 CONSTRAINT [PK_libros] PRIMARY KEY CLUSTERED 
(
	[id_lib] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prestamos]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prestamos](
	[id_lec_pre] [int] NOT NULL,
	[id_lib_pre] [int] NOT NULL,
	[fecha_presta_pre] [datetime] NOT NULL,
	[fecha_devol_pre] [datetime] NOT NULL,
 CONSTRAINT [PK_prestamos] PRIMARY KEY CLUSTERED 
(
	[id_lec_pre] ASC,
	[id_lib_pre] ASC,
	[fecha_presta_pre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[LibrosPrestados]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LibrosPrestados]
AS
SELECT        dbo.libros.id_lib, dbo.libros.titulo_lib, dbo.prestamos.fecha_presta_pre, dbo.prestamos.fecha_devol_pre, dbo.prestamos.id_lec_pre
FROM            dbo.libros INNER JOIN
                         dbo.prestamos ON dbo.libros.id_lib = dbo.prestamos.id_lib_pre
GO
/****** Object:  Table [dbo].[configuracion]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[configuracion](
	[id_cnf] [int] IDENTITY(1,1) NOT NULL,
	[nombre_biblioteca_cnf] [nvarchar](50) NULL,
	[direccion_cnf] [nvarchar](50) NULL,
	[provincia_cnf] [int] NULL,
	[dias_prestamo_cnf] [int] NOT NULL,
	[dias_penalizacion_cnf] [int] NOT NULL,
 CONSTRAINT [PK_configuracion] PRIMARY KEY CLUSTERED 
(
	[id_cnf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historico_prestamos]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historico_prestamos](
	[id_lec_his] [int] NOT NULL,
	[id_lib_his] [int] NOT NULL,
	[fecha_presta_his] [datetime] NOT NULL,
	[fecha_devol_his] [datetime] NOT NULL,
 CONSTRAINT [PK_historico_prestamos] PRIMARY KEY CLUSTERED 
(
	[id_lec_his] ASC,
	[id_lib_his] ASC,
	[fecha_presta_his] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lectores]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lectores](
	[id_lec] [int] IDENTITY(1,1) NOT NULL,
	[nombre_lec] [nvarchar](50) NULL,
	[domicilio_lec] [nvarchar](50) NULL,
	[provincia_lec] [int] NULL,
	[email_lec] [nvarchar](50) NULL,
	[fecha_nacimiento_lec] [date] NULL,
	[fecha_penalizacion_lec] [datetime] NULL,
 CONSTRAINT [PK_lectores] PRIMARY KEY CLUSTERED 
(
	[id_lec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[provincias]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provincias](
	[id_pro] [int] NOT NULL,
	[provincia_pro] [nvarchar](50) NULL,
 CONSTRAINT [PK_provincias] PRIMARY KEY CLUSTERED 
(
	[id_pro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[secciones]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[secciones](
	[id_sec] [int] NOT NULL,
	[seccion_sec] [nvarchar](50) NULL,
 CONSTRAINT [PK_secciones] PRIMARY KEY CLUSTERED 
(
	[id_sec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 05/02/2020 0:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[nombre_usu] [nvarchar](20) NOT NULL,
	[password_usu] [nvarchar](20) NOT NULL,
	[tipo_usu] [nchar](1) NOT NULL,
 CONSTRAINT [PK_usuarios_1] PRIMARY KEY CLUSTERED 
(
	[nombre_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[configuracion] ON 

INSERT [dbo].[configuracion] ([id_cnf], [nombre_biblioteca_cnf], [direccion_cnf], [provincia_cnf], [dias_prestamo_cnf], [dias_penalizacion_cnf]) VALUES (1, N'IES Julián Marías                               ', N'C/Eusebio González Suárez, sn                     ', 47, 10, 10)
SET IDENTITY_INSERT [dbo].[configuracion] OFF
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 1, CAST(N'2010-08-25T12:03:47.000' AS DateTime), CAST(N'2010-08-28T03:57:31.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 2, CAST(N'2018-02-01T13:20:00.000' AS DateTime), CAST(N'2018-02-10T10:20:00.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 9, CAST(N'2008-08-25T16:44:35.000' AS DateTime), CAST(N'2008-09-02T22:36:01.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 10, CAST(N'2015-06-16T13:48:41.000' AS DateTime), CAST(N'2015-06-20T04:06:19.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 11, CAST(N'2017-07-08T01:16:13.000' AS DateTime), CAST(N'2017-07-13T16:31:07.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 12, CAST(N'2009-02-23T10:49:48.000' AS DateTime), CAST(N'2009-02-24T04:17:26.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 15, CAST(N'2002-01-12T13:41:43.000' AS DateTime), CAST(N'2002-01-25T10:45:36.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 15, CAST(N'2004-04-10T04:23:43.000' AS DateTime), CAST(N'2004-04-18T22:12:59.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 17, CAST(N'2003-04-20T21:10:25.000' AS DateTime), CAST(N'2003-04-22T14:16:44.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 19, CAST(N'2000-04-16T18:38:08.000' AS DateTime), CAST(N'2000-04-29T16:00:13.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 19, CAST(N'2008-03-23T16:13:31.000' AS DateTime), CAST(N'2008-03-31T00:39:57.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 20, CAST(N'2011-02-10T01:46:14.000' AS DateTime), CAST(N'2011-02-18T20:19:59.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 21, CAST(N'2014-03-05T21:56:58.000' AS DateTime), CAST(N'2014-03-06T17:13:29.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 25, CAST(N'2005-03-05T16:14:19.000' AS DateTime), CAST(N'2005-03-12T17:57:52.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 26, CAST(N'2001-04-01T15:44:41.000' AS DateTime), CAST(N'2001-04-04T13:23:31.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (1, 29, CAST(N'2012-01-26T13:03:15.000' AS DateTime), CAST(N'2012-02-09T18:31:03.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 1, CAST(N'2006-10-27T00:04:22.000' AS DateTime), CAST(N'2006-11-05T21:31:29.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 3, CAST(N'2012-11-25T01:01:44.000' AS DateTime), CAST(N'2012-12-07T02:59:18.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 3, CAST(N'2013-08-02T00:15:04.000' AS DateTime), CAST(N'2013-08-14T03:55:41.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 10, CAST(N'2006-09-03T16:24:57.000' AS DateTime), CAST(N'2006-09-06T09:21:23.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 10, CAST(N'2013-05-11T14:58:25.000' AS DateTime), CAST(N'2013-05-16T10:38:45.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 19, CAST(N'2006-03-24T10:34:18.000' AS DateTime), CAST(N'2006-04-01T08:28:48.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 19, CAST(N'2008-04-22T00:55:42.000' AS DateTime), CAST(N'2008-05-03T14:29:58.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 20, CAST(N'2003-08-24T00:07:04.000' AS DateTime), CAST(N'2003-08-27T07:56:05.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 22, CAST(N'2000-01-26T02:34:29.000' AS DateTime), CAST(N'2000-02-07T12:22:11.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (2, 28, CAST(N'2002-11-16T02:53:43.000' AS DateTime), CAST(N'2002-11-18T09:30:46.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 2, CAST(N'2000-01-02T01:20:38.000' AS DateTime), CAST(N'2000-01-06T06:28:54.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 3, CAST(N'2012-10-25T03:27:56.000' AS DateTime), CAST(N'2012-10-25T14:23:54.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 6, CAST(N'2011-11-07T04:57:19.000' AS DateTime), CAST(N'2011-11-09T15:04:41.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 13, CAST(N'2016-01-24T13:33:17.000' AS DateTime), CAST(N'2016-01-30T04:34:23.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 14, CAST(N'2004-08-19T17:09:27.000' AS DateTime), CAST(N'2004-09-02T15:38:09.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 18, CAST(N'2016-10-27T08:57:13.000' AS DateTime), CAST(N'2016-11-04T08:08:03.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 19, CAST(N'2016-06-17T14:52:03.000' AS DateTime), CAST(N'2016-06-30T20:25:49.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 23, CAST(N'2007-08-04T07:22:54.000' AS DateTime), CAST(N'2007-08-19T05:20:09.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 28, CAST(N'2003-11-07T20:07:13.000' AS DateTime), CAST(N'2003-11-13T04:35:21.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (3, 29, CAST(N'2015-04-06T02:01:58.000' AS DateTime), CAST(N'2015-04-18T15:25:08.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 1, CAST(N'2002-02-13T12:09:27.000' AS DateTime), CAST(N'2002-02-19T09:10:28.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 2, CAST(N'2004-05-08T09:21:04.000' AS DateTime), CAST(N'2004-05-10T14:13:35.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 2, CAST(N'2016-08-26T22:24:20.000' AS DateTime), CAST(N'2016-09-07T03:52:38.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 4, CAST(N'2013-08-06T07:51:24.000' AS DateTime), CAST(N'2013-08-17T21:50:11.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 4, CAST(N'2017-02-06T12:15:45.000' AS DateTime), CAST(N'2017-02-18T08:29:56.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 11, CAST(N'2011-11-22T17:22:17.000' AS DateTime), CAST(N'2011-11-25T18:31:27.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 16, CAST(N'2011-07-17T21:17:06.000' AS DateTime), CAST(N'2011-07-21T09:47:29.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 22, CAST(N'2008-08-26T11:29:01.000' AS DateTime), CAST(N'2008-08-31T12:53:09.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 23, CAST(N'2008-02-19T12:34:52.000' AS DateTime), CAST(N'2008-02-21T03:43:57.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 28, CAST(N'2011-06-14T07:11:52.000' AS DateTime), CAST(N'2011-06-25T19:56:45.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (4, 29, CAST(N'2006-08-02T21:05:03.000' AS DateTime), CAST(N'2006-08-06T03:07:25.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 7, CAST(N'2012-06-11T20:35:48.000' AS DateTime), CAST(N'2012-06-17T14:10:26.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 13, CAST(N'2006-02-01T17:48:54.000' AS DateTime), CAST(N'2006-02-15T01:49:52.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 15, CAST(N'2010-10-22T07:18:16.000' AS DateTime), CAST(N'2010-11-01T01:16:57.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 18, CAST(N'2005-06-11T10:39:22.000' AS DateTime), CAST(N'2005-06-22T01:18:52.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 20, CAST(N'2005-02-21T17:19:04.000' AS DateTime), CAST(N'2005-02-25T06:28:33.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 22, CAST(N'2010-07-02T18:03:44.000' AS DateTime), CAST(N'2010-07-12T17:48:24.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 25, CAST(N'2012-08-08T12:41:10.000' AS DateTime), CAST(N'2012-08-12T22:25:12.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 27, CAST(N'2012-07-03T01:00:40.000' AS DateTime), CAST(N'2012-07-09T11:19:46.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 28, CAST(N'2005-02-16T07:42:07.000' AS DateTime), CAST(N'2005-03-03T05:13:43.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 29, CAST(N'2012-05-25T18:48:45.000' AS DateTime), CAST(N'2012-06-09T02:27:02.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (5, 29, CAST(N'2013-06-25T12:07:09.000' AS DateTime), CAST(N'2013-07-02T22:58:34.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 1, CAST(N'2010-01-08T11:45:43.000' AS DateTime), CAST(N'2010-01-21T09:51:16.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 1, CAST(N'2014-01-05T08:35:14.000' AS DateTime), CAST(N'2014-01-08T14:35:44.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 4, CAST(N'2007-02-07T11:22:00.000' AS DateTime), CAST(N'2007-02-14T10:01:00.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 5, CAST(N'2003-02-06T00:54:29.000' AS DateTime), CAST(N'2003-02-19T05:57:54.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 7, CAST(N'2000-10-05T17:03:38.000' AS DateTime), CAST(N'2000-10-14T03:34:47.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 7, CAST(N'2015-10-15T06:56:20.000' AS DateTime), CAST(N'2015-10-25T07:08:41.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 9, CAST(N'2008-08-20T18:05:38.000' AS DateTime), CAST(N'2008-09-02T05:06:49.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 15, CAST(N'2004-01-05T05:49:48.000' AS DateTime), CAST(N'2004-01-08T06:05:25.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 15, CAST(N'2013-02-08T00:21:03.000' AS DateTime), CAST(N'2013-02-10T17:59:27.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 17, CAST(N'2015-01-20T17:28:29.000' AS DateTime), CAST(N'2015-01-23T00:02:51.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 17, CAST(N'2017-08-05T18:40:45.000' AS DateTime), CAST(N'2017-08-12T07:54:15.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 19, CAST(N'2004-08-23T07:05:02.000' AS DateTime), CAST(N'2004-09-02T18:45:48.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 22, CAST(N'2005-04-17T05:55:07.000' AS DateTime), CAST(N'2005-04-22T06:27:21.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 22, CAST(N'2006-04-27T21:13:10.000' AS DateTime), CAST(N'2006-04-29T18:55:44.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 23, CAST(N'2017-02-27T11:57:34.000' AS DateTime), CAST(N'2017-03-06T05:39:57.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 26, CAST(N'2006-10-09T16:16:11.000' AS DateTime), CAST(N'2006-10-12T04:36:37.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 26, CAST(N'2008-04-18T08:22:10.000' AS DateTime), CAST(N'2008-04-23T09:25:24.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 26, CAST(N'2009-05-24T19:13:18.000' AS DateTime), CAST(N'2009-06-05T01:07:24.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (6, 28, CAST(N'2010-04-08T06:39:22.000' AS DateTime), CAST(N'2010-04-20T07:32:36.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 2, CAST(N'2000-02-25T05:18:27.000' AS DateTime), CAST(N'2000-03-09T12:08:05.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 2, CAST(N'2013-01-27T12:19:12.000' AS DateTime), CAST(N'2013-01-30T02:09:56.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 4, CAST(N'2014-05-16T11:06:34.000' AS DateTime), CAST(N'2014-05-28T23:43:28.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 6, CAST(N'2015-03-17T22:07:38.000' AS DateTime), CAST(N'2015-03-23T18:31:54.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 7, CAST(N'2010-08-02T10:04:28.000' AS DateTime), CAST(N'2010-08-04T07:06:56.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 18, CAST(N'2008-07-19T08:36:57.000' AS DateTime), CAST(N'2008-07-22T07:26:26.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 19, CAST(N'2014-05-02T02:31:28.000' AS DateTime), CAST(N'2014-05-16T07:13:47.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 20, CAST(N'2008-08-24T20:40:57.000' AS DateTime), CAST(N'2008-09-02T02:26:12.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 21, CAST(N'2016-04-10T22:16:18.000' AS DateTime), CAST(N'2016-04-15T15:32:19.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 22, CAST(N'2001-06-17T10:03:56.000' AS DateTime), CAST(N'2001-06-28T16:27:33.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (7, 26, CAST(N'2011-02-09T19:50:10.000' AS DateTime), CAST(N'2011-02-10T12:29:27.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 4, CAST(N'2011-05-01T17:23:43.000' AS DateTime), CAST(N'2011-05-06T17:03:48.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 5, CAST(N'2015-05-03T05:00:52.000' AS DateTime), CAST(N'2015-05-14T03:59:35.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 6, CAST(N'2002-06-11T01:42:42.000' AS DateTime), CAST(N'2002-06-21T13:16:36.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 8, CAST(N'2001-02-08T11:27:15.000' AS DateTime), CAST(N'2001-02-20T13:38:17.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 12, CAST(N'2001-11-13T16:17:22.000' AS DateTime), CAST(N'2001-11-26T19:50:34.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 18, CAST(N'2012-08-10T22:48:34.000' AS DateTime), CAST(N'2012-08-19T16:42:47.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 19, CAST(N'2009-11-04T06:25:29.000' AS DateTime), CAST(N'2009-11-04T22:50:41.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (8, 28, CAST(N'2002-04-09T11:05:13.000' AS DateTime), CAST(N'2002-04-21T19:16:31.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (9, 2, CAST(N'2016-11-09T22:57:28.000' AS DateTime), CAST(N'2016-11-22T17:42:32.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (9, 5, CAST(N'2014-11-27T01:21:19.000' AS DateTime), CAST(N'2014-12-11T19:01:39.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (9, 5, CAST(N'2015-02-21T10:20:00.000' AS DateTime), CAST(N'2015-02-24T10:20:00.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (9, 8, CAST(N'2012-02-09T22:13:10.000' AS DateTime), CAST(N'2012-02-19T19:41:34.000' AS DateTime))
GO
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (9, 10, CAST(N'2016-09-17T04:04:30.000' AS DateTime), CAST(N'2016-09-29T19:39:57.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (9, 16, CAST(N'2011-02-25T08:53:00.000' AS DateTime), CAST(N'2011-03-01T09:13:23.000' AS DateTime))
INSERT [dbo].[historico_prestamos] ([id_lec_his], [id_lib_his], [fecha_presta_his], [fecha_devol_his]) VALUES (9, 28, CAST(N'2016-01-04T13:38:00.000' AS DateTime), CAST(N'2016-01-12T09:56:37.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[lectores] ON 

INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (1, N'García Ruiz, Francisco                            ', N'C/ El Molino, 34 8º A                             ', 13, N'ggrd@gmail.com                                    ', CAST(N'1990-10-10' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (2, N'Ruiz Gil, Franciso José                           ', N'C/ Mayor, 63 1º                                   ', 32, N'raguil@gmail.com                                  ', CAST(N'2000-01-23' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (3, N'Carmona Ruiz, Adolfo                              ', N'C/ Rio rojo, 32                                   ', 43, N'crsa@yahoo.es                                     ', CAST(N'2004-03-01' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (4, N'Perez Gimenez, Antonia                            ', N'Paseo Zorrilla, 34 8º D                           ', 47, N'pepepepe@gmail.com                                ', CAST(N'1998-02-05' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (5, N'Hernandez Pol, Luisa                              ', N'C/ Encarnación, 23 1º                             ', 5, N'Hern232@gmail.com                                 ', CAST(N'1978-06-02' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (6, N'Ramón Diez, Federico                              ', N'C/ Pasión, 3                                      ', 47, N'ramon3s@gmail.com                                 ', CAST(N'1999-05-05' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (7, N'Rodriguez Duque, Roberto                          ', N'C/ Pórtico, sn                                    ', 42, N'asoro@gmail.com                                   ', CAST(N'2010-04-12' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (8, N'Alvarez Bueno, José                               ', N'C/ Canario, 34 3º                                 ', 14, N'albu35@hotmail.com                                ', CAST(N'2005-12-04' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (9, N'Frances Hernandez, Raquel                         ', N'C/ Pamplona, 43                                   ', 34, N'franherann@gmail.com                              ', CAST(N'2004-10-05' AS Date), NULL)
INSERT [dbo].[lectores] ([id_lec], [nombre_lec], [domicilio_lec], [provincia_lec], [email_lec], [fecha_nacimiento_lec], [fecha_penalizacion_lec]) VALUES (10, N'Garcia Rodriguez, Asunción                        ', N'C/ Candeal, 63                                    ', 3, N'gargaga@gmail.com                                 ', CAST(N'2006-02-28' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[lectores] OFF
SET IDENTITY_INSERT [dbo].[libros] ON 

INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (1, N'El camino                                         ', N'Miguel Delibes                                    ', 1, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (2, N'Las Ratas                                         ', N'Miguel Delibes                                    ', 2, N'S')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (3, N'El Quijote                                        ', N'Miguel de Cervantes                               ', 3, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (4, N'Poemas de Castilla                                ', N'Antonio Machado                                   ', 4, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (5, N'El Buscón                                         ', N'Francisco de Quevedo                              ', 2, N'S')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (6, N'La Celestina                                      ', N'Fernando de Rojas                                 ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (7, N'Queda la Noche                                    ', N'Soledad Puértolas                                 ', 4, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (8, N'La flor de mi secreteo                            ', N'Antonio Gala                                      ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (9, N'El Castillo                                       ', N'Franz Kafka                                       ', 1, N'S')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (10, N'La vida es sueño                                 ', N'Calderón de la Barca                              ', 1, N'S')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (11, N'Campos de Castilla                                ', N'Antonio Machado                                   ', 1, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (12, N'La familia de Pascual Duarte                      ', N'Camilo José Cela                                  ', 3, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (13, N'Cinco horas con Mario                             ', N'Miguel Delibes                                    ', 4, N'S')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (14, N'La hoja roja                                      ', N'Miguel Delibes                                    ', 4, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (15, N'Todos los cuentos                                 ', N'Edgar Allan Poe                                   ', 3, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (16, N'Cuentos                                           ', N'Julio Cortazar                                    ', 3, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (17, N'El mar y las campanas                             ', N'Pablo Neruda                                      ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (18, N'Odas Elementales                                  ', N'Pablo Neruda                                      ', 4, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (19, N'Siete cuentos góticos                             ', N'Isak Deniessen                                    ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (20, N'El extranjero                                     ', N'Albert Camus                                      ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (21, N'El criticón                                       ', N'Baltasar Gracián                                  ', 1, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (22, N'Don Juan Tenorio                                  ', N'José Zorrilla                                     ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (23, N'Don Julián                                        ', N'Juan Goytisolo                                    ', 3, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (24, N'Los tres mosqueteros                              ', N'Añexandre Dumas                                   ', 4, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (25, N'Vivir para contarla                               ', N'Gabriel García Marquez                            ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (26, N'El paraiso en la otra esquina                     ', N'Mario Vargas Llosa                                ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (27, N'Veinte años y un día                              ', N'Jorge Sremprún                                    ', 3, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (28, N'El libro de las ilusiones                         ', N'Paul Auster                                       ', 2, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (29, N'Corazón tan blanco                                ', N'Javier Marías                                     ', 1, N'N')
INSERT [dbo].[libros] ([id_lib], [titulo_lib], [autor_lib], [seccion_lib], [prestado_sn_lib]) VALUES (30, N'Artificios                                        ', N'Jorge Luis Borges                                 ', 1, N'N')
SET IDENTITY_INSERT [dbo].[libros] OFF
INSERT [dbo].[prestamos] ([id_lec_pre], [id_lib_pre], [fecha_presta_pre], [fecha_devol_pre]) VALUES (1, 2, CAST(N'2019-02-01T13:20:00.000' AS DateTime), CAST(N'2019-02-16T13:20:00.000' AS DateTime))
INSERT [dbo].[prestamos] ([id_lec_pre], [id_lib_pre], [fecha_presta_pre], [fecha_devol_pre]) VALUES (4, 5, CAST(N'2019-01-03T12:00:00.000' AS DateTime), CAST(N'2019-01-18T12:00:00.000' AS DateTime))
INSERT [dbo].[prestamos] ([id_lec_pre], [id_lib_pre], [fecha_presta_pre], [fecha_devol_pre]) VALUES (5, 9, CAST(N'2019-01-10T10:27:00.000' AS DateTime), CAST(N'2019-01-25T10:27:00.000' AS DateTime))
INSERT [dbo].[prestamos] ([id_lec_pre], [id_lib_pre], [fecha_presta_pre], [fecha_devol_pre]) VALUES (5, 13, CAST(N'2019-01-02T18:45:00.000' AS DateTime), CAST(N'2019-01-17T18:45:00.000' AS DateTime))
INSERT [dbo].[prestamos] ([id_lec_pre], [id_lib_pre], [fecha_presta_pre], [fecha_devol_pre]) VALUES (8, 10, CAST(N'2019-01-05T15:00:00.000' AS DateTime), CAST(N'2019-01-20T15:00:00.000' AS DateTime))
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (1, N'Alava                                             ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (2, N'Albacete                                          ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (3, N'Alicante/Alacant                                  ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (4, N'Almería                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (5, N'Avila                                             ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (6, N'Badajoz                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (7, N'Baleares                                          ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (8, N'Barcelona                                         ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (9, N'Burgos                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (10, N'Cáceres                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (11, N'Cádiz                                             ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (12, N'vallaodlid                                        ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (13, N'Ciudad Real                                       ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (14, N'Córdoba                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (15, N'La Coruña                                         ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (16, N'Cuenca                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (17, N'Girona (Gerona)                                   ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (18, N'Granada                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (19, N'Guadalajara                                       ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (20, N'Guipúzcoa                                         ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (21, N'Huelva                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (22, N'Huesca                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (23, N'Jaen                                              ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (24, N'León                                              ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (25, N'Lérida                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (26, N'Logroño                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (27, N'Lugo                                              ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (28, N'Madrid                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (29, N'Málaga                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (30, N'Murcia                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (31, N'Navarra                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (32, N'Ourense (Orense)                                  ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (33, N'P. Asturias                                       ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (34, N'Palencia                                          ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (35, N'Las Palmas                                        ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (36, N'Pontevedra                                        ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (37, N'Salamanca                                         ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (38, N'Sta. Cruz Tenerife                                ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (39, N'Santander                                         ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (40, N'Segovia                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (41, N'Sevilla                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (42, N'Soria                                             ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (43, N'Tarragona                                         ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (44, N'Teruel                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (45, N'Toledo                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (46, N'Valencia                                          ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (47, N'Valladolid                                        ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (48, N'Vizcaya                                           ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (49, N'Zamora                                            ')
INSERT [dbo].[provincias] ([id_pro], [provincia_pro]) VALUES (50, N'Zaragoza                                          ')
INSERT [dbo].[secciones] ([id_sec], [seccion_sec]) VALUES (1, N'Sección A                                         ')
INSERT [dbo].[secciones] ([id_sec], [seccion_sec]) VALUES (2, N'Sección B                                         ')
INSERT [dbo].[secciones] ([id_sec], [seccion_sec]) VALUES (3, N'Sección C                                         ')
INSERT [dbo].[secciones] ([id_sec], [seccion_sec]) VALUES (4, N'Sección D                                         ')
INSERT [dbo].[usuarios] ([nombre_usu], [password_usu], [tipo_usu]) VALUES (N'admin               ', N'admin               ', N'A')
INSERT [dbo].[usuarios] ([nombre_usu], [password_usu], [tipo_usu]) VALUES (N'lector              ', N'lector              ', N'L')
INSERT [dbo].[usuarios] ([nombre_usu], [password_usu], [tipo_usu]) VALUES (N'operador            ', N'operador            ', N'O')
ALTER TABLE [dbo].[configuracion]  WITH CHECK ADD  CONSTRAINT [FK_configuracion_provincias] FOREIGN KEY([provincia_cnf])
REFERENCES [dbo].[provincias] ([id_pro])
GO
ALTER TABLE [dbo].[configuracion] CHECK CONSTRAINT [FK_configuracion_provincias]
GO
ALTER TABLE [dbo].[historico_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_historico_prestamos_lectores] FOREIGN KEY([id_lec_his])
REFERENCES [dbo].[lectores] ([id_lec])
GO
ALTER TABLE [dbo].[historico_prestamos] CHECK CONSTRAINT [FK_historico_prestamos_lectores]
GO
ALTER TABLE [dbo].[historico_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_historico_prestamos_libros] FOREIGN KEY([id_lib_his])
REFERENCES [dbo].[libros] ([id_lib])
GO
ALTER TABLE [dbo].[historico_prestamos] CHECK CONSTRAINT [FK_historico_prestamos_libros]
GO
ALTER TABLE [dbo].[lectores]  WITH CHECK ADD  CONSTRAINT [FK_lectores_provincias] FOREIGN KEY([provincia_lec])
REFERENCES [dbo].[provincias] ([id_pro])
GO
ALTER TABLE [dbo].[lectores] CHECK CONSTRAINT [FK_lectores_provincias]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_secciones] FOREIGN KEY([seccion_lib])
REFERENCES [dbo].[secciones] ([id_sec])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_secciones]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_lectores] FOREIGN KEY([id_lec_pre])
REFERENCES [dbo].[lectores] ([id_lec])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_lectores]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_libros] FOREIGN KEY([id_lib_pre])
REFERENCES [dbo].[libros] ([id_lib])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_libros]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "libros"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 138
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prestamos"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 150
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'LibrosPrestados'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'LibrosPrestados'
GO
USE [master]
GO
ALTER DATABASE [BibliotecaJM] SET  READ_WRITE 
GO

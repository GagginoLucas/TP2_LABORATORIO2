USE [master]
GO
/****** Object:  Database [TP2_DB]    Script Date: 29/11/2022 12:45:39 ******/
CREATE DATABASE [TP2_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP2_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP2_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP2_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP2_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP2_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP2_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP2_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP2_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP2_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP2_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP2_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP2_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP2_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP2_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP2_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP2_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP2_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP2_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP2_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP2_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP2_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP2_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP2_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP2_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP2_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP2_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP2_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP2_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP2_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [TP2_DB] SET  MULTI_USER 
GO
ALTER DATABASE [TP2_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP2_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP2_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP2_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP2_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP2_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP2_DB', N'ON'
GO
ALTER DATABASE [TP2_DB] SET QUERY_STORE = OFF
GO
USE [TP2_DB]
GO
/****** Object:  Table [dbo].[Administradores]    Script Date: 29/11/2022 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administradores](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administradores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 29/11/2022 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[PartidasGanadas] [int] NOT NULL,
	[PartidasJugadas] [int] NOT NULL,
	[PartidasPerdidas] [int] NOT NULL,
	[CantidadDeAnchosDeEspada] [int] NOT NULL,
	[CantidadDeAnchosDeBasto] [int] NOT NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partidas]    Script Date: 29/11/2022 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partidas](
	[Ganador] [varchar](50) NOT NULL,
	[Perdedor] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Administradores] ([ID], [Nombre], [Apellido], [Usuario], [Contraseña]) VALUES (1, N'pepe', N'pepe', N'pepe', N'pepe')
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (1, N'Morena', N'Escudero', N'Richard', 8, 12, 4, 8, 9)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (2, N'Nicolas', N'Barrozo', N'addq', 10, 18, 8, 10, 6)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (3, N'Luki', N'Gaggino', N'Messi', 5, 11, 6, 6, 7)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (4, N'Nico', N'Gil', N'Nico', 10, 23, 13, 11, 8)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (7, N'Florencia', N'Caruso', N'Florca', 2, 6, 4, 8, 10)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (8, N'Mario', N'Pergolini', N'Maritopergolini', 5, 9, 4, 11, 8)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (9, N'Mariana', N'Gutierrez', N'Marianita', 8, 9, 1, 2, 1)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (10, N'Carlos', N'Menem', N'Ferrari', 5, 16, 11, 7, 10)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (1007, N'Morena', N'Escupidero', N'sensei', 2, 2, 0, 2, 2)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (1008, N'Tyler', N'Lefleur', N'TheCreator', 1, 2, 1, 2, 1)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (1009, N'Tomas', N'Sanchez', N'amargoYretruco', 3, 6, 3, 11, 9)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas], [CantidadDeAnchosDeEspada], [CantidadDeAnchosDeBasto]) VALUES (1010, N'Luisito', N'Comunica', N'luis', 2, 4, 2, 9, 8)
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-20T17:44:29.287' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-20T17:59:36.170' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Richard', N'Messi', CAST(N'2022-11-20T18:10:07.510' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-20T18:14:18.177' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-20T19:09:52.527' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Messi', CAST(N'2022-11-20T19:10:09.027' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Richard', N'addq', CAST(N'2022-11-20T19:16:38.327' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Messi', N'addq', CAST(N'2022-11-23T16:07:46.570' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Messi', N'addq', CAST(N'2022-11-23T16:09:21.360' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Messi', N'addq', CAST(N'2022-11-28T17:06:44.883' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Messi', N'addq', CAST(N'2022-11-28T17:09:40.223' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-28T17:10:07.667' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Florca', N'Nico', CAST(N'2022-11-28T17:13:20.493' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Florca', N'Nico', CAST(N'2022-11-28T17:17:04.100' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Maritopergolini', N'Florca', CAST(N'2022-11-28T17:21:34.347' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Ferrari', N'Messi', CAST(N'2022-11-28T17:23:22.153' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Maritopergolini', CAST(N'2022-11-29T09:45:52.657' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Maritopergolini', CAST(N'2022-11-29T09:46:16.747' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Maritopergolini', N'Ferrari', CAST(N'2022-11-24T00:17:12.123' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'amargoYretruco', N'TheCreator', CAST(N'2022-11-29T10:23:24.587' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'TheCreator', N'amargoYretruco', CAST(N'2022-11-29T10:24:04.993' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'amargoYretruco', N'luis', CAST(N'2022-11-29T11:37:19.347' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'amargoYretruco', N'luis', CAST(N'2022-11-29T11:37:46.360' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'luis', N'amargoYretruco', CAST(N'2022-11-29T11:38:03.100' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Richard', N'addq', CAST(N'2022-11-29T11:43:30.720' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'sensei', N'Maritopergolini', CAST(N'2022-11-29T11:43:36.407' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'luis', N'amargoYretruco', CAST(N'2022-11-29T11:43:40.950' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Nico', N'Ferrari', CAST(N'2022-11-29T11:45:16.267' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Maritopergolini', N'Florca', CAST(N'2022-11-29T11:46:43.753' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Richard', N'addq', CAST(N'2022-11-29T11:31:29.913' AS DateTime))
GO
USE [master]
GO
ALTER DATABASE [TP2_DB] SET  READ_WRITE 
GO

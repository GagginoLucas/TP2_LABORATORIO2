USE [master]
GO
/****** Object:  Database [TP2_DB]    Script Date: 20/11/2022 18:21:39 ******/
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
/****** Object:  Table [dbo].[Administradores]    Script Date: 20/11/2022 18:21:40 ******/
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
/****** Object:  Table [dbo].[Jugadores]    Script Date: 20/11/2022 18:21:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[PartidasGanadas] [int] NOT NULL,
	[PartidasJugadas] [int] NOT NULL,
	[PartidasPerdidas] [int] NOT NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partidas]    Script Date: 20/11/2022 18:21:40 ******/
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
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas]) VALUES (1, N'Morena', N'Escudero', N'Richard', 20, 23, 17)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas]) VALUES (2, N'Nicolas', N'Barrozo', N'addq', 22, 19, 13)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas]) VALUES (3, N'Luki', N'Gaggino', N'Messi', 5, 7, 2)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas]) VALUES (4, N'Nico', N'Gil', N'nico', 1, 1, 0)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas]) VALUES (5, N'asdf', N'agasdfg', N'ysy a', 0, 1, 1)
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Apellido], [Usuario], [PartidasGanadas], [PartidasJugadas], [PartidasPerdidas]) VALUES (6, N'kfgkf', N'fkfk', N'dukio', 0, 0, 0)
GO
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-20T17:44:29.287' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-20T17:59:36.170' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'Richard', N'Messi', CAST(N'2022-11-20T18:10:07.510' AS DateTime))
INSERT [dbo].[Partidas] ([Ganador], [Perdedor], [Fecha]) VALUES (N'addq', N'Richard', CAST(N'2022-11-20T18:14:18.177' AS DateTime))
GO
USE [master]
GO
ALTER DATABASE [TP2_DB] SET  READ_WRITE 
GO

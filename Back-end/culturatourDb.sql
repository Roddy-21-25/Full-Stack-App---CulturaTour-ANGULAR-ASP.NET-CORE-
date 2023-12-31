USE [master]
GO
/****** Object:  Database [SegurityCulturaTourDb]    Script Date: 9/19/2023 3:13:40 PM ******/
CREATE DATABASE [SegurityCulturaTourDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SegurityCulturaTourDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SegurityCulturaTourDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SegurityCulturaTourDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SegurityCulturaTourDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SegurityCulturaTourDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SegurityCulturaTourDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SegurityCulturaTourDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET RECOVERY FULL 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET  MULTI_USER 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SegurityCulturaTourDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SegurityCulturaTourDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SegurityCulturaTourDb', N'ON'
GO
ALTER DATABASE [SegurityCulturaTourDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [SegurityCulturaTourDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SegurityCulturaTourDb]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 9/19/2023 3:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EmailLogin] [varchar](100) NOT NULL,
	[PasswordLogin] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignUpUser]    Script Date: 9/19/2023 3:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignUpUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[EmailSignUp] [varchar](100) NOT NULL,
	[PasswordSignUp] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoginUser] ON 

INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (1, N'Roddy3889@gmail.com', N'12345')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (2, N'Rafael12345@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (3, N'roddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (4, N'nuevo@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (5, N'nuevoRoddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (6, N'roddy21252@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
SET IDENTITY_INSERT [dbo].[LoginUser] OFF
GO
SET IDENTITY_INSERT [dbo].[SignUpUser] ON 

INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (1, N'Roddy R.', N'Rafael Tejeda', N'Rody3889@gmai.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (2, N'Rafael R.', N'Tejeda R.', N'Rafael12345@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (3, N'roddy', N'rafael', N'roddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (4, N'nuevo', N'prueba', N'nuevo@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (5, N'Roddy', N'nuevo', N'nuevoRoddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (6, N'Roddy2', N'nuevo', N'roddy21252@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
SET IDENTITY_INSERT [dbo].[SignUpUser] OFF
GO
USE [master]
GO
ALTER DATABASE [SegurityCulturaTourDb] SET  READ_WRITE 
GO

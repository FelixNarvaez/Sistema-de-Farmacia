USE [master]
GO
/****** Object:  Database [AppNet7SisFarma]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE DATABASE [AppNet7SisFarma]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppNet7SisFarma', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.FELIXGARCIA\MSSQL\DATA\AppNet7SisFarma.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppNet7SisFarma_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.FELIXGARCIA\MSSQL\DATA\AppNet7SisFarma_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AppNet7SisFarma] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppNet7SisFarma].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppNet7SisFarma] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppNet7SisFarma] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppNet7SisFarma] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AppNet7SisFarma] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppNet7SisFarma] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [AppNet7SisFarma] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET RECOVERY FULL 
GO
ALTER DATABASE [AppNet7SisFarma] SET  MULTI_USER 
GO
ALTER DATABASE [AppNet7SisFarma] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppNet7SisFarma] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppNet7SisFarma] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppNet7SisFarma] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppNet7SisFarma] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppNet7SisFarma] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AppNet7SisFarma', N'ON'
GO
ALTER DATABASE [AppNet7SisFarma] SET QUERY_STORE = OFF
GO
USE [AppNet7SisFarma]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[DescripcionCategoria] [nvarchar](50) NOT NULL,
	[Laboratorio] [nvarchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Precio] [nvarchar](max) NOT NULL,
	[FechaCompra] [datetime2](7) NULL,
	[Cantidad] [int] NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[LaboratorioId] [int] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[ApellidoPaterno] [nvarchar](50) NOT NULL,
	[ApellidoMaterno] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laboratorio]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratorio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Laboratorio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[ViaAdministracion] [nvarchar](50) NOT NULL,
	[FechaVencimiento] [datetime2](7) NULL,
	[CategoriaId] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usario]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Clave] [nvarchar](max) NOT NULL,
	[ConfirmarClave] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaVenta] [datetime2](7) NULL,
	[CategoriaId] [int] NOT NULL,
	[MedicamentoId] [int] NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[Precio] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Compra_CategoriaId]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Compra_CategoriaId] ON [dbo].[Compra]
(
	[CategoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Compra_EmpleadoId]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Compra_EmpleadoId] ON [dbo].[Compra]
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Compra_LaboratorioId]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Compra_LaboratorioId] ON [dbo].[Compra]
(
	[LaboratorioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Medicamento_CategoriaId]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Medicamento_CategoriaId] ON [dbo].[Medicamento]
(
	[CategoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_CategoriaId]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Venta_CategoriaId] ON [dbo].[Venta]
(
	[CategoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_EmpleadoId]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Venta_EmpleadoId] ON [dbo].[Venta]
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_MedicamentoId]    Script Date: 8/12/2022 2:57:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_Venta_MedicamentoId] ON [dbo].[Venta]
(
	[MedicamentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT (N'') FOR [DescripcionCategoria]
GO
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT (N'') FOR [Laboratorio]
GO
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Estado]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Estado]
GO
ALTER TABLE [dbo].[Laboratorio] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Estado]
GO
ALTER TABLE [dbo].[Medicamento] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Estado]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Categoria_CategoriaId] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Categoria_CategoriaId]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Empleado_EmpleadoId] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleado] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Empleado_EmpleadoId]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Laboratorio_LaboratorioId] FOREIGN KEY([LaboratorioId])
REFERENCES [dbo].[Laboratorio] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Laboratorio_LaboratorioId]
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD  CONSTRAINT [FK_Medicamento_Categoria_CategoriaId] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medicamento] CHECK CONSTRAINT [FK_Medicamento_Categoria_CategoriaId]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Categoria_CategoriaId] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Categoria_CategoriaId]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado_EmpleadoId] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleado] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleado_EmpleadoId]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Medicamento_MedicamentoId] FOREIGN KEY([MedicamentoId])
REFERENCES [dbo].[Medicamento] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Medicamento_MedicamentoId]
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCategoria]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_EliminarCategoria]
@id_Categoria int


as
begin

delete from Categoria   where id = @id_Categoria
end

GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCompra]    Script Date: 8/12/2022 2:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_EliminarCompra](
@cod_Compra int
)

as
begin

delete from Compra   where ID = @cod_Compra
end

GO
USE [master]
GO
ALTER DATABASE [AppNet7SisFarma] SET  READ_WRITE 
GO

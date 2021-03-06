﻿/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2014 (12.0.5207)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [ClientManagerDb]    Script Date: 10/25/2017 11:11:42 AM ******/
CREATE DATABASE [ClientManagerDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClientManagerDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ClientManagerDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ClientManagerDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ClientManagerDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ClientManagerDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClientManagerDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClientManagerDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClientManagerDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClientManagerDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClientManagerDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClientManagerDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClientManagerDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClientManagerDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClientManagerDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClientManagerDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClientManagerDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClientManagerDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClientManagerDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClientManagerDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClientManagerDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClientManagerDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClientManagerDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClientManagerDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClientManagerDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClientManagerDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClientManagerDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClientManagerDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClientManagerDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClientManagerDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ClientManagerDb] SET  MULTI_USER 
GO
ALTER DATABASE [ClientManagerDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClientManagerDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClientManagerDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClientManagerDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ClientManagerDb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ClientManagerDb]
GO
/****** Object:  Table [dbo].[ClientAddress]    Script Date: 10/25/2017 11:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientAddress](
	[addressId] [int] IDENTITY(1,1) NOT NULL,
	[resAddress] [varchar](50) NOT NULL,
	[workAddress] [varchar](50) NOT NULL,
	[posAddress] [varchar](50) NOT NULL,
	
	[clientId] [int] NOT NULL,
 CONSTRAINT [PK_ClientAddress] PRIMARY KEY CLUSTERED 
(
	[addressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientContact]    Script Date: 10/25/2017 11:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientContact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[cellNumber] [varchar](50) NOT NULL,
	[workTel] [varchar](50) NOT NULL,
	[clientId] [int] NOT NULL,
 CONSTRAINT [PK_ClientContact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientDetails]    Script Date: 10/25/2017 11:11:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientDetails](
	[clientId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ClientDetails] PRIMARY KEY CLUSTERED 
(
	[clientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClientAddress]  WITH CHECK ADD  CONSTRAINT [fk_category] FOREIGN KEY([clientId])
REFERENCES [dbo].[ClientDetails] ([clientId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientAddress] CHECK CONSTRAINT [fk_category]
GO
ALTER TABLE [dbo].[ClientContact]  WITH CHECK ADD  CONSTRAINT [fk_client_contact] FOREIGN KEY([clientId])
REFERENCES [dbo].[ClientDetails] ([clientId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientContact] CHECK CONSTRAINT [fk_client_contact]
GO
USE [master]
GO
ALTER DATABASE [ClientManagerDb] SET  READ_WRITE 
GO

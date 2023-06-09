USE [master]
GO

/****** Object:  Database [CurrentDb]    Script Date: 20.04.2023 07:07:29 ******/
CREATE DATABASE [CurrentDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CurrentDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CurrentDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CurrentDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CurrentDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CurrentDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CurrentDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CurrentDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CurrentDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CurrentDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CurrentDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [CurrentDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CurrentDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CurrentDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CurrentDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CurrentDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CurrentDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CurrentDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CurrentDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CurrentDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CurrentDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CurrentDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CurrentDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CurrentDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CurrentDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CurrentDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CurrentDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CurrentDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CurrentDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [CurrentDb] SET  MULTI_USER 
GO

ALTER DATABASE [CurrentDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CurrentDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CurrentDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CurrentDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [CurrentDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CurrentDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [CurrentDb] SET QUERY_STORE = OFF
GO

ALTER DATABASE [CurrentDb] SET  READ_WRITE 
GO


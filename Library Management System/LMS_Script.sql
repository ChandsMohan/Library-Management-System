USE [master]
GO
/****** Object:  Database [Library_Management]    Script Date: 12/30/2005 17:18:31 ******/
CREATE DATABASE [Library_Management] ON  PRIMARY 
( NAME = N'Library_Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Library_Management.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Library_Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Library_Management_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Library_Management] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library_Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library_Management] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Library_Management] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Library_Management] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Library_Management] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Library_Management] SET ARITHABORT OFF
GO
ALTER DATABASE [Library_Management] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Library_Management] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Library_Management] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Library_Management] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Library_Management] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Library_Management] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Library_Management] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Library_Management] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Library_Management] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Library_Management] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Library_Management] SET  DISABLE_BROKER
GO
ALTER DATABASE [Library_Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Library_Management] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Library_Management] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Library_Management] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Library_Management] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Library_Management] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Library_Management] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Library_Management] SET  READ_WRITE
GO
ALTER DATABASE [Library_Management] SET RECOVERY FULL
GO
ALTER DATABASE [Library_Management] SET  MULTI_USER
GO
ALTER DATABASE [Library_Management] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Library_Management] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Library_Management', N'ON'
GO
USE [Library_Management]
GO
/****** Object:  Table [dbo].[tbl_BooksInfo]    Script Date: 12/30/2005 17:18:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BooksInfo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](max) NOT NULL,
	[Author] [nvarchar](max) NOT NULL,
	[Edition] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[AvailableBooks] [bigint] NOT NULL,
	[TotalBooks] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_BooksInfo] ON
INSERT [dbo].[tbl_BooksInfo] ([Id], [BookName], [Author], [Edition], [Status], [AvailableBooks], [TotalBooks]) VALUES (1, N'Physics', N'R K Jain', N'3 Edition', 1, 3, 3)
INSERT [dbo].[tbl_BooksInfo] ([Id], [BookName], [Author], [Edition], [Status], [AvailableBooks], [TotalBooks]) VALUES (2, N'Chemistry', N'R K Swami', N'4 Edition', 1, 5, 5)
INSERT [dbo].[tbl_BooksInfo] ([Id], [BookName], [Author], [Edition], [Status], [AvailableBooks], [TotalBooks]) VALUES (3, N'Math', N'Bhattachary', N'6 Edition', 1, 5, 5)
INSERT [dbo].[tbl_BooksInfo] ([Id], [BookName], [Author], [Edition], [Status], [AvailableBooks], [TotalBooks]) VALUES (4, N'Math', N'Bhattachary', N'2 Edition', 1, 6, 6)
INSERT [dbo].[tbl_BooksInfo] ([Id], [BookName], [Author], [Edition], [Status], [AvailableBooks], [TotalBooks]) VALUES (5, N'Math', N'Aanand Sharma', N'5 Edition', 1, 1, 2)
INSERT [dbo].[tbl_BooksInfo] ([Id], [BookName], [Author], [Edition], [Status], [AvailableBooks], [TotalBooks]) VALUES (6, N'Math', N'R K Swami', N'4 Edition', 1, 5, 5)
SET IDENTITY_INSERT [dbo].[tbl_BooksInfo] OFF
/****** Object:  Table [dbo].[tbl_BookIssued]    Script Date: 12/30/2005 17:18:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BookIssued](
	[Student_Id] [nvarchar](max) NOT NULL,
	[BookName] [nvarchar](max) NOT NULL,
	[Author] [nvarchar](max) NOT NULL,
	[Edition] [nvarchar](max) NOT NULL,
	[DateTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_BookIssued] ([Student_Id], [BookName], [Author], [Edition], [DateTime]) VALUES (N'STUREG001', N'Math', N'Aanand Sharma', N'5 Edition', CAST(0x0000973A010163F1 AS DateTime))
/****** Object:  Table [dbo].[tbl_BookIssue_Return]    Script Date: 12/30/2005 17:18:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BookIssue_Return](
	[Student_Id] [nvarchar](max) NOT NULL,
	[BookName] [nvarchar](max) NOT NULL,
	[Author] [nvarchar](max) NOT NULL,
	[Edition] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[DateTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_BookIssue_Return] ([Student_Id], [BookName], [Author], [Edition], [Status], [DateTime]) VALUES (N'STUREG001', N'Math', N'Aanand Sharma', N'5 Edition', N'Issued', CAST(0x0000973A010163F2 AS DateTime))
/****** Object:  Table [dbo].[tbl_AdminLogin]    Script Date: 12/30/2005 17:18:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_AdminLogin](
	[AdminId] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[LastLogin] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_AdminLogin] ([AdminId], [Password], [LastLogin]) VALUES (N'Admin1', N'Admin1', CAST(0x0000973200AB82E7 AS DateTime))
INSERT [dbo].[tbl_AdminLogin] ([AdminId], [Password], [LastLogin]) VALUES (N'Admin2', N'Admin2', CAST(0x0000973200ABD8D3 AS DateTime))
INSERT [dbo].[tbl_AdminLogin] ([AdminId], [Password], [LastLogin]) VALUES (N'a', N'a', CAST(0x00009739011A7FEC AS DateTime))
INSERT [dbo].[tbl_AdminLogin] ([AdminId], [Password], [LastLogin]) VALUES (N'b', N'b', CAST(0x0000973200ABF09C AS DateTime))
/****** Object:  Default [DF_tbl_BookIssued_DateTime]    Script Date: 12/30/2005 17:18:31 ******/
ALTER TABLE [dbo].[tbl_BookIssued] ADD  CONSTRAINT [DF_tbl_BookIssued_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
/****** Object:  Default [DF_tbl_BookIssue_Return_DateTime]    Script Date: 12/30/2005 17:18:31 ******/
ALTER TABLE [dbo].[tbl_BookIssue_Return] ADD  CONSTRAINT [DF_tbl_BookIssue_Return_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
/****** Object:  Default [DF_tbl_AdminLogin_LastLogin]    Script Date: 12/30/2005 17:18:31 ******/
ALTER TABLE [dbo].[tbl_AdminLogin] ADD  CONSTRAINT [DF_tbl_AdminLogin_LastLogin]  DEFAULT (getdate()) FOR [LastLogin]
GO

USE [master]
GO
/****** Object:  Database [sfcontractservice_db]    Script Date: 11/5/2018 4:48:41 PM ******/
CREATE DATABASE [sfcontractservice_db]
GO
ALTER DATABASE [sfcontractservice_db] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sfcontractservice_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sfcontractservice_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sfcontractservice_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [sfcontractservice_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sfcontractservice_db] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [sfcontractservice_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET  MULTI_USER 
GO
ALTER DATABASE [sfcontractservice_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sfcontractservice_db] SET ENCRYPTION ON
GO
ALTER DATABASE [sfcontractservice_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [sfcontractservice_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
USE [sfcontractservice_db]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 11/5/2018 4:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContractNo] [nvarchar](25) NOT NULL,
	[ContractDate] [datetime2](7) NOT NULL,
	[ContractOrganization] [nvarchar](max) NULL,
	[ContractType] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractItem]    Script Date: 11/5/2018 4:48:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[ContractId] [int] NOT NULL,
 CONSTRAINT [PK_ContractItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 11/5/2018 4:48:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sku] [nvarchar](25) NOT NULL,
	[Description] [nvarchar](300) NULL,
	[ListCost] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractItem_ContractId]    Script Date: 11/5/2018 4:48:47 PM ******/
CREATE NONCLUSTERED INDEX [IX_ContractItem_ContractId] ON [dbo].[ContractItem]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContractItem]  WITH CHECK ADD  CONSTRAINT [FK_ContractItem_Contract_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contract] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContractItem] CHECK CONSTRAINT [FK_ContractItem_Contract_ContractId]
GO
USE [master]
GO
ALTER DATABASE [sfcontractservice_db] SET  READ_WRITE 
GO

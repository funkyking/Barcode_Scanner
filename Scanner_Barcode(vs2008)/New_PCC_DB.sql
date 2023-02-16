USE [master]
GO
/****** Object:  Database [PCC]    Script Date: 2/13/2023 4:44:31 PM ******/
CREATE DATABASE [PCC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PCC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQL\DATA\PCC.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PCC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQL\DATA\PCC_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PCC] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PCC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PCC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PCC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PCC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PCC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PCC] SET ARITHABORT OFF 
GO
ALTER DATABASE [PCC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PCC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PCC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PCC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PCC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PCC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PCC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PCC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PCC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PCC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PCC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PCC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PCC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PCC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PCC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PCC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PCC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PCC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PCC] SET  MULTI_USER 
GO
ALTER DATABASE [PCC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PCC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PCC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PCC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PCC] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PCC]
GO
/****** Object:  Table [dbo].[ActivityLog]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityLog](
	[ActivityLogID] [uniqueidentifier] NOT NULL,
	[LogType] [nvarchar](20) NOT NULL,
	[TxnDate] [datetime] NOT NULL,
	[PCName] [nvarchar](200) NOT NULL,
	[Remark] [nvarchar](1000) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [ActivityLog_PK] PRIMARY KEY CLUSTERED 
(
	[ActivityLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Line]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Line](
	[LineID] [uniqueidentifier] NOT NULL,
	[LineCode] [nvarchar](20) NOT NULL,
	[LineGroupID] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [Line_PK] PRIMARY KEY CLUSTERED 
(
	[LineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LineDetail]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineDetail](
	[LineDetailID] [uniqueidentifier] NOT NULL,
	[LineID] [uniqueidentifier] NOT NULL,
	[Efficiency] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [LineDetail_PK] PRIMARY KEY CLUSTERED 
(
	[LineDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LineGroup]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineGroup](
	[LineGroupID] [uniqueidentifier] NOT NULL,
	[GroupCode] [nvarchar](20) NOT NULL,
	[GroupDesc] [nvarchar](100) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [LineGroup_PK] PRIMARY KEY CLUSTERED 
(
	[LineGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterBOM]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterBOM](
	[MasterBOMId] [uniqueidentifier] NOT NULL,
	[AssemblyRef] [nvarchar](max) NULL,
	[PartID] [uniqueidentifier] NOT NULL,
	[OrPartID1] [uniqueidentifier] NULL,
	[OrPartID2] [uniqueidentifier] NULL,
	[OrPartID3] [uniqueidentifier] NULL,
	[MasterModelID] [uniqueidentifier] NULL,
	[ModelID] [uniqueidentifier] NULL,
	[LineID] [uniqueidentifier] NULL,
	[MasterStationId] [uniqueidentifier] NULL,
	[Insertion] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL CONSTRAINT [DF_MasterBOM_Active]  DEFAULT (N'Y')
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterModel]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterModel](
	[MasterModelID] [uniqueidentifier] NOT NULL,
	[MasterModelCode] [nvarchar](20) NOT NULL,
	[ModelGroupID] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [MasterModel_PK] PRIMARY KEY CLUSTERED 
(
	[MasterModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterPartList]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterPartList](
	[MasterPartListID] [uniqueidentifier] NOT NULL,
	[MasterModelMachineID] [uniqueidentifier] NOT NULL,
	[MasterModelID] [uniqueidentifier] NOT NULL,
	[PartID] [uniqueidentifier] NOT NULL,
	[FeederNo] [int] NOT NULL,
	[Polarity] [image] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [MasterPartList_PK] PRIMARY KEY CLUSTERED 
(
	[MasterPartListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterStation]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterStation](
	[MasterStationId] [uniqueidentifier] NULL,
	[MasterStationCode] [nvarchar](max) NULL,
	[LineID] [uniqueidentifier] NULL,
	[StationNo] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NULL CONSTRAINT [DF_MasterStation_Active]  DEFAULT (N'Y'),
	[Status] [int] NULL CONSTRAINT [DF_MasterStation_Status]  DEFAULT ((0))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Model]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[ModelID] [uniqueidentifier] NOT NULL,
	[ModelCode] [nvarchar](50) NOT NULL,
	[ModelDesciption] [nvarchar](50) NULL,
	[MasterModelID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NULL CONSTRAINT [DF_Model_Active]  DEFAULT (N'Y'),
 CONSTRAINT [Model_PK] PRIMARY KEY CLUSTERED 
(
	[ModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Part]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Part](
	[PartID] [uniqueidentifier] NOT NULL,
	[PartNo] [nvarchar](20) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NULL CONSTRAINT [DF_Part_Active]  DEFAULT (N'Y'),
 CONSTRAINT [Part_PK] PRIMARY KEY CLUSTERED 
(
	[PartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductionStation]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionStation](
	[ProductionStationId] [uniqueidentifier] NULL,
	[ScheduleID] [uniqueidentifier] NOT NULL,
	[ProductionId] [nvarchar](max) NULL,
	[MasterBOMId] [uniqueidentifier] NOT NULL,
	[RunningId] [nvarchar](150) NULL,
	[PartID] [uniqueidentifier] NULL,
	[Qty] [int] NULL,
	[TDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ScheduleID] [uniqueidentifier] NOT NULL,
	[ProductionId] [nvarchar](max) NULL,
	[LineID] [uniqueidentifier] NOT NULL,
	[MasterModelID] [uniqueidentifier] NULL,
	[ModelID] [uniqueidentifier] NOT NULL,
	[NCDataID] [uniqueidentifier] NULL,
	[Version] [nvarchar](max) NOT NULL,
	[SeqNo] [int] NOT NULL CONSTRAINT [DF_Schedule_SeqNo]  DEFAULT ((0)),
	[EstStart] [datetime] NULL,
	[EstEnd] [datetime] NULL,
	[ActualStart] [datetime] NULL,
	[ActualEnd] [datetime] NULL,
	[PlannedQty] [int] NULL,
	[ExpectedQty] [int] NULL,
	[ActualQty] [int] NULL,
	[ProductionStatus] [nvarchar](50) NULL CONSTRAINT [DF_Schedule_ProductionStatus]  DEFAULT (N'Pending'),
	[InsertionError] [decimal](10, 2) NULL,
	[CurrentErrorType] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [Schedule_PK] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ScheduleDetail]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleDetail](
	[ScheduleDetailID] [uniqueidentifier] NOT NULL,
	[ScheduleID] [uniqueidentifier] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[ShiftSeqNo] [tinyint] NOT NULL,
	[Qty] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [ScheduleDetail_PK] PRIMARY KEY CLUSTERED 
(
	[ScheduleDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Traceability]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traceability](
	[TDate] [datetime] NULL,
	[TraceabilityId] [uniqueidentifier] NULL,
	[ProductSerialNo] [nvarchar](150) NULL,
	[ScheduleID] [uniqueidentifier] NOT NULL,
	[ProductionId] [nvarchar](max) NULL,
	[LineId] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[Active] [nchar](1) NOT NULL,
	[Status] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[UserGroupID] [uniqueidentifier] NOT NULL,
	[UserGroupDesc] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [UserGroup_PK] PRIMARY KEY CLUSTERED 
(
	[UserGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroupFunction]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroupFunction](
	[UserGroupFunctionID] [uniqueidentifier] NOT NULL,
	[UserGroupID] [uniqueidentifier] NOT NULL,
	[FunctionsMenuID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [UserGroupFunction_PK] PRIMARY KEY CLUSTERED 
(
	[UserGroupFunctionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 2/13/2023 4:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[UserMasterID] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[EmployeeName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[UserGroupID] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [UserMaster_PK] PRIMARY KEY CLUSTERED 
(
	[UserMasterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Line] ([LineID], [LineCode], [LineGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'88c9fa20-772a-494b-a818-4e3b701537c2', N'SUBLINE 1', NULL, CAST(N'2023-02-13 13:10:32.000' AS DateTime), NULL, N'7634799d-d386-46ed-a583-3ca0cc9a21b7', NULL, N'Y')
INSERT [dbo].[Line] ([LineID], [LineCode], [LineGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'8a2489a3-dc6c-4a21-b78a-a4299dae0dc9', N'SUBLINE 2', NULL, CAST(N'2023-02-13 13:10:42.000' AS DateTime), NULL, N'7634799d-d386-46ed-a583-3ca0cc9a21b7', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'803878c9-3fca-4193-a9cc-7cda7001205f', N'', N'c32ffba6-eef5-4fdc-91e0-8300b28333a1', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'139c9a30-0654-4c5c-9c04-96757abfefd0', N'', N'45c020a6-ffca-4c3c-8976-30f56f4cbe4c', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'415b7310-3a4a-409b-b4e5-135839e8f595', N'', N'eb750692-869b-40f9-89da-76bfa3eff8e7', N'e707e577-f7ef-4bd8-915e-e146bf51b801', N'882e365e-be43-449b-b858-1453ee26b769', N'41b3b1e6-5818-4006-9cb7-f6f9d87efc3b', N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd92d3909-6e38-45a0-b28f-32102b865ba1', N'', N'441f5f91-948d-434a-96f1-ec68d7fb0896', N'cc577815-a930-409a-8ed7-b16d80e7aba0', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'876af9c0-9a21-4d7f-b79e-f400467bc6af', N'', N'26f49278-4616-4f1c-ada5-36f7c5857441', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5ce85514-7896-4329-8581-33006bd499e5', N'', N'c12a46d0-7f09-4fee-8ccb-398faa5f8712', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6f2d87b9-5609-4690-b76d-200c9dba7bb9', N'', N'950dc73e-10d4-4da4-89d1-a5e9c91939aa', N'4de2c536-9666-4aa5-867e-c58591100fe8', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'dc699ac3-0634-4138-abe1-391ab49f9f24', N'', N'dbea1a3b-e913-4e45-b8c9-e3bcc0955943', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f4a39881-f15f-42ee-b76f-4a0bbd28c0c7', N'', N'5e007158-a887-4bac-b9f2-1287ae387694', N'a0d900df-d320-4041-8dd8-b41a1d7b27ff', N'bfa58c8e-c7b4-46be-ba5c-a04561eebc49', NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'58fa38e3-dd52-4e62-92a9-34a2e2b42412', N'', N'7b42f27a-7e48-4bf9-b44f-3e8c351123bb', N'c4df6b94-ece6-4fc3-834c-e28c1d1fb012', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'060552d8-ca1e-407f-b5c5-2a27fe24da4d', N'', N'e6b4c271-f385-478e-8688-0e83d348931e', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'bb28dce1-70ee-49d9-9b50-5624241d2baa', N'', N'de53c89a-df9b-4dd7-8d29-c929cc43aac8', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'bea3ecf9-7571-44a4-bde1-1a44fd1e5af3', N'', N'8d3ead51-622b-4970-a446-c7f9ba3a6167', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'11e02d6c-b217-4f10-abe6-0ea1dd62c89f', N'', N'a34bc3a5-6dc9-43a0-988f-9bf2c6987022', N'7bd29778-bad3-4826-9e1d-7aa650af7b81', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3fd68fb1-7444-4339-b428-ed07a28d0a26', N'', N'441f5f91-948d-434a-96f1-ec68d7fb0896', N'cc577815-a930-409a-8ed7-b16d80e7aba0', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'306dd112-1f19-4617-86ea-a7149765f7d6', N'', N'b97595c8-376b-4b13-8d09-4ddc1c7ef8e3', N'fd7d4ed0-4d87-47c2-a948-ca778da508c7', N'd7e15405-6030-41e3-ad51-c147156ccbce', NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b931e68e-e366-4138-acbb-7344caaba523', N'', N'76d2d598-ae37-45ed-8d60-70e370193228', N'f5eb3aa4-6e08-4639-83e7-153799107842', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'19b211e9-6f10-4472-b719-6cd29f7e35bf', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'51a0731f-e2ae-442a-b615-da94a6156af4', N'', N'9667da70-a939-4848-8e24-63c521b2fc92', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'19b211e9-6f10-4472-b719-6cd29f7e35bf', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e2b4a1b0-c429-4f7f-9228-064fd5fe8eb3', N'', N'b6aa052f-cd3d-4f79-964f-f03bff1ba606', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'19b211e9-6f10-4472-b719-6cd29f7e35bf', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'bfc6380e-667b-4b40-a459-e38d18088963', N'', N'115d8148-d2a4-4302-856a-8deca7007f65', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c6cbcc0c-b2b3-483a-9afa-344259a447be', N'', N'37f1c5c9-c234-4548-9448-1a3919f3dc6a', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f6138ad4-a749-46c6-8da6-32e85ef7ec48', N'', N'9667da70-a939-4848-8e24-63c521b2fc92', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'228ca65f-b94a-41c9-ba58-7ceb18665fb6', N'', N'e9a64642-b342-444c-a7fa-a2af7118c41b', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0a33d114-71dd-4c94-ae68-d04d0316aec5', N'', N'105148a2-48f4-4e3e-9e90-2160f0673ac2', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c524943e-8022-434f-aaac-3b57a6f105e8', N'', N'fb7dabe1-3620-400c-8139-8de67fb7919e', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'a908b54d-4872-475d-8c84-b1315ceb2642', N'', N'e3414a1e-2a54-4723-902b-d78ace2a66fa', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0967c8a5-1d60-4607-a242-4ae07d876de7', N'', N'327bae9a-9c15-41c4-a6f4-70109db3b63a', N'1110257b-6018-4e32-a36f-de30beee2310', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7e297bbd-4d54-4b57-af8c-36666e20bd13', N'', N'eb750692-869b-40f9-89da-76bfa3eff8e7', N'e707e577-f7ef-4bd8-915e-e146bf51b801', N'882e365e-be43-449b-b858-1453ee26b769', N'41b3b1e6-5818-4006-9cb7-f6f9d87efc3b', N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f01a2b4c-7166-4188-924e-2bed5068a5d8', N'', N'f618e8cb-80ab-4126-af07-4e5ce0b946d7', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7ef5657c-3a95-4db8-8015-63ec6e993d59', N'', N'b97595c8-376b-4b13-8d09-4ddc1c7ef8e3', N'fd7d4ed0-4d87-47c2-a948-ca778da508c7', N'd7e15405-6030-41e3-ad51-c147156ccbce', NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6d4c9fc4-9d04-41ed-aaaa-6e57f01e4529', N'', N'9ccb226f-8773-426c-aeb5-f5492cdc28bc', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5764fd7e-188e-43f3-a918-e754b6837b7f', N'', N'd631e659-0ba2-4a60-a945-43379ae10c95', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'34962590-2cd9-4e6b-ab2d-0e2683101e05', N'', N'64ad2ca9-2b55-4c04-9cd1-3283da254e43', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b7f76c56-120c-4c3a-80ca-3338ff605f7d', N'', N'e3d2a151-cc39-4864-9b1a-0338e54f57d8', N'0535e1b3-8dcf-424c-a07e-40fae0dc869b', N'4f5b020d-69fe-4d68-8270-1e25178aac63', NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b1e520e5-9b73-4e82-bc1f-c036b7073d65', N'', N'49dc4123-821a-4ff9-bf24-b2b64d1c06d1', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'e03563b7-c8d0-47c5-bf3f-f51ce9a8444a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cfe6d7c6-d8ba-4dbe-8515-7415a5879a4b', N'', N'7140608d-d252-4dfa-8e77-a81994a363e3', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'e03563b7-c8d0-47c5-bf3f-f51ce9a8444a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'8db7ef2d-9c4f-457a-b541-72a39d75429c', N'', N'79430683-fbc5-4cbb-9a21-9e63d0147e51', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'e03563b7-c8d0-47c5-bf3f-f51ce9a8444a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f2bdadf7-dbf9-4f92-b088-c4ca0493c8c9', N'', N'15f2e7e7-9678-4413-a7c6-4ae554535d7c', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'e03563b7-c8d0-47c5-bf3f-f51ce9a8444a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'159766ae-0f1d-45d3-a264-8fbe70728cdc', N'', N'b4895a2c-0db4-4a51-af97-2bfed020592b', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'03c40d33-f4a8-45f4-bc9b-cc695ef90cb6', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f064d641-3841-4980-90ef-a9e91cb8aaff', N'', N'06597e2c-ce95-4b84-96ad-8cb38be7a567', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'dbfdbde5-8b1b-40e2-8ffe-3a6831d53dc5', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3a87b905-3a45-4aef-bd30-ee3cf9a352f0', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'dbfdbde5-8b1b-40e2-8ffe-3a6831d53dc5', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3ea17a3b-3a55-4b41-acb5-178a0a8ca33c', N'', N'06d60a1b-eea0-496f-bb8b-a6f922cbc754', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'f7ea9ee9-1a1f-4b27-bea3-741673f1e62c', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e616fac0-15c6-469f-9b42-55c80b689f54', N'', N'77ee7951-9e79-45a8-82d2-889b0aa1977b', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'f7ea9ee9-1a1f-4b27-bea3-741673f1e62c', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'614ba124-ad91-40fd-8d25-2524fed80e6a', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'f7ea9ee9-1a1f-4b27-bea3-741673f1e62c', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1ed1472d-6de6-4bea-a461-e42001d1632d', N'', N'a83a49a6-1898-49ed-8145-b652c4de7e87', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'd83687b7-dc11-48ba-8ef4-26b055a1c8cc', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5051c4b7-2df2-4598-89c7-5ffb9c2cd76b', N'', N'77ee7951-9e79-45a8-82d2-889b0aa1977b', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'd83687b7-dc11-48ba-8ef4-26b055a1c8cc', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7458ce15-6c7e-4599-9b55-72d06b54bc3b', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'd83687b7-dc11-48ba-8ef4-26b055a1c8cc', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6415bf13-6ae0-4fce-8453-b2c1fe89038a', N'', N'9d601579-2c9f-49ac-a91d-fca22200083a', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'3fac9ce2-0c52-4010-8c43-73168b6fc8de', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cc853ff1-5051-448d-bf05-a59954b839fc', N'', N'cce0930a-cdfa-4813-be04-8b1633b1a0ad', N'3c22b824-6a45-4a47-adfe-6c361781193c', NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'3fac9ce2-0c52-4010-8c43-73168b6fc8de', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'8d06b1cb-44a3-470d-b05e-c581ee3a8874', N'', N'f139adba-7e6e-4545-8577-4d7a785697a0', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'3fac9ce2-0c52-4010-8c43-73168b6fc8de', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f81450ab-113c-44dc-8c5b-fb05968903f2', N'', N'52a86d98-ac09-4334-bd30-5b9e1d7ed3f6', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'631188e7-6587-4126-9ccc-01a3ce47c06d', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0528c83d-5e29-4fce-b653-3a35e14e9162', N'', N'77ee7951-9e79-45a8-82d2-889b0aa1977b', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'631188e7-6587-4126-9ccc-01a3ce47c06d', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'8256912f-7ddc-4e2a-9cea-f197254e6973', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'631188e7-6587-4126-9ccc-01a3ce47c06d', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'346bebdb-b92a-4710-92be-df070c95ec4f', N'', N'52a86d98-ac09-4334-bd30-5b9e1d7ed3f6', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef9152c-3a2e-4794-be34-8202de5959d6', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'38f4c0c3-d938-4873-b8b1-d0b9d59721a4', N'', N'18aad673-77a5-432f-85e3-eb58e514f8af', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef9152c-3a2e-4794-be34-8202de5959d6', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'53cc97db-b562-4a71-b405-09bf58924d1b', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef9152c-3a2e-4794-be34-8202de5959d6', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f9071db2-0fa7-498c-93e6-91902b3cc263', N'', N'52a86d98-ac09-4334-bd30-5b9e1d7ed3f6', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'faecfd18-0b0b-4f8b-a222-c87a9cd77e09', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd8d8a133-0d7e-4ddd-b17e-ecb76b881236', N'', N'18aad673-77a5-432f-85e3-eb58e514f8af', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'faecfd18-0b0b-4f8b-a222-c87a9cd77e09', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f2f97c59-4ee8-467f-8ae5-72f56c181cc1', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'faecfd18-0b0b-4f8b-a222-c87a9cd77e09', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5387c8d4-396d-4144-9889-50edb189cae4', N'', N'dbea1a3b-e913-4e45-b8c9-e3bcc0955943', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1d4fb788-8fff-4493-879c-cfd5389d2e58', N'', N'c32ffba6-eef5-4fdc-91e0-8300b28333a1', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e949d477-8ca4-466d-ae9a-39322217464e', N'', N'45c020a6-ffca-4c3c-8976-30f56f4cbe4c', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'80f9f6e6-e1b2-45a2-a857-802f9c50514a', N'', N'57abe554-e982-4797-a385-2c3a3631a11a', N'3ce9387b-ac88-4704-ab0a-22888c0f7c6d', N'228de0e1-d3ff-41d0-bbb7-29486e28e5b8', NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6ade530b-55e8-4a4f-8518-7c67c716da9d', N'', N'26f49278-4616-4f1c-ada5-36f7c5857441', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'63ac89b9-b1b3-4a8a-9f41-de978168e850', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'384b2175-12d3-4bb4-876a-7a20945a993d', N'', N'c12a46d0-7f09-4fee-8ccb-398faa5f8712', N'c415de24-51aa-4c65-bca7-7f72eea9574c', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5e6107e2-43b4-42eb-a24e-50eb3a475d7a', N'', N'950dc73e-10d4-4da4-89d1-a5e9c91939aa', N'4de2c536-9666-4aa5-867e-c58591100fe8', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd55a4370-a198-4776-a1c8-726b66fc466c', N'', N'648e98e3-a973-43cc-a710-1059fb70edc9', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9a069763-79de-4645-94ca-d2ae362970ff', N'', N'9667da70-a939-4848-8e24-63c521b2fc92', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1f4b41ed-f7a5-4477-bee5-a2be7b9bfde0', N'', N'de53c89a-df9b-4dd7-8d29-c929cc43aac8', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cd70d03b-4aa6-46bb-879b-2e267ae646fb', N'', N'8d3ead51-622b-4970-a446-c7f9ba3a6167', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1256b72e-282d-44b2-a9b0-d8dd6e5361c5', N'', N'88413634-f98c-4cac-9806-a405254d0c73', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'88c7474b-d336-4528-88cd-76726fb1b69a', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9edd144c-b227-4dc7-a66e-1f84ef5fe625', N'', N'4c760c9c-2b2f-4784-9cec-ee68db00e5f6', N'acf626cf-a304-4391-83b2-e4831c9bf210', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f932fb9a-0450-4bd4-b38c-887933528b7c', N'', N'441f5f91-948d-434a-96f1-ec68d7fb0896', N'cc577815-a930-409a-8ed7-b16d80e7aba0', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', 3, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'997d7086-eca1-4d65-9982-d247e594ae4c', N'', N'441f5f91-948d-434a-96f1-ec68d7fb0896', N'cc577815-a930-409a-8ed7-b16d80e7aba0', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'2ef21f19-c749-4cfc-b63d-dca3a3906c61', N'', N'b97595c8-376b-4b13-8d09-4ddc1c7ef8e3', N'fd7d4ed0-4d87-47c2-a948-ca778da508c7', N'd7e15405-6030-41e3-ad51-c147156ccbce', NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b9a41520-b226-4577-a30e-e19023d016cd', N'', N'3a6897e7-6686-41e1-a691-d4d6869540c6', N'78486739-fee8-4767-bc42-279f43a0e07f', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'19b211e9-6f10-4472-b719-6cd29f7e35bf', 6, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9c218f42-d923-4f58-a0e1-e31634459041', N'', N'4c760c9c-2b2f-4784-9cec-ee68db00e5f6', N'acf626cf-a304-4391-83b2-e4831c9bf210', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'19b211e9-6f10-4472-b719-6cd29f7e35bf', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'abad770b-2237-462f-996e-480046934c3d', N'', N'0c8ffa6e-1623-4e31-965e-138082e469a5', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'19b211e9-6f10-4472-b719-6cd29f7e35bf', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9d57d90f-5fa0-4f24-bb9b-86e135f73a13', N'', N'115d8148-d2a4-4302-856a-8deca7007f65', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f29325ae-e34b-4ea4-b061-a9668a53ed75', N'', N'26f49278-4616-4f1c-ada5-36f7c5857441', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5cb52856-a710-4a3a-83d3-53e80a6fefd4', N'', N'f796f409-64ac-4cb2-b29d-19400304e2c6', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'2c199165-e2a9-45cf-bc5f-c4c857a3589b', N'', N'47ee3733-9d91-49f9-89ab-032f4b8f84e0', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'736440a7-3c54-4519-92b9-a70a0274d025', N'', N'898b98cf-3a01-42a0-bc14-ce6c4ee2575c', N'1971c9a6-7e1a-4b8b-b173-051b08957494', N'f2bdd06f-76f5-4410-adc8-5b25544bd6d6', NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b34ec658-1930-44ff-a513-f500456c6f9e', N'', N'105148a2-48f4-4e3e-9e90-2160f0673ac2', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'018adff8-e82c-4263-a373-8f294e52d67f', N'', N'fb7dabe1-3620-400c-8139-8de67fb7919e', N'765499a4-dac9-405f-99b9-75335f612e66', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'660257fd-8122-4d45-afe1-15882f9ec443', N'', N'e3414a1e-2a54-4723-902b-d78ace2a66fa', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 3, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'98eda894-1d83-406b-a737-f6c503b3cbe3', N'', N'5ea5f491-2d16-45ba-bb7c-41ce8245731d', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'426a4c53-1841-46e7-aaed-361ef65743ff', N'', N'85030a68-81a3-42f9-b44c-f518ee513dbe', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e9232786-f46b-42d4-ac9f-79f3890e4684', N'', N'327bae9a-9c15-41c4-a6f4-70109db3b63a', N'1110257b-6018-4e32-a36f-de30beee2310', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'99373b8e-74d3-42b4-935f-bd4aa0068c87', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd6e7a8db-d841-4d33-9850-531a2177d89e', N'', N'b97595c8-376b-4b13-8d09-4ddc1c7ef8e3', N'fd7d4ed0-4d87-47c2-a948-ca778da508c7', N'd7e15405-6030-41e3-ad51-c147156ccbce', NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'dbe7b871-d225-422a-86d8-2190a424839c', N'', N'd631e659-0ba2-4a60-a945-43379ae10c95', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c853c161-8313-44a8-acfe-cdadfa8081cc', N'', N'5ea5f491-2d16-45ba-bb7c-41ce8245731d', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'ba70d8e7-875b-4923-bd9c-c68870f64af7', N'', N'eccc0412-0313-4073-a66f-73d2c28e020b', N'6bd95066-d9ca-4899-8040-0d73d6e7bc62', N'9eb6ad0f-5250-4dea-91b6-22ce1c0c4786', NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 3, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7f265ae1-052b-41e5-804a-8c2d623feaed', N'', N'68076576-7dc4-480f-8c95-c510cf7471e5', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'649d8df5-c1a4-4fcd-a6db-237b8b0c3750', N'', N'49dc4123-821a-4ff9-bf24-b2b64d1c06d1', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'b33eed87-8afa-42e9-899f-f2cff8c0c6c2', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c8f5a828-d867-4c9c-986c-8634b13ad2b3', N'', N'6e1a3a2a-87e9-42cf-9db1-7df8cebee2b7', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'b33eed87-8afa-42e9-899f-f2cff8c0c6c2', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'03f422a6-849a-4cb0-833d-18a82a717d31', N'', N'edd094e0-4109-4047-867d-4e2978fcfefb', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'b33eed87-8afa-42e9-899f-f2cff8c0c6c2', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'87024e3a-5ec0-4662-949c-d07b42196b39', N'', N'79430683-fbc5-4cbb-9a21-9e63d0147e51', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'b33eed87-8afa-42e9-899f-f2cff8c0c6c2', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'214bfa98-cfb0-4173-bd81-3dab8f1b0eed', N'', N'ec9e78dd-a3e7-4832-8407-f523676ccc7b', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'03c40d33-f4a8-45f4-bc9b-cc695ef90cb6', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd4eccc15-1c2e-4304-b0d9-0dd519b6e7af', N'', N'537f23ce-e39c-4acc-ab21-3d42dacf21e7', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'03c40d33-f4a8-45f4-bc9b-cc695ef90cb6', 1, NULL, NULL, NULL, NULL, N'Y')
GO
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'ae84362b-5926-4f79-8741-c3f4566f5305', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'03c40d33-f4a8-45f4-bc9b-cc695ef90cb6', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'90845f6e-8080-460e-8860-46cd1c4e2ed4', N'', N'6941dc06-77eb-441b-81f2-a10541e5e0b3', N'd5283d35-0c3e-4528-a387-6895f04bf462', NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'f7ea9ee9-1a1f-4b27-bea3-741673f1e62c', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'402b1588-6b0d-48e0-ba93-cc4392cb33d1', N'', N'537f23ce-e39c-4acc-ab21-3d42dacf21e7', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'f7ea9ee9-1a1f-4b27-bea3-741673f1e62c', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'025297bc-f2cd-4335-86a1-fa5ff1b9fc5a', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'f7ea9ee9-1a1f-4b27-bea3-741673f1e62c', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c4d91525-feea-4a56-85fc-724b1ad66e59', N'', N'9bf8189f-fa1d-4b47-ba6a-2d8dc52eda47', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'd83687b7-dc11-48ba-8ef4-26b055a1c8cc', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5621b6e3-2d93-4a6c-95a2-75d64549747f', N'', N'18aad673-77a5-432f-85e3-eb58e514f8af', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'd83687b7-dc11-48ba-8ef4-26b055a1c8cc', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cfefd11a-312c-449a-b610-3628c9641984', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'd83687b7-dc11-48ba-8ef4-26b055a1c8cc', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'008e75be-cd3d-4e35-a748-62cb947596b4', N'', N'9d601579-2c9f-49ac-a91d-fca22200083a', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'3fac9ce2-0c52-4010-8c43-73168b6fc8de', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c7c74588-2e38-45f8-94fd-03be146f85d3', N'', N'cce0930a-cdfa-4813-be04-8b1633b1a0ad', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'3fac9ce2-0c52-4010-8c43-73168b6fc8de', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5801fd4b-181a-4aeb-9535-eb1df347b09d', N'', N'f139adba-7e6e-4545-8577-4d7a785697a0', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'3fac9ce2-0c52-4010-8c43-73168b6fc8de', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b7e64624-ebc2-495d-a247-6e2709c668f6', N'', N'52a86d98-ac09-4334-bd30-5b9e1d7ed3f6', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'631188e7-6587-4126-9ccc-01a3ce47c06d', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6afa5d38-55d6-4a4a-b346-5d349e279967', N'', N'e084200e-dc1b-4714-a4a9-f2ec2bf04925', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'631188e7-6587-4126-9ccc-01a3ce47c06d', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'bd82256d-9046-43d0-9627-1bf1f1169d9b', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'631188e7-6587-4126-9ccc-01a3ce47c06d', 2, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'27ed5cbe-fdbc-408e-9adc-a4f34b79047f', N'', N'32704361-db6b-417b-9c46-018bb8eca382', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef9152c-3a2e-4794-be34-8202de5959d6', 4, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'aad0baf9-66c5-46fb-a062-568ed800cbf2', N'', N'18aad673-77a5-432f-85e3-eb58e514f8af', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef9152c-3a2e-4794-be34-8202de5959d6', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'52fa2009-328d-494e-b4c5-40b45e13e934', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'5ef9152c-3a2e-4794-be34-8202de5959d6', 4, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'081cd96f-ef51-464d-866f-3773634303ff', N'', N'32704361-db6b-417b-9c46-018bb8eca382', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'faecfd18-0b0b-4f8b-a222-c87a9cd77e09', 4, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c61a212a-784d-44d3-b746-aca7955c24f1', N'', N'18aad673-77a5-432f-85e3-eb58e514f8af', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'faecfd18-0b0b-4f8b-a222-c87a9cd77e09', 1, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [OrPartID1], [OrPartID2], [OrPartID3], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'088e2bea-4a14-4310-8e25-9a98f12adb13', N'', N'46c54f33-e42d-4a70-975b-ba46250fea35', NULL, NULL, NULL, N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'faecfd18-0b0b-4f8b-a222-c87a9cd77e09', 4, NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e87882cc-240b-47bf-98ba-0c50c7863fa2', N'TP2', NULL, CAST(N'2023-02-13 14:13:35.000' AS DateTime), NULL, N'dc610dcc-6228-4d3f-a12e-e9cd1b724fde', NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd6459461-9643-4398-9974-38e2e1f61083', N'TP4', NULL, CAST(N'2023-02-13 13:11:42.000' AS DateTime), NULL, N'7634799d-d386-46ed-a583-3ca0cc9a21b7', NULL, N'Y')
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'63ac89b9-b1b3-4a8a-9f41-de978168e850', N'E1', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'88c7474b-d336-4528-88cd-76726fb1b69a', N'E2', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'0880dac6-1ae6-448d-874f-e1e7903cd7ff', N'E3', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'19b211e9-6f10-4472-b719-6cd29f7e35bf', N'E4', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'62431fd4-d0dd-47df-98ed-fca9b5a69eaa', N'E5', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'99373b8e-74d3-42b4-935f-bd4aa0068c87', N'E6', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'5ef41617-836f-461b-91bf-4fa8b4ec0b76', N'E7', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'e03563b7-c8d0-47c5-bf3f-f51ce9a8444a', N'E8V', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'03c40d33-f4a8-45f4-bc9b-cc695ef90cb6', N'PH1', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'dbfdbde5-8b1b-40e2-8ffe-3a6831d53dc5', N'', N'88c9fa20-772a-494b-a818-4e3b701537c2', 2, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'f7ea9ee9-1a1f-4b27-bea3-741673f1e62c', N'PH2', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'd83687b7-dc11-48ba-8ef4-26b055a1c8cc', N'PH3', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'3fac9ce2-0c52-4010-8c43-73168b6fc8de', N'PH4', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'631188e7-6587-4126-9ccc-01a3ce47c06d', N'PH5', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'5ef9152c-3a2e-4794-be34-8202de5959d6', N'PH6', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'faecfd18-0b0b-4f8b-a222-c87a9cd77e09', N'PH7', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'b33eed87-8afa-42e9-899f-f2cff8c0c6c2', N'E8', N'88c9fa20-772a-494b-a818-4e3b701537c2', 1, NULL, NULL, NULL, NULL, N'Y', 0)
INSERT [dbo].[Model] ([ModelID], [ModelCode], [ModelDesciption], [MasterModelID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c919db3f-70e6-43c6-b834-3d6c29e867b6', N'TNPA7885EA', N'', N'd6459461-9643-4398-9974-38e2e1f61083', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Model] ([ModelID], [ModelCode], [ModelDesciption], [MasterModelID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1db114fa-2ae8-4e33-96aa-86e52875d245', N'TNPA7725ED', N'', N'e87882cc-240b-47bf-98ba-0c50c7863fa2', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'32704361-db6b-417b-9c46-018bb8eca382', N'B1CERL000050', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'47ee3733-9d91-49f9-89ab-032f4b8f84e0', N'2TXAUC02XUVJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e3d2a151-cc39-4864-9b1a-0338e54f57d8', N'F0CAF224A218', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1971c9a6-7e1a-4b8b-b173-051b08957494', N'F1AAF681A019', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6bd95066-d9ca-4899-8040-0d73d6e7bc62', N'F0CAF3340009', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e6b4c271-f385-478e-8688-0e83d348931e', N'K1KY16BA0491', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'648e98e3-a973-43cc-a710-1059fb70edc9', N'K1KA16BA0329', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5e007158-a887-4bac-b9f2-1287ae387694', N'F1AAH101A001', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0c8ffa6e-1623-4e31-965e-138082e469a5', N'2TXAUC07SQVJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'882e365e-be43-449b-b858-1453ee26b769', N'F1BAF471A232', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f5eb3aa4-6e08-4639-83e7-153799107842', N'ERG2SJ202P', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f796f409-64ac-4cb2-b29d-19400304e2c6', N'G4DYA0000981', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'37f1c5c9-c234-4548-9448-1a3919f3dc6a', N'G4DYA0000917', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'4f5b020d-69fe-4d68-8270-1e25178aac63', N'F0CAF224A124', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'105148a2-48f4-4e3e-9e90-2160f0673ac2', N'F0C2K223A066', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3ce9387b-ac88-4704-ab0a-22888c0f7c6d', N'F1AAF331A019', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9eb6ad0f-5250-4dea-91b6-22ce1c0c4786', N'F0CAF334A125', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'78486739-fee8-4767-bc42-279f43a0e07f', N'ERG2SJ242P', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'228de0e1-d3ff-41d0-bbb7-29486e28e5b8', N'F1BAF331A232', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b4895a2c-0db4-4a51-af97-2bfed020592b', N'B0FBBR000037', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'57abe554-e982-4797-a385-2c3a3631a11a', N'F1AAH331A001', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9bf8189f-fa1d-4b47-ba6a-2d8dc52eda47', N'B0FBCR000076', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'45c020a6-ffca-4c3c-8976-30f56f4cbe4c', N'F0C2K273A066', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'64ad2ca9-2b55-4c04-9cd1-3283da254e43', N'TXAUC03YEVJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'26f49278-4616-4f1c-ada5-36f7c5857441', N'B3PAA0000707', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c12a46d0-7f09-4fee-8ccb-398faa5f8712', N'D4DAY4700004', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'537f23ce-e39c-4acc-ab21-3d42dacf21e7', N'TUC5ZJ52915', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7b42f27a-7e48-4bf9-b44f-3e8c351123bb', N'G0C6R8M00013', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0535e1b3-8dcf-424c-a07e-40fae0dc869b', N'F0CAF2240010', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5ea5f491-2d16-45ba-bb7c-41ce8245731d', N'G0B133K00001', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd631e659-0ba2-4a60-a945-43379ae10c95', N'K6A1AYY00005', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'15f2e7e7-9678-4413-a7c6-4ae554535d7c', N'TXAUC07BEWJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f139adba-7e6e-4545-8577-4d7a785697a0', N'XYN3+C6FJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b97595c8-376b-4b13-8d09-4ddc1c7ef8e3', N'B3PAA0000704', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'edd094e0-4109-4047-867d-4e2978fcfefb', N'TXAUC03BCWJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f618e8cb-80ab-4126-af07-4e5ce0b946d7', N'TXAUC08YEVJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f2bdd06f-76f5-4410-adc8-5b25544bd6d6', N'F1BAF681A232', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'52a86d98-ac09-4334-bd30-5b9e1d7ed3f6', N'B0JBSL000103', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9667da70-a939-4848-8e24-63c521b2fc92', N'D0MA30MJA025', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd5283d35-0c3e-4528-a387-6895f04bf462', N'B1CERR000227', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3c22b824-6a45-4a47-adfe-6c361781193c', N'TUC4VJ50041', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'327bae9a-9c15-41c4-a6f4-70109db3b63a', N'D4EAY621A216', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'76d2d598-ae37-45ed-8d60-70e370193228', N'D0C2202JA162', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'eccc0412-0313-4073-a66f-73d2c28e020b', N'F0CAF334A223', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'765499a4-dac9-405f-99b9-75335f612e66', N'K5E502YYA162', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'eb750692-869b-40f9-89da-76bfa3eff8e7', N'F1AAH471A001', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7bd29778-bad3-4826-9e1d-7aa650af7b81', N'F2A2W151A275', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6e1a3a2a-87e9-42cf-9db1-7df8cebee2b7', N'G4DYA0000979', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c415de24-51aa-4c65-bca7-7f72eea9574c', N'D4DAY470A037', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c32ffba6-eef5-4fdc-91e0-8300b28333a1', N'K1KY28BA0491', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'77ee7951-9e79-45a8-82d2-889b0aa1977b', N'TUC4GJ5045', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cce0930a-cdfa-4813-be04-8b1633b1a0ad', N'TUC5ZJ51951', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'06597e2c-ce95-4b84-96ad-8cb38be7a567', N'TUC4GJ5019', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'fb7dabe1-3620-400c-8139-8de67fb7919e', N'K5E502YYA213', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'115d8148-d2a4-4302-856a-8deca7007f65', N'F2A1E2220112', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'a34bc3a5-6dc9-43a0-988f-9bf2c6987022', N'F2A2W1510005', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'79430683-fbc5-4cbb-9a21-9e63d0147e51', N'K5E153YYA163', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'bfa58c8e-c7b4-46be-ba5c-a04561eebc49', N'F1BAF101A232', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6941dc06-77eb-441b-81f2-a10541e5e0b3', N'B1CERR000208', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e9a64642-b342-444c-a7fa-a2af7118c41b', N'TXAUC01FBWJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'88413634-f98c-4cac-9806-a405254d0c73', N'G0B300K00001', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'950dc73e-10d4-4da4-89d1-a5e9c91939aa', N'K5E312YYA213', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'06d60a1b-eea0-496f-bb8b-a6f922cbc754', N'B1DEGR000065', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7140608d-d252-4dfa-8e77-a81994a363e3', N'G4DYA0000966', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cc577815-a930-409a-8ed7-b16d80e7aba0', N'F2A1V1020134', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'49dc4123-821a-4ff9-bf24-b2b64d1c06d1', N'G4DYA0001117', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'a0d900df-d320-4041-8dd8-b41a1d7b27ff', N'F1AAF101A019', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'a83a49a6-1898-49ed-8145-b652c4de7e87', N'B0FBBR000121', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'46c54f33-e42d-4a70-975b-ba46250fea35', N'XYN3+C8FJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd7e15405-6030-41e3-ad51-c147156ccbce', N'B3PAA0000629', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'68076576-7dc4-480f-8c95-c510cf7471e5', N'2TXAUC01YDVJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'4de2c536-9666-4aa5-867e-c58591100fe8', N'K5E312YYA162', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'8d3ead51-622b-4970-a446-c7f9ba3a6167', N'F1A3A471A081', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'de53c89a-df9b-4dd7-8d29-c929cc43aac8', N'K1KY03BA0799', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'fd7d4ed0-4d87-47c2-a948-ca778da508c7', N'B3PAA0000674', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'898b98cf-3a01-42a0-bc14-ce6c4ee2575c', N'F1AAH681A002', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3a6897e7-6686-41e1-a691-d4d6869540c6', N'D0C2242JA162', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e3414a1e-2a54-4723-902b-d78ace2a66fa', N'F0CZZ105A169', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1110257b-6018-4e32-a36f-de30beee2310', N'ERZV10V621C2', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e707e577-f7ef-4bd8-915e-e146bf51b801', N'F1AAF471A019', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c4df6b94-ece6-4fc3-834c-e28c1d1fb012', N'G0C6R8MA0094', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'dbea1a3b-e913-4e45-b8c9-e3bcc0955943', N'K1KA02B00295', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'acf626cf-a304-4391-83b2-e4831c9bf210', N'F2A2W2210004', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'18aad673-77a5-432f-85e3-eb58e514f8af', N'TUC5ZJ52912', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'441f5f91-948d-434a-96f1-ec68d7fb0896', N'F2A1V1020144', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'4c760c9c-2b2f-4784-9cec-ee68db00e5f6', N'F2A2W2210005', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b6aa052f-cd3d-4f79-964f-f03bff1ba606', N'TXAUC03FBWJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e084200e-dc1b-4714-a4a9-f2ec2bf04925', N'TUC5ZJ52913', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'85030a68-81a3-42f9-b44c-f518ee513dbe', N'TXAUC01FAWJ', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'ec9e78dd-a3e7-4832-8407-f523676ccc7b', N'B0FBCR000021', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9ccb226f-8773-426c-aeb5-f5492cdc28bc', N'G0B103L00002', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'41b3b1e6-5818-4006-9cb7-f6f9d87efc3b', N'F1B2G4710004', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9d601579-2c9f-49ac-a91d-fca22200083a', N'B1CERR000144', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'19f56140-ef76-4193-a762-b8cbe0cc19b9', N'12dcfab0-9717-4d4c-9ccb-e422653493e9', N'PRD130223-1313', N'803878c9-3fca-4193-a9cc-7cda7001205f', N'9999', N'c32ffba6-eef5-4fdc-91e0-8300b28333a1', 500, CAST(N'2023-02-13 16:01:08.000' AS DateTime), N'1')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'12dcfab0-9717-4d4c-9ccb-e422653493e9', N'PRD130223-1313', N'88c9fa20-772a-494b-a818-4e3b701537c2', N'd6459461-9643-4398-9974-38e2e1f61083', N'c919db3f-70e6-43c6-b834-3d6c29e867b6', NULL, N'Test', 0, CAST(N'2023-02-13 13:13:00.000' AS DateTime), CAST(N'2023-02-13 17:20:00.000' AS DateTime), CAST(N'2023-02-13 13:13:45.000' AS DateTime), NULL, 500, NULL, NULL, N'Started', NULL, NULL, CAST(N'2023-02-13 13:13:40.000' AS DateTime), NULL, N'bce0f4df-189e-43ab-b094-0cf348db960f', NULL, N'Y')
INSERT [dbo].[UserGroup] ([UserGroupID], [UserGroupDesc], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'4f5b020d-69fe-4d68-8270-1e25178aac63', N'Admin', CAST(N'2023-02-13 13:10:32.000' AS DateTime), NULL, N'4f5b020d-69fe-4d68-8270-1e25178aac63', NULL, N'Y')
INSERT [dbo].[UserMaster] ([UserMasterID], [UserName], [EmployeeName], [Password], [UserGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e3414a1e-2a54-4723-902b-d78ace2a66fa', N'Admin', N'Admin', N'123', N'4f5b020d-69fe-4d68-8270-1e25178aac63', CAST(N'2023-02-13 13:10:32.000' AS DateTime), NULL, N'e3414a1e-2a54-4723-902b-d78ace2a66fa', NULL, N'Y')
ALTER TABLE [dbo].[Traceability] ADD  CONSTRAINT [DF_Traceability_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Traceability] ADD  CONSTRAINT [DF_Tracebility_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[LineDetail]  WITH NOCHECK ADD  CONSTRAINT [Line_LineDetail_FK1] FOREIGN KEY([LineID])
REFERENCES [dbo].[Line] ([LineID])
GO
ALTER TABLE [dbo].[LineDetail] CHECK CONSTRAINT [Line_LineDetail_FK1]
GO
ALTER TABLE [dbo].[MasterPartList]  WITH NOCHECK ADD  CONSTRAINT [MasterModel_MasterPartList_FK1] FOREIGN KEY([MasterModelID])
REFERENCES [dbo].[MasterModel] ([MasterModelID])
GO
ALTER TABLE [dbo].[MasterPartList] CHECK CONSTRAINT [MasterModel_MasterPartList_FK1]
GO
ALTER TABLE [dbo].[MasterPartList]  WITH NOCHECK ADD  CONSTRAINT [Part_MasterPartList_FK1] FOREIGN KEY([PartID])
REFERENCES [dbo].[Part] ([PartID])
GO
ALTER TABLE [dbo].[MasterPartList] CHECK CONSTRAINT [Part_MasterPartList_FK1]
GO
ALTER TABLE [dbo].[Schedule]  WITH NOCHECK ADD  CONSTRAINT [Line_Schedule_FK1] FOREIGN KEY([LineID])
REFERENCES [dbo].[Line] ([LineID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [Line_Schedule_FK1]
GO
ALTER TABLE [dbo].[ScheduleDetail]  WITH NOCHECK ADD  CONSTRAINT [Schedule_ScheduleDetail_FK1] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedule] ([ScheduleID])
GO
ALTER TABLE [dbo].[ScheduleDetail] CHECK CONSTRAINT [Schedule_ScheduleDetail_FK1]
GO
USE [master]
GO
ALTER DATABASE [PCC] SET  READ_WRITE 
GO

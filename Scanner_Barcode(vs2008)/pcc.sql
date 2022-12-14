USE [PCC]
GO
/****** Object:  Table [dbo].[ActivityLog]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[Line]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[LineDetail]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[LineGroup]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[MasterBOM]    Script Date: 12/19/2022 5:42:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterBOM](
	[MasterBOMId] [uniqueidentifier] NOT NULL,
	[AssemblyRef] [nvarchar](max) NULL,
	[PartID] [uniqueidentifier] NOT NULL,
	[MasterModelID] [uniqueidentifier] NULL,
	[ModelID] [uniqueidentifier] NULL,
	[LineID] [uniqueidentifier] NULL,
	[MasterStationId] [uniqueidentifier] NULL,
	[Insertion] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterModel]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[MasterPartList]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[MasterStation]    Script Date: 12/19/2022 5:42:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterStation](
	[MasterStationId] [uniqueidentifier] NULL,
	[MasterStationCode] [nvarchar](max) NULL,
	[LineID] [uniqueidentifier] NULL,
	[StationNo] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
	[Status] [int] NULL CONSTRAINT [DF_MasterStation_Status]  DEFAULT ((0))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Model]    Script Date: 12/19/2022 5:42:22 PM ******/
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
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [Model_PK] PRIMARY KEY CLUSTERED 
(
	[ModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Part]    Script Date: 12/19/2022 5:42:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Part](
	[PartID] [uniqueidentifier] NOT NULL,
	[PartNo] [nvarchar](20) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[Active] [nchar](1) NOT NULL,
 CONSTRAINT [Part_PK] PRIMARY KEY CLUSTERED 
(
	[PartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductionStation]    Script Date: 12/19/2022 5:42:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionStation](
	[ProductionStationId] [uniqueidentifier] NULL,
	[ScheduleID] [uniqueidentifier] NOT NULL,
	[ProductionId] [nvarchar](max) NULL,
	[MasterBOMId] [uniqueidentifier] NOT NULL,
	[PartID] [uniqueidentifier] NULL,
	[Qty] [int] NULL,
	[TDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[ScheduleDetail]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[UserGroup]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[UserGroupFunction]    Script Date: 12/19/2022 5:42:22 PM ******/
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
/****** Object:  Table [dbo].[UserMaster]    Script Date: 12/19/2022 5:42:22 PM ******/
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
ALTER TABLE [dbo].[Schedule]  WITH NOCHECK ADD  CONSTRAINT [Model_Schedule_FK1] FOREIGN KEY([ModelID])
REFERENCES [dbo].[Model] ([ModelID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [Model_Schedule_FK1]
GO
ALTER TABLE [dbo].[ScheduleDetail]  WITH NOCHECK ADD  CONSTRAINT [Schedule_ScheduleDetail_FK1] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedule] ([ScheduleID])
GO
ALTER TABLE [dbo].[ScheduleDetail] CHECK CONSTRAINT [Schedule_ScheduleDetail_FK1]
GO

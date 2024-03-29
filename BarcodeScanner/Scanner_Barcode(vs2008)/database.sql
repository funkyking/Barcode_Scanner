USE [PCC]
GO
/****** Object:  Table [dbo].[ActivityLog]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[Line]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[LineDetail]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[LineGroup]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[MasterBOM]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[MasterModel]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[MasterPartList]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[MasterStation]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[Model]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[Part]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[ProductionStation]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[Schedule]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[ScheduleDetail]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[Traceability]    Script Date: 2/2/2023 5:56:31 PM ******/
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
	[Active] [nchar](1) NOT NULL CONSTRAINT [DF_Traceability_Active]  DEFAULT ((1)),
	[Status] [int] NULL CONSTRAINT [DF_Tracebility_Status]  DEFAULT ((0))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[UserGroupFunction]    Script Date: 2/2/2023 5:56:31 PM ******/
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
/****** Object:  Table [dbo].[UserMaster]    Script Date: 2/2/2023 5:56:31 PM ******/
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
INSERT [dbo].[Line] ([LineID], [LineCode], [LineGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'Subline 2', NULL, CAST(N'2022-11-24 17:05:45.000' AS DateTime), NULL, N'de066a80-4581-4545-b094-685b8a9f7df8', NULL, N'Y')
INSERT [dbo].[Line] ([LineID], [LineCode], [LineGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'2b30ff77-5127-4c58-b4e8-695338016b64', N'Subline 1', NULL, CAST(N'2022-12-02 15:16:44.000' AS DateTime), CAST(N'2022-12-02 16:37:23.000' AS DateTime), N'245b7e7d-0589-48e8-a3bb-33be9b87813c', N'2aa907cb-4307-4ef2-8448-c4d354e21553', N'N')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c5c8b43f-6b63-4857-9be8-4ff7e4e1afa4', N'Diod', N'e6f35430-cbe6-4b17-bad4-01def45d2865', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-11-29 15:39:53.000' AS DateTime), NULL, N'53a3dd47-5536-48f6-8c68-e1a2ffdcfa85', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7c9bb62f-dafb-440d-ba28-e13e00da82bc', N'Resistor', N'1250236d-778d-4ce5-9fce-0794fb41f19e', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-11-29 15:43:24.000' AS DateTime), NULL, N'53a3dd47-5536-48f6-8c68-e1a2ffdcfa85', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'339e102e-97b0-455c-a9fa-5260cae70355', N'', N'985c797c-7035-4dc3-b2c6-1656ea36f298', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'9699cd39-c22c-40d0-87ad-a84f4e18364f', 1, CAST(N'2022-11-29 15:50:26.000' AS DateTime), NULL, N'0cb4a1d0-539b-42bc-af78-bd3bf47361a7', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c5c8b43f-6b63-4857-9be8-4ff7e4e1afa4', N'Diod', N'e6f35430-cbe6-4b17-bad4-01def45d2865', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-11-29 15:39:53.000' AS DateTime), NULL, N'53a3dd47-5536-48f6-8c68-e1a2ffdcfa85', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7c9bb62f-dafb-440d-ba28-e13e00da82bc', N'Resistor', N'1250236d-778d-4ce5-9fce-0794fb41f19e', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-11-29 15:43:24.000' AS DateTime), NULL, N'53a3dd47-5536-48f6-8c68-e1a2ffdcfa85', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'', N'e6f35430-cbe6-4b17-bad4-01def45d2865', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-12-15 17:11:52.000' AS DateTime), NULL, N'62e681cc-2c01-469c-8a9d-baa6cf99be36', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9a36c57e-6b2c-4717-ade5-d1fe96dd64b5', N'', N'0a9550d8-f0e4-46a2-a75d-2a03b778e451', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-12-19 14:43:35.000' AS DateTime), NULL, N'22adc725-4374-47ad-adf2-6da801ad67d4', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'acbe182c-a2dc-11ed-a8fc-0242ac120002', NULL, N'fd50bd42-a2d9-11ed-a8fc-0242ac120002', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-11-29 15:39:53.000' AS DateTime), NULL, N'53a3dd47-5536-48f6-8c68-e1a2ffdcfa85', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'339e102e-97b0-455c-a9fa-5260cae70355', N'', N'985c797c-7035-4dc3-b2c6-1656ea36f298', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'9699cd39-c22c-40d0-87ad-a84f4e18364f', 1, CAST(N'2022-11-29 15:50:26.000' AS DateTime), NULL, N'0cb4a1d0-539b-42bc-af78-bd3bf47361a7', NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cbe1ab90-ac22-4203-b795-2f478a143686', N'TP4', NULL, CAST(N'2022-11-16 17:25:32.000' AS DateTime), NULL, N'9e7bdd7c-de8f-4bcc-a4a0-0858f29b4074', NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b606bb42-3b0a-4755-b6eb-a6ef5314ac6a', N'TP9', NULL, CAST(N'2022-11-16 17:25:57.000' AS DateTime), CAST(N'2022-11-21 15:42:10.000' AS DateTime), N'2df97188-47a2-4d5f-afdc-ce1e4e8bc1df', N'31868519-0602-4d68-9a3f-18d2b8f456ce', N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'2aa58fda-9505-452d-94c8-ac95c8d4fb78', N'TP8', NULL, CAST(N'2022-11-16 17:26:46.000' AS DateTime), NULL, N'b7420598-4e1b-4c53-a0fd-e0df45530b1f', NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'TP3', NULL, CAST(N'2022-11-16 17:20:38.000' AS DateTime), NULL, N'bdf00458-7923-40fa-9506-2f1be449cd35', NULL, N'Y')
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', N'E1', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 1, CAST(N'2022-12-02 15:04:57.000' AS DateTime), NULL, N'30c4f382-4f12-469a-8193-8d6d7689924e', NULL, N'Y', 1)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'e3442e5e-9c53-4b74-a3a7-857210062cbb', N'E2', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 1, CAST(N'2022-12-02 15:05:09.000' AS DateTime), NULL, N'30c4f382-4f12-469a-8193-8d6d7689924e', NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'37349e23-f995-4042-8ccd-9f3fc5e67120', N'E3', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 3, CAST(N'2022-12-02 15:05:30.000' AS DateTime), NULL, N'30c4f382-4f12-469a-8193-8d6d7689924e', NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'3328e96e-0bd7-4680-b9ce-e26a1086a2fc', N'E4', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 4, CAST(N'2022-12-02 15:07:37.000' AS DateTime), NULL, N'30c4f382-4f12-469a-8193-8d6d7689924e', NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'0c91a007-e866-44be-9dc9-5f1541c689e5', N'A1', N'2b30ff77-5127-4c58-b4e8-695338016b64', 1, CAST(N'2022-12-02 15:16:59.000' AS DateTime), NULL, N'245b7e7d-0589-48e8-a3bb-33be9b87813c', NULL, N'Y', 0)
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active], [Status]) VALUES (N'135f26c7-02ad-407a-ab3d-ab7b857e3cee', N'A2', N'2b30ff77-5127-4c58-b4e8-695338016b64', 2, CAST(N'2022-12-02 15:17:09.000' AS DateTime), NULL, N'245b7e7d-0589-48e8-a3bb-33be9b87813c', NULL, N'Y', 0)
INSERT [dbo].[Model] ([ModelID], [ModelCode], [ModelDesciption], [MasterModelID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'TP3MAXXX', N'TP3MAA', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', CAST(N'2022-11-21 15:55:31.000' AS DateTime), CAST(N'2022-11-21 16:18:19.000' AS DateTime), N'826c7bf5-687c-4f62-9531-34c25b0e055e', N'a181822a-aa11-4b6d-b4b9-7aff293f57a6', N'Y')
INSERT [dbo].[Model] ([ModelID], [ModelCode], [ModelDesciption], [MasterModelID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'de479b44-9b63-41da-ac46-96b023469785', N'Test1', NULL, N'de479b44-9b63-41da-ac46-96b023469785', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e6f35430-cbe6-4b17-bad4-01def45d2865', N'K1KY03BA0799', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'fd50bd42-a2d9-11ed-a8fc-0242ac120002', N'ECWFD2W155KC', CAST(N'2022-11-24 11:20:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1250236d-778d-4ce5-9fce-0794fb41f19e', N'TUC5ZJ52231', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd336c062-8923-441f-8b57-0ff24bc46311', N'TUC5ZJ52231', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'985c797c-7035-4dc3-b2c6-1656ea36f298', N'XYN3+C6FJ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3a2cd98e-a44b-479d-a847-270e325ca600', N'G4DYA0000769', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0908869a-caa3-4446-9355-278e8364c45b', N'G4DYA0000496', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'121594cb-0fbe-48ea-bfb6-27bd5720b48e', N'B1CERR000144', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0a9550d8-f0e4-46a2-a75d-2a03b778e451', N'ECWFD2W155KC', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c1c6daa9-902f-4d42-8d5a-2eb810b14131', N'F2A2W8200021', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'467972fb-14b5-4a14-a2ab-352fab57e68e', N'B3PAA0000707', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'83394c97-e461-4022-84e8-3e027d1f9e15', N'F0CAF683A217', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'835ee990-602f-4914-8366-43a261e27e65', N'K2AAYA000005', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'4060f252-6789-4fec-ac55-45a7ff23a040', N'B0HAPR000013', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'4b969cc3-a4bb-4c54-88e8-4a8eecb0ebda', N'D4CAY2R2A178', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'148ca7b1-9260-4c0c-83ba-4c1320441b34', N'XYN3+C6FJ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e421d983-a137-4862-ac8f-4fa4bf2eaee8', N'B3PAA0000704', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd522bc26-6608-4a24-aa4d-52a593a66b10', N'B3PAA0000707', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5b0de12d-2982-4e28-806a-5859418a0b3d', N'TXAUC01CMVZ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'd9539cae-1193-4dc6-b984-58bf58036cb8', N'XYN3+C8FJ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'a0780839-3444-4f7a-9ebb-5df093602ca0', N'F0CAF334A223', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'60b361a7-073d-4c03-b23d-638ed22582fc', N'F1AAF471A019', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f43c2240-abe3-4f48-bb8e-68d33addc29c', N'TUC5ZJ51551', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5065e06d-6e6a-40e3-9a9c-7b06ac5d2eb5', N'TUC5ZJ51951', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cfd8da5a-d330-4fc0-a490-80838fb5c534', N'TXAUC02CMVZ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9d5b54ce-9aba-4280-8dde-81c2fd7cd264', N'K1KY28BA0491', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'2fa2ffcb-290a-4560-b428-85a3abbb50e9', N'D4EAY621A216', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5d328785-88ca-4f29-b000-88bcf19f1baf', N'B0FAAR000026', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e8109c35-9079-41e3-9ead-8bba5077bdb4', N'G0B183G00011', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'3ca243f1-ff95-40b1-9985-8f3775fa5afa', N'F0CAF224A218', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'a72a5d3d-8551-4d4d-b9c5-924aebac7b30', N'B0FBCN000017', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7d65ca4c-5257-4343-859d-92bd4155798f', N'B0FAAR000026', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f11527a3-8279-4b3d-b1ed-9502e2609fab', N'G0B110J00001', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'2e52f4ad-fd4d-4811-949e-9566ca245eac', N'B0JBSL000095', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'875a30dd-09ba-413a-92bb-967d6e209a28', N'XYN3+C8FJ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'60dbc452-ed44-4edd-8238-a419eae82f1e', N'G0C6R8MA0094', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e0ce9914-e52c-42fc-a806-a55d294c069b', N'ECWH8223HAC', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'abf1199c-55a6-4bf4-adc4-a810e64e182c', N'F1AAF101A019', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'0b249714-147b-47ed-b9a3-c3436e8357ea', N'XYN3+C6FJ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9c0e5425-f372-4bc3-a64b-cdeeece28224', N'TXAUC04XGVJ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'371c2d3b-dbfd-4d35-8e7e-cf1fd01221b2', N'K5E632YYA163', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'54c86e1c-fa5f-4343-a4e3-d72ae78850f5', N'F2AZZ2220005', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'8c76bea1-9681-4371-8734-e45eab20a273', N'B0FBBR000104', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'1d7c549b-4c69-4a6c-9ca6-ec6b411811a2', N'TXAUC03XGVJ', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c6dd88ac-4d6a-49c6-96e2-f62bee0f7c18', N'D0C2153JA162', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'ee0bc351-b5b5-4454-96dc-f91556797902', N'B3PAA0000704', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'81664d4c-a262-4112-91c7-fd63b8c98bea', N'G4DYA0000993', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 180, NULL, NULL)
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2022-12-21 10:04:23.000' AS DateTime), N'Completed')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (NULL, N'f6be11cd-002e-43ca-b886-3505a89cc981', NULL, N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151216', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2022-12-21 17:42:32.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 400, CAST(N'2022-12-21 17:44:23.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ee', N'83da4c5c-77d8-4ebe-827c-888e8111653c', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 150, NULL, N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2023-01-31 14:55:08.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 400, CAST(N'2023-01-31 14:56:54.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, NULL, N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (NULL, N'f6be11cd-002e-43ca-b886-3505a89cc981', NULL, N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', NULL, N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2022-12-21 15:08:51.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2022-12-21 18:00:31.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'd97c3df4-3dcf-4f02-bc11-03db4e10000b', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 1000, CAST(N'2023-01-31 15:09:06.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'54a37191-833d-4095-aa15-d00a2f5ca84c', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', NULL, N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2023-01-31 17:02:42.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'b6e2ec3a-eea7-423a-ae9b-25e01e5971b6', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151217', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2023-01-31 17:17:38.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'48a38b7b-712e-4ec9-a140-3f73d7a909b7', N'94efe82a-a2db-11ed-a8fc-0242ac120002', N'PRD123456-1234', N'acbe182c-a2dc-11ed-a8fc-0242ac120002', N'23456', N'fd50bd42-a2d9-11ed-a8fc-0242ac120002', 1, CAST(N'2023-02-02 18:35:46.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'c16ff70f-4acb-45b3-ba19-99719bdfa20e', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151219', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 500, CAST(N'2023-02-02 11:51:14.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'b25b47c2-4a0f-4ebf-a09c-0f4cd3352619', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151220', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 900, CAST(N'2023-02-02 12:14:14.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'36471669-d3a3-48ee-9732-1a5a2dbcb3b6', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151217', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 400, CAST(N'2023-02-02 18:06:54.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'81ed9d7a-9e5d-4d4a-9e6e-986e9cd28e42', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151218', N'1250236d-778d-4ce5-9fce-0794fb41f19e', 400, CAST(N'2023-02-02 18:08:51.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'015bb941-f6c6-4e29-9a58-322edbe8233a', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151216', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2023-02-02 18:09:48.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'a919c728-3351-43dd-80a4-ab0470ecfaa3', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151216', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2023-02-02 18:10:28.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'edd727fc-9b6c-4619-9f3d-c852b9b1e8da', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'151216', N'e6f35430-cbe6-4b17-bad4-01def45d2865', 300, CAST(N'2023-02-02 18:11:43.000' AS DateTime), N'1')
INSERT [dbo].[ProductionStation] ([ProductionStationId], [ScheduleID], [ProductionId], [MasterBOMId], [RunningId], [PartID], [Qty], [TDate], [Status]) VALUES (N'749de490-ed32-462d-ace6-1d6ce6d1230d', N'94efe82a-a2db-11ed-a8fc-0242ac120002', N'PRD123456-1234', N'd4fd9bc0-47f4-4fbd-b2f5-098999a40d12', N'12345', N'fd50bd42-a2d9-11ed-a8fc-0242ac120002', 5000, CAST(N'2023-02-02 18:30:28.000' AS DateTime), N'1')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cf9d4e5a-87a4-42e3-8eb8-310d4ed6a2a5', NULL, N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Desc', 0, CAST(N'2022-12-13 11:00:00.000' AS DateTime), CAST(N'2022-12-13 00:30:00.000' AS DateTime), NULL, NULL, 1200, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-13 09:33:24.000' AS DateTime), NULL, N'b52a44be-52a8-4cbb-894c-6aea4b19d674', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'f6be11cd-002e-43ca-b886-3505a89cc981', N'PRD141222-1451', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'LOT 881AA', 0, CAST(N'2022-12-14 14:30:00.000' AS DateTime), CAST(N'2022-12-14 17:30:00.000' AS DateTime), CAST(N'2022-12-14 14:51:16.000' AS DateTime), NULL, 3600, NULL, NULL, N'Stopped', NULL, NULL, CAST(N'2022-12-14 14:48:16.000' AS DateTime), NULL, N'c1b496bd-53b2-4e23-ac6a-73df21c92e2e', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'39c6f0ef-bcc8-4145-91cd-367428b23a1a', NULL, N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Test3', 0, CAST(N'2022-12-07 01:30:00.000' AS DateTime), CAST(N'2022-12-07 03:30:00.000' AS DateTime), NULL, NULL, 10, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-07 17:46:55.000' AS DateTime), NULL, N'39b0e6a3-40ca-48b9-b61c-d4b86ab08f49', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'34726b93-78d4-4a84-b38a-3789879d6c9a', NULL, N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Test5', 0, CAST(N'2022-12-07 01:15:00.000' AS DateTime), CAST(N'2022-12-07 03:20:00.000' AS DateTime), NULL, NULL, 20, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-08 15:21:18.000' AS DateTime), NULL, N'04e0f092-fef2-4b9d-bdfb-b2d0c4365a9e', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'17944914-edaa-4031-b089-74f0c2e55f53', NULL, N'2b30ff77-5127-4c58-b4e8-695338016b64', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Test2', 0, CAST(N'2022-12-07 04:30:00.000' AS DateTime), CAST(N'2022-12-07 05:00:00.000' AS DateTime), NULL, NULL, 100, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-07 17:41:21.000' AS DateTime), NULL, N'8d1f3649-7cee-4017-bc0c-19e213495f15', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'83da4c5c-77d8-4ebe-827c-888e8111653c', N'PRD281222-1132', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'', 0, CAST(N'2022-12-28 11:30:00.000' AS DateTime), CAST(N'2022-12-28 15:30:00.000' AS DateTime), CAST(N'2022-12-28 11:32:32.000' AS DateTime), NULL, 1500, NULL, NULL, N'Stopped', NULL, NULL, CAST(N'2022-12-28 11:29:55.000' AS DateTime), NULL, N'0e893194-6903-4517-9819-a1afbbccc1af', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'01dbc45f-592e-4536-a0b5-9f65b2de42c3', NULL, N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Test 3', 0, CAST(N'2022-12-09 01:00:00.000' AS DateTime), CAST(N'2022-12-09 05:15:00.000' AS DateTime), NULL, NULL, 1200, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-09 11:05:11.000' AS DateTime), NULL, N'955212a5-3862-4a0b-a303-68b1ac877401', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'75a7449a-4173-4cca-a3f9-be1ad16bd956', NULL, N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'', 0, CAST(N'2022-12-28 14:30:00.000' AS DateTime), CAST(N'2022-12-28 17:35:00.000' AS DateTime), NULL, NULL, 750, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-28 11:31:11.000' AS DateTime), NULL, N'0e893194-6903-4517-9819-a1afbbccc1af', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5273850f-a8e3-44d3-a9e4-c86f53c9bded', N'PRD131222-1650', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'tt', 0, CAST(N'2022-12-13 01:13:00.000' AS DateTime), CAST(N'2022-12-13 05:45:00.000' AS DateTime), CAST(N'2022-12-13 16:50:57.000' AS DateTime), NULL, 1500, NULL, NULL, N'Stopped', NULL, NULL, CAST(N'2022-12-13 14:51:23.000' AS DateTime), NULL, N'e18da215-3677-48db-8928-3a8e7273a86e', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'bb5e3b1c-2677-47f6-aa7f-cbef3a2ef479', NULL, N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Test', 0, CAST(N'2022-12-07 19:00:00.000' AS DateTime), CAST(N'2022-12-07 22:00:00.000' AS DateTime), NULL, NULL, 40, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-07 17:33:27.000' AS DateTime), NULL, N'd17dd3af-3a9e-4d08-8638-039cb36581bd', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Model A', 0, CAST(N'2023-01-25 15:55:00.000' AS DateTime), CAST(N'2023-01-25 17:20:00.000' AS DateTime), CAST(N'2023-01-25 15:56:05.000' AS DateTime), NULL, 1500, NULL, 478, N'Started', NULL, NULL, CAST(N'2023-01-25 15:55:55.000' AS DateTime), NULL, N'f7b93afc-bb71-4653-8907-778e5e3f23ca', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7ed4c504-09d6-4764-95de-daffc17979fd', NULL, N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Test 1', 0, CAST(N'2022-12-08 17:20:00.000' AS DateTime), CAST(N'2022-12-08 18:20:00.000' AS DateTime), NULL, NULL, 1200, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-08 17:24:04.000' AS DateTime), NULL, N'e6ac1570-92c1-4756-a248-b1f36ba90682', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'6edd312f-ea19-4e7c-965d-dbfbba27658d', N'PRD131222-1403', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Desc', 0, CAST(N'2022-12-13 10:00:00.000' AS DateTime), CAST(N'2022-12-13 13:00:00.000' AS DateTime), CAST(N'2022-12-13 14:03:41.000' AS DateTime), CAST(N'2022-12-13 16:50:43.000' AS DateTime), 1200, NULL, NULL, N'Completed', NULL, NULL, CAST(N'2022-12-13 09:49:11.000' AS DateTime), NULL, N'b52a44be-52a8-4cbb-894c-6aea4b19d674', NULL, N'Y')
INSERT [dbo].[Schedule] ([ScheduleID], [ProductionId], [LineID], [MasterModelID], [ModelID], [NCDataID], [Version], [SeqNo], [EstStart], [EstEnd], [ActualStart], [ActualEnd], [PlannedQty], [ExpectedQty], [ActualQty], [ProductionStatus], [InsertionError], [CurrentErrorType], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'534dbce1-2d2c-4cbb-b583-f61bea34cf03', NULL, N'2b30ff77-5127-4c58-b4e8-695338016b64', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', NULL, N'Test 4', 0, CAST(N'2022-12-09 02:34:00.000' AS DateTime), CAST(N'2022-12-09 06:20:00.000' AS DateTime), NULL, NULL, 3000, NULL, NULL, N'Pending', NULL, NULL, CAST(N'2022-12-09 11:34:39.000' AS DateTime), NULL, N'01f91f5f-500a-477b-8477-d4f5d2064047', NULL, N'Y')
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:50:16.000' AS DateTime), N'86be0f8a-b16d-43b5-acce-916ac126fbf2', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:50:16.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:51:34.000' AS DateTime), N'c6b32e44-4774-4278-a912-b0b0f6ba95a7', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:51:34.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:51:35.000' AS DateTime), N'6d90a0a2-29b3-476c-9cb6-a58ec7bc464e', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:51:35.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:52:21.000' AS DateTime), N'5a8ff264-4dfb-47b6-9fb9-93085e61bda7', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:52:21.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:54:17.000' AS DateTime), N'd0b395f4-95fe-4036-b3e9-91ddd708ca99', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:54:17.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:55:16.000' AS DateTime), N'0f33e80e-ce32-426e-9bac-cc6c209e0b8d', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:55:16.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:57:40.000' AS DateTime), N'5de8c6e8-52b8-4aeb-b4ad-7a5c2c68939e', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:57:40.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:59:06.000' AS DateTime), N'6d7bad65-98d4-4be8-bebc-df7651992f15', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:59:06.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:59:25.000' AS DateTime), N'a970d44e-686b-4d9a-a727-cd40bf14d049', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:59:25.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 15:59:28.000' AS DateTime), N'2a676ec1-062e-4e5a-bfe4-ca83cdc89b69', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 15:59:28.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 16:15:04.000' AS DateTime), N'de9b611d-b2db-4224-bff5-a10a97662274', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 16:15:04.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[Traceability] ([TDate], [TraceabilityId], [ProductSerialNo], [ScheduleID], [ProductionId], [LineId], [CreatedDate], [ModifiedDate], [Active], [Status]) VALUES (CAST(N'2023-01-31 17:07:10.000' AS DateTime), N'd0654b56-6737-4bd6-8c5c-abb54bc7f667', N'9785015320008', N'4bc47e2a-b3d3-4574-ac1e-d55e6d095ed5', N'PRD250123-1556', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', CAST(N'2023-01-31 17:07:10.000' AS DateTime), NULL, N'1', 0)
INSERT [dbo].[UserMaster] ([UserMasterID], [UserName], [EmployeeName], [Password], [UserGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cbe1ab90-ac22-4203-b795-2f478a143686', N'Admin', N'Admin', N'123', N'cbe1ab90-ac22-4203-b795-2f478a143686', CAST(N'2022-11-16 17:25:32.000' AS DateTime), NULL, N'cbe1ab90-ac22-4203-b795-2f478a143686', NULL, N'Y')
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

USE [PCC]
GO
/****** Object:  Table [dbo].[ActivityLog]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[Line]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[LineDetail]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[LineGroup]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[MasterBOM]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[MasterModel]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[MasterPartList]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[MasterStation]    Script Date: 12/1/2022 4:59:48 PM ******/
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
	[Active] [nchar](1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Model]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[Part]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[Schedule]    Script Date: 12/1/2022 4:59:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ScheduleID] [uniqueidentifier] NOT NULL,
	[LineID] [uniqueidentifier] NOT NULL,
	[ModelID] [uniqueidentifier] NOT NULL,
	[NCDataID] [uniqueidentifier] NULL,
	[Version] [nvarchar](5) NOT NULL,
	[SeqNo] [int] NOT NULL,
	[EstStart] [datetime] NULL,
	[EstEnd] [datetime] NULL,
	[ActualStart] [datetime] NULL,
	[ActualEnd] [datetime] NULL,
	[PlannedQty] [int] NULL,
	[ExpectedQty] [int] NULL,
	[ActualQty] [int] NULL,
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
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ScheduleDetail]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[UserGroup]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[UserGroupFunction]    Script Date: 12/1/2022 4:59:48 PM ******/
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
/****** Object:  Table [dbo].[UserMaster]    Script Date: 12/1/2022 4:59:48 PM ******/
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
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'c5c8b43f-6b63-4857-9be8-4ff7e4e1afa4', N'Diod', N'e6f35430-cbe6-4b17-bad4-01def45d2865', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-11-29 15:39:53.000' AS DateTime), NULL, N'53a3dd47-5536-48f6-8c68-e1a2ffdcfa85', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'7c9bb62f-dafb-440d-ba28-e13e00da82bc', N'Resistor', N'1250236d-778d-4ce5-9fce-0794fb41f19e', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', 1, CAST(N'2022-11-29 15:43:24.000' AS DateTime), NULL, N'53a3dd47-5536-48f6-8c68-e1a2ffdcfa85', NULL, N'Y')
INSERT [dbo].[MasterBOM] ([MasterBOMId], [AssemblyRef], [PartID], [MasterModelID], [ModelID], [LineID], [MasterStationId], [Insertion], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'339e102e-97b0-455c-a9fa-5260cae70355', N'', N'985c797c-7035-4dc3-b2c6-1656ea36f298', N'cbe1ab90-ac22-4203-b795-2f478a143686', N'de479b44-9b63-41da-ac46-96b023469785', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', N'9699cd39-c22c-40d0-87ad-a84f4e18364f', 1, CAST(N'2022-11-29 15:50:26.000' AS DateTime), NULL, N'0cb4a1d0-539b-42bc-af78-bd3bf47361a7', NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'cbe1ab90-ac22-4203-b795-2f478a143686', N'TP4', NULL, CAST(N'2022-11-16 17:25:32.000' AS DateTime), NULL, N'9e7bdd7c-de8f-4bcc-a4a0-0858f29b4074', NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'b606bb42-3b0a-4755-b6eb-a6ef5314ac6a', N'TP9', NULL, CAST(N'2022-11-16 17:25:57.000' AS DateTime), CAST(N'2022-11-21 15:42:10.000' AS DateTime), N'2df97188-47a2-4d5f-afdc-ce1e4e8bc1df', N'31868519-0602-4d68-9a3f-18d2b8f456ce', N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'2aa58fda-9505-452d-94c8-ac95c8d4fb78', N'TP8', NULL, CAST(N'2022-11-16 17:26:46.000' AS DateTime), NULL, N'b7420598-4e1b-4c53-a0fd-e0df45530b1f', NULL, N'Y')
INSERT [dbo].[MasterModel] ([MasterModelID], [MasterModelCode], [ModelGroupID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', N'TP3', NULL, CAST(N'2022-11-16 17:20:38.000' AS DateTime), NULL, N'bdf00458-7923-40fa-9506-2f1be449cd35', NULL, N'Y')
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'dd0fce1f-d3fd-43dd-96e2-840d9a7d8e23', N'E1', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 1, CAST(N'2022-11-29 09:21:31.000' AS DateTime), NULL, N'7bc9aa81-b1dc-43f1-8452-ae96d2c1d45f', NULL, N'Y')
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9699cd39-c22c-40d0-87ad-a84f4e18364f', N'E4', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 2, CAST(N'2022-11-29 09:35:04.000' AS DateTime), NULL, N'04cb7bf6-185b-4c88-8a93-2b2be67e3833', NULL, N'Y')
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'5365d0c8-4c41-4a91-a51f-c58db594a457', N'E5', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 3, CAST(N'2022-11-29 09:35:26.000' AS DateTime), NULL, N'04cb7bf6-185b-4c88-8a93-2b2be67e3833', NULL, N'Y')
INSERT [dbo].[MasterStation] ([MasterStationId], [MasterStationCode], [LineID], [StationNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'9295e6f8-d2ba-485e-ba04-f6ca8aa81905', N'E6', N'a0efe197-e2d5-40f4-93e0-51b15d30312d', 4, CAST(N'2022-11-29 09:36:30.000' AS DateTime), NULL, N'04cb7bf6-185b-4c88-8a93-2b2be67e3833', NULL, N'Y')
INSERT [dbo].[Model] ([ModelID], [ModelCode], [ModelDesciption], [MasterModelID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'fe9aaa80-fa1d-4bd9-b0e5-7f4041f2f9ec', N'TP3MAXXX', N'TP3MAA', N'fd8337d1-56ef-470b-ae4c-c35ff7f3317a', CAST(N'2022-11-21 15:55:31.000' AS DateTime), CAST(N'2022-11-21 16:18:19.000' AS DateTime), N'826c7bf5-687c-4f62-9531-34c25b0e055e', N'a181822a-aa11-4b6d-b4b9-7aff293f57a6', N'Y')
INSERT [dbo].[Model] ([ModelID], [ModelCode], [ModelDesciption], [MasterModelID], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'de479b44-9b63-41da-ac46-96b023469785', N'Test1', NULL, N'de479b44-9b63-41da-ac46-96b023469785', NULL, NULL, NULL, NULL, N'Y')
INSERT [dbo].[Part] ([PartID], [PartNo], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy], [Active]) VALUES (N'e6f35430-cbe6-4b17-bad4-01def45d2865', N'K1KY03BA0799', CAST(N'2022-11-24 11:46:01.000' AS DateTime), NULL, N'bc02be41-3a51-4453-a403-140e3f4ec651', NULL, N'Y')
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

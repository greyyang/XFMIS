USE [MISDB]
GO
/****** Object:  Table [dbo].[Tab_StateRecord]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_StateRecord](
	[SR_ID] [int] IDENTITY(1,1) NOT NULL,
	[SR_ProjectID] [int] NOT NULL,
	[SR_Modifier] [varchar](50) NULL,
	[SR_Date] [date] NULL,
	[SR_Memo] [varchar](500) NULL,
	[SR_Sub] [int] NULL,
	[SR_Flag] [int] NULL,
 CONSTRAINT [PK_TAB_STATERECORD] PRIMARY KEY CLUSTERED 
(
	[SR_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态修改记录ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord', @level2type=N'COLUMN',@level2name=N'SR_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'关联项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord', @level2type=N'COLUMN',@level2name=N'SR_ProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord', @level2type=N'COLUMN',@level2name=N'SR_Modifier'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态修改日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord', @level2type=N'COLUMN',@level2name=N'SR_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态修改记录备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord', @level2type=N'COLUMN',@level2name=N'SR_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主子工程区分，主工程为1,子工程为0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord', @level2type=N'COLUMN',@level2name=N'SR_Sub'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主子工程判断(0为主工程,1为子工程)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord', @level2type=N'COLUMN',@level2name=N'SR_Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工程状态记录' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_StateRecord'
GO
/****** Object:  Table [dbo].[Tab_ProjectState]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_ProjectState](
	[PS_ID] [int] IDENTITY(1,1) NOT NULL,
	[PS_Value] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_PROJECTSTATE] PRIMARY KEY NONCLUSTERED 
(
	[PS_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工程状态主键-工程状态ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectState', @level2type=N'COLUMN',@level2name=N'PS_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工程状态具体数值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectState', @level2type=N'COLUMN',@level2name=N'PS_Value'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工程状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectState'
GO
/****** Object:  Table [dbo].[Tab_ProjectInfo]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_ProjectInfo](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_NO] [varchar](50) NULL,
	[P_Name] [varchar](100) NULL,
	[P_Construction] [varchar](100) NULL,
	[P_Builder] [varchar](100) NULL,
	[P_State] [varchar](50) NULL,
	[P_Customer] [varchar](50) NULL,
	[P_Category] [varchar](50) NULL,
	[P_BusinessPlan] [varchar](50) NULL,
	[P_DateTime] [datetime] NULL,
	[P_ContractAmount] [decimal](15, 2) NULL,
	[P_Auditors] [decimal](15, 2) NULL,
	[P_Allocation] [decimal](15, 2) NULL,
	[P_Plan] [decimal](15, 2) NULL,
	[P_Ratio] [decimal](15, 4) NULL,
	[P_Disclosure] [datetime] NULL,
	[P_StartDate] [datetime] NULL,
	[P_EndDate] [datetime] NULL,
	[P_DesignChange] [int] NULL,
	[P_DataIn] [int] NULL,
	[P_Completion] [varchar](50) NULL,
	[P_Manager] [varchar](50) NULL,
	[P_Tel] [varchar](50) NULL,
	[P_TeleComNO] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_PROJECTINFO] PRIMARY KEY NONCLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程主键-主工程ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_NO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程建设单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Construction'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程施工单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Builder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户纬度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Customer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程经营方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_BusinessPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程立项时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程合同金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_ContractAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主项目审计金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Auditors'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主项目分包计划' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Allocation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主项目成本计划' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Plan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主项目成本占收比' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Ratio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程技术交底' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Disclosure'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程开工日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_StartDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程完工日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程是否有设计变更' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_DesignChange'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程资源是否录入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_DataIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程竣工资料状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Completion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程项目经理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Manager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程项目经理联系方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_Tel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程电信公司合同号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo', @level2type=N'COLUMN',@level2name=N'P_TeleComNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectInfo'
GO
/****** Object:  Table [dbo].[Tab_ProjectCategory]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_ProjectCategory](
	[PC_ID] [int] IDENTITY(1,1) NOT NULL,
	[PC_Name] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_PROJECTCATEGORY] PRIMARY KEY NONCLUSTERED 
(
	[PC_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工程类别主键-工程类别ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectCategory', @level2type=N'COLUMN',@level2name=N'PC_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工程类别名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectCategory', @level2type=N'COLUMN',@level2name=N'PC_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工程类别管理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_ProjectCategory'
GO
/****** Object:  Table [dbo].[Tab_SubContractor]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_SubContractor](
	[SC_ID] [int] IDENTITY(1,1) NOT NULL,
	[SC_Name] [varchar](100) NULL,
	[SC_BankAccount] [varchar](50) NULL,
	[SC_Bank] [varchar](50) NULL,
	[SC_Contactor] [varchar](50) NULL,
	[SC_Tel] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_SUBCONTRACTOR] PRIMARY KEY NONCLUSTERED 
(
	[SC_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位主键-分包单位ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubContractor', @level2type=N'COLUMN',@level2name=N'SC_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubContractor', @level2type=N'COLUMN',@level2name=N'SC_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位银行帐号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubContractor', @level2type=N'COLUMN',@level2name=N'SC_BankAccount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位开户行' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubContractor', @level2type=N'COLUMN',@level2name=N'SC_Bank'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位联系人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubContractor', @level2type=N'COLUMN',@level2name=N'SC_Contactor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位联系方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubContractor', @level2type=N'COLUMN',@level2name=N'SC_Tel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubContractor'
GO
/****** Object:  Table [dbo].[Tab_BusinessMode]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_BusinessMode](
	[BP_ID] [int] IDENTITY(1,1) NOT NULL,
	[BP_Value] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_BUSINESSMODE] PRIMARY KEY NONCLUSTERED 
(
	[BP_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经营方式主键-经营方式ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BusinessMode', @level2type=N'COLUMN',@level2name=N'BP_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经营方式数值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BusinessMode', @level2type=N'COLUMN',@level2name=N'BP_Value'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经营方式管理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BusinessMode'
GO
/****** Object:  Table [dbo].[Tab_Customer]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_Customer](
	[CU_ID] [int] IDENTITY(1,1) NOT NULL,
	[CU_Value] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_CUSTOMER] PRIMARY KEY NONCLUSTERED 
(
	[CU_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户纬度主键-客户纬度ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Customer', @level2type=N'COLUMN',@level2name=N'CU_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户纬度数值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Customer', @level2type=N'COLUMN',@level2name=N'CU_Value'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户纬度管理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Customer'
GO
/****** Object:  Table [dbo].[Tab_Image]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tab_Image](
	[TI_ID] [int] NULL,
	[TI_ProjectID] [int] NULL,
	[TI_SubProjectID] [int] NULL,
	[TI_NO] [int] NULL,
	[TI_Image] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同图片ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Image', @level2type=N'COLUMN',@level2name=N'TI_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'关联主项目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Image', @level2type=N'COLUMN',@level2name=N'TI_ProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'关联子项目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Image', @level2type=N'COLUMN',@level2name=N'TI_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所对应项目中的顺序编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Image', @level2type=N'COLUMN',@level2name=N'TI_NO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片文件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Image', @level2type=N'COLUMN',@level2name=N'TI_Image'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同图片表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Image'
GO
/****** Object:  Table [dbo].[Tab_Material]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_Material](
	[M_ID] [int] IDENTITY(1,1) NOT NULL,
	[M_Name] [varchar](100) NULL,
	[M_Type] [varchar](100) NULL,
	[M_Unit] [varchar](50) NULL,
	[M_Code] [varchar](50) NULL,
	[M_Memo] [varchar](500) NULL,
	[M_Class] [varchar](100) NULL,
	[M_Count] [decimal](10, 2) NULL,
 CONSTRAINT [PK_TAB_MATERIAL] PRIMARY KEY NONCLUSTERED 
(
	[M_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料清单主键-材料ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material', @level2type=N'COLUMN',@level2name=N'M_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material', @level2type=N'COLUMN',@level2name=N'M_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料型号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material', @level2type=N'COLUMN',@level2name=N'M_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material', @level2type=N'COLUMN',@level2name=N'M_Unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料代号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material', @level2type=N'COLUMN',@level2name=N'M_Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material', @level2type=N'COLUMN',@level2name=N'M_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material', @level2type=N'COLUMN',@level2name=N'M_Class'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料清单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Material'
GO
/****** Object:  Table [dbo].[Tab_Users]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_Users](
	[U_ID] [int] IDENTITY(1,1) NOT NULL,
	[U_Account] [varchar](50) NULL,
	[U_Password] [varchar](50) NULL,
	[U_Name] [varchar](50) NULL,
	[U_Depart] [varchar](50) NULL,
	[U_Privilege] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_USERS] PRIMARY KEY NONCLUSTERED 
(
	[U_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户主键-用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Users', @level2type=N'COLUMN',@level2name=N'U_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户帐号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Users', @level2type=N'COLUMN',@level2name=N'U_Account'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Users', @level2type=N'COLUMN',@level2name=N'U_Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Users', @level2type=N'COLUMN',@level2name=N'U_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Users', @level2type=N'COLUMN',@level2name=N'U_Depart'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Users', @level2type=N'COLUMN',@level2name=N'U_Privilege'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户表单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Users'
GO
/****** Object:  Table [dbo].[Tab_SubProjectInfo]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_SubProjectInfo](
	[SP_ID] [int] IDENTITY(1,1) NOT NULL,
	[SP_ProjectID] [int] NOT NULL,
	[SP_NO] [varchar](50) NULL,
	[SP_Name] [varchar](100) NULL,
	[SP_State] [varchar](50) NULL,
	[SP_Date] [datetime] NULL,
	[SP_ContractAmount] [decimal](15, 2) NULL,
	[SP_Auditors] [decimal](15, 2) NULL,
	[SP_Ratio] [decimal](15, 4) NULL,
	[SP_Allocation] [decimal](15, 2) NULL,
	[SP_Manager] [varchar](50) NULL,
	[SP_Tel] [varchar](50) NULL,
 CONSTRAINT [PK_TAB_SUBPROJECTINFO] PRIMARY KEY NONCLUSTERED 
(
	[SP_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目主键-子项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主工程主键-主工程ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_ProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_NO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目添加日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目合同金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_ContractAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目审计金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_Auditors'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目成本占收比' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_Ratio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目分包计划' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_Allocation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目经理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_Manager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目经理联系方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo', @level2type=N'COLUMN',@level2name=N'SP_Tel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子工程信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_SubProjectInfo'
GO
/****** Object:  Table [dbo].[Tab_Storage]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_Storage](
	[St_ID] [int] IDENTITY(1,1) NOT NULL,
	[St_SubProjectID] [int] NULL,
	[St_Material] [varchar](100) NULL,
	[St_Count] [decimal](10, 1) NULL,
 CONSTRAINT [PK_TAB_STORAGE] PRIMARY KEY NONCLUSTERED 
(
	[St_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'仓库主键-仓库ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Storage', @level2type=N'COLUMN',@level2name=N'St_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'仓库外键-关联子项目编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Storage', @level2type=N'COLUMN',@level2name=N'St_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Storage', @level2type=N'COLUMN',@level2name=N'St_Material'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Storage', @level2type=N'COLUMN',@level2name=N'St_Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料仓库' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Storage'
GO
/****** Object:  Table [dbo].[Tab_Payment]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_Payment](
	[PY_ID] [int] IDENTITY(1,1) NOT NULL,
	[PY_SubProjectID] [int] NULL,
	[PY_DateTIme] [datetime] NULL,
	[PY_WorkOrder] [varchar](50) NULL,
	[PY_Billing] [decimal](15, 2) NULL,
	[PY_Payment] [decimal](15, 2) NULL,
	[PY_PayCompany] [varchar](100) NULL,
	[PY_Memo] [varchar](500) NULL,
	[PY_Flag] [int] NULL,
 CONSTRAINT [PK_TAB_PAYMENT] PRIMARY KEY NONCLUSTERED 
(
	[PY_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票回款明细主键-开票回款ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票回款外键-关联子项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票回款时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_DateTIme'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票回款工单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_WorkOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_Billing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'回款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_Payment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付款单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_PayCompany'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票回款标识(0-开票,1-回款)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment', @level2type=N'COLUMN',@level2name=N'PY_Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开票回款明细' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Payment'
GO
/****** Object:  Table [dbo].[Tab_MaterialFlow]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_MaterialFlow](
	[MF_ID] [int] IDENTITY(1,1) NOT NULL,
	[MF_SubProjectID] [int] NULL,
	[MF_Project] [int] NULL,
	[MF_Amount] [decimal](10, 2) NULL,
	[MF_Flag] [int] NULL,
	[MF_MaterialID] [int] NULL,
	[MF_Datetime] [datetime] NULL,
	[MF_Memo] [varchar](500) NULL,
 CONSTRAINT [PK_TAB_MATERIALFLOW] PRIMARY KEY CLUSTERED 
(
	[MF_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'仓库流水ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'子项目主键-子项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'关联的主项目ID(非外键)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_Project'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'进出数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'表示进出的判断值(1为入库,0为出库)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_MaterialID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_Datetime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'注释' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow', @level2type=N'COLUMN',@level2name=N'MF_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'材料进出仓库流水' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_MaterialFlow'
GO
/****** Object:  Table [dbo].[Tab_LoanRepay]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_LoanRepay](
	[LR_ID] [int] IDENTITY(1,1) NOT NULL,
	[LR_SubProjectID] [int] NULL,
	[LR_DateTime] [datetime] NULL,
	[LR_WorkOrder] [varchar](50) NULL,
	[LR_Loan] [decimal](15, 2) NULL,
	[LR_Repay] [decimal](15, 2) NULL,
	[LR_Handler] [varchar](50) NULL,
	[LR_Person] [varchar](50) NULL,
	[LR_BankNO] [varchar](50) NULL,
	[LR_Memo] [varchar](500) NULL,
	[LR_Flag] [int] NULL,
 CONSTRAINT [PK_TAB_LOANREPAY] PRIMARY KEY NONCLUSTERED 
(
	[LR_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借还款明细主键-借还款ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借还款明细外键-子工程ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借还款日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借还款工单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_WorkOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_Loan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'还款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_Repay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_Handler'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借还款人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_Person'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行帐号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_BankNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借还款标识(0-借款,1-还款)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay', @level2type=N'COLUMN',@level2name=N'LR_Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借还款明细' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_LoanRepay'
GO
/****** Object:  Table [dbo].[Tab_Deal]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_Deal](
	[DL_ID] [int] IDENTITY(1,1) NOT NULL,
	[DL_SubProjectID] [int] NULL,
	[DL_Manager] [varchar](50) NULL,
	[DL_Company] [varchar](100) NULL,
	[DL_Moeny] [decimal](15, 2) NULL,
	[DL_Start] [datetime] NULL,
	[DL_End] [datetime] NULL,
	[DL_State] [varchar](50) NULL,
	[DL_Date] [datetime] NULL,
 CONSTRAINT [PK_TAB_DEAL] PRIMARY KEY NONCLUSTERED 
(
	[DL_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内部协议主键-内部协议ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内部协议外键-关联子项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目经理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_Manager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_Company'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分包费用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_Moeny'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'计划开工时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_Start'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'计划完工时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_End'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'协议状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'协议添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal', @level2type=N'COLUMN',@level2name=N'DL_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内部协议' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Deal'
GO
/****** Object:  Table [dbo].[Tab_CostAndReimburse]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_CostAndReimburse](
	[CR_ID] [int] IDENTITY(1,1) NOT NULL,
	[CR_SubProjectID] [int] NULL,
	[CR_DateTime] [datetime] NULL,
	[CR_WorkOrder] [varchar](50) NULL,
	[CR_Amount] [decimal](15, 2) NULL,
	[CR_ManagerialFee] [decimal](15, 2) NULL,
	[CR_BackAmount] [decimal](15, 2) NULL,
	[CR_Person] [varchar](50) NULL,
	[CR_Handler] [varchar](100) NULL,
	[CR_Memo] [varchar](500) NULL,
	[CR_Flag] [int] NULL,
 CONSTRAINT [PK_TAB_COSTANDREIMBURSE] PRIMARY KEY NONCLUSTERED 
(
	[CR_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账表单主键-成本报账表单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账表单外键-关联子项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账记录创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账记录工单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_WorkOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账表单-成本金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账表单-管理费' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_ManagerialFee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账表单-拨付金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_BackAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_Person'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_Handler'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账表单-备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'种类标识(0-成本,1-报账,2-管理费)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse', @level2type=N'COLUMN',@level2name=N'CR_Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'成本报账明细' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_CostAndReimburse'
GO
/****** Object:  Table [dbo].[Tab_BuildCompany]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_BuildCompany](
	[BC_ID] [int] IDENTITY(1,1) NOT NULL,
	[BC_SubProjectID] [int] NULL,
	[BC_Name] [varchar](100) NULL,
	[BC_Work] [varchar](500) NULL,
	[BC_Contactor] [varchar](50) NULL,
	[BC_Tel] [varchar](50) NULL,
	[BC_Memo] [varchar](500) NULL,
 CONSTRAINT [PK_TAB_BUILDCOMPANY] PRIMARY KEY NONCLUSTERED 
(
	[BC_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位主键-施工单位ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany', @level2type=N'COLUMN',@level2name=N'BC_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位外键-关联子项目序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany', @level2type=N'COLUMN',@level2name=N'BC_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany', @level2type=N'COLUMN',@level2name=N'BC_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位主要工作量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany', @level2type=N'COLUMN',@level2name=N'BC_Work'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位联系人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany', @level2type=N'COLUMN',@level2name=N'BC_Contactor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位联系人电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany', @level2type=N'COLUMN',@level2name=N'BC_Tel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany', @level2type=N'COLUMN',@level2name=N'BC_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_BuildCompany'
GO
/****** Object:  Table [dbo].[Tab_Balance]    Script Date: 12/23/2013 21:54:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tab_Balance](
	[BL_ID] [int] IDENTITY(1,1) NOT NULL,
	[BL_SubProjectID] [int] NULL,
	[BL_DateTime] [datetime] NULL,
	[BL_WorkOrder] [varchar](50) NULL,
	[BL_Pay] [decimal](15, 2) NULL,
	[BL_PayCompany] [varchar](100) NULL,
	[BL_Handler] [varchar](50) NULL,
	[BL_BankNO] [varchar](50) NULL,
	[BL_Memo] [varchar](500) NULL,
 CONSTRAINT [PK_TAB_BALANCE] PRIMARY KEY NONCLUSTERED 
(
	[BL_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结算明细主键-结算明细ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结算明细外键-关联子工程ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_SubProjectID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结算明细日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结算明细工单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_WorkOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_Pay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付款单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_PayCompany'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_Handler'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行帐号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_BankNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance', @level2type=N'COLUMN',@level2name=N'BL_Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结算明细' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tab_Balance'
GO
/****** Object:  ForeignKey [FK_TAB_BALA_R7_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_Balance]  WITH CHECK ADD  CONSTRAINT [FK_TAB_BALA_R7_TAB_SUBP] FOREIGN KEY([BL_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_Balance] CHECK CONSTRAINT [FK_TAB_BALA_R7_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_BUIL_R5_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_BuildCompany]  WITH CHECK ADD  CONSTRAINT [FK_TAB_BUIL_R5_TAB_SUBP] FOREIGN KEY([BC_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_BuildCompany] CHECK CONSTRAINT [FK_TAB_BUIL_R5_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_COST_R2_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_CostAndReimburse]  WITH CHECK ADD  CONSTRAINT [FK_TAB_COST_R2_TAB_SUBP] FOREIGN KEY([CR_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_CostAndReimburse] CHECK CONSTRAINT [FK_TAB_COST_R2_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_DEAL_R4_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_Deal]  WITH CHECK ADD  CONSTRAINT [FK_TAB_DEAL_R4_TAB_SUBP] FOREIGN KEY([DL_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_Deal] CHECK CONSTRAINT [FK_TAB_DEAL_R4_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_LOAN_R3_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_LoanRepay]  WITH CHECK ADD  CONSTRAINT [FK_TAB_LOAN_R3_TAB_SUBP] FOREIGN KEY([LR_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_LoanRepay] CHECK CONSTRAINT [FK_TAB_LOAN_R3_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_MATE_R9_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_MaterialFlow]  WITH CHECK ADD  CONSTRAINT [FK_TAB_MATE_R9_TAB_SUBP] FOREIGN KEY([MF_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_MaterialFlow] CHECK CONSTRAINT [FK_TAB_MATE_R9_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_PAYM_R6_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_Payment]  WITH CHECK ADD  CONSTRAINT [FK_TAB_PAYM_R6_TAB_SUBP] FOREIGN KEY([PY_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_Payment] CHECK CONSTRAINT [FK_TAB_PAYM_R6_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_STOR_R8_TAB_SUBP]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_Storage]  WITH CHECK ADD  CONSTRAINT [FK_TAB_STOR_R8_TAB_SUBP] FOREIGN KEY([St_SubProjectID])
REFERENCES [dbo].[Tab_SubProjectInfo] ([SP_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_Storage] CHECK CONSTRAINT [FK_TAB_STOR_R8_TAB_SUBP]
GO
/****** Object:  ForeignKey [FK_TAB_SUBP_R1_TAB_PROJ]    Script Date: 12/23/2013 21:54:17 ******/
ALTER TABLE [dbo].[Tab_SubProjectInfo]  WITH CHECK ADD  CONSTRAINT [FK_TAB_SUBP_R1_TAB_PROJ] FOREIGN KEY([SP_ProjectID])
REFERENCES [dbo].[Tab_ProjectInfo] ([P_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tab_SubProjectInfo] CHECK CONSTRAINT [FK_TAB_SUBP_R1_TAB_PROJ]
GO

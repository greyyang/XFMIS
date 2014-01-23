/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2013/11/26 21:48:28                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_Balance') and o.name = 'FK_TAB_BALA_R7_TAB_SUBP')
alter table Tab_Balance
   drop constraint FK_TAB_BALA_R7_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_BuildCompany') and o.name = 'FK_TAB_BUIL_R5_TAB_SUBP')
alter table Tab_BuildCompany
   drop constraint FK_TAB_BUIL_R5_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_CostAndReimburse') and o.name = 'FK_TAB_COST_R2_TAB_SUBP')
alter table Tab_CostAndReimburse
   drop constraint FK_TAB_COST_R2_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_Deal') and o.name = 'FK_TAB_DEAL_R4_TAB_SUBP')
alter table Tab_Deal
   drop constraint FK_TAB_DEAL_R4_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_LoanRepay') and o.name = 'FK_TAB_LOAN_R3_TAB_SUBP')
alter table Tab_LoanRepay
   drop constraint FK_TAB_LOAN_R3_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_MaterialFlow') and o.name = 'FK_TAB_MATE_R9_TAB_SUBP')
alter table Tab_MaterialFlow
   drop constraint FK_TAB_MATE_R9_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_Payment') and o.name = 'FK_TAB_PAYM_R6_TAB_SUBP')
alter table Tab_Payment
   drop constraint FK_TAB_PAYM_R6_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_Storage') and o.name = 'FK_TAB_STOR_R8_TAB_SUBP')
alter table Tab_Storage
   drop constraint FK_TAB_STOR_R8_TAB_SUBP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tab_SubProjectInfo') and o.name = 'FK_TAB_SUBP_R1_TAB_PROJ')
alter table Tab_SubProjectInfo
   drop constraint FK_TAB_SUBP_R1_TAB_PROJ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_Balance')
            and   type = 'U')
   drop table Tab_Balance
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_BuildCompany')
            and   type = 'U')
   drop table Tab_BuildCompany
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_BusinessMode')
            and   type = 'U')
   drop table Tab_BusinessMode
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_CostAndReimburse')
            and   type = 'U')
   drop table Tab_CostAndReimburse
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_Customer')
            and   type = 'U')
   drop table Tab_Customer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_Deal')
            and   type = 'U')
   drop table Tab_Deal
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_LoanRepay')
            and   type = 'U')
   drop table Tab_LoanRepay
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_Material')
            and   type = 'U')
   drop table Tab_Material
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_MaterialFlow')
            and   type = 'U')
   drop table Tab_MaterialFlow
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_Payment')
            and   type = 'U')
   drop table Tab_Payment
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_ProjectCategory')
            and   type = 'U')
   drop table Tab_ProjectCategory
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_ProjectInfo')
            and   type = 'U')
   drop table Tab_ProjectInfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_ProjectState')
            and   type = 'U')
   drop table Tab_ProjectState
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_StateRecord')
            and   type = 'U')
   drop table Tab_StateRecord
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_Storage')
            and   type = 'U')
   drop table Tab_Storage
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_SubContractor')
            and   type = 'U')
   drop table Tab_SubContractor
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_SubProjectInfo')
            and   type = 'U')
   drop table Tab_SubProjectInfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tab_Users')
            and   type = 'U')
   drop table Tab_Users
go

/*==============================================================*/
/* Table: Tab_Balance                                           */
/*==============================================================*/
create table Tab_Balance (
   BL_ID                int                  identity,
   BL_SubProjectID      int                  null,
   BL_DateTime          datetime             null,
   BL_WorkOrder         varchar(50)          null,
   BL_Pay               decimal(15,2)        null,
   BL_PayCompany        varchar(100)         null,
   BL_Handler           varchar(50)          null,
   BL_BankNO            varchar(50)          null,
   BL_Memo              varchar(500)         null,
   constraint PK_TAB_BALANCE primary key nonclustered (BL_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������ϸ',
   'user', @CurrentUser, 'table', 'Tab_Balance'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������ϸ����-������ϸID',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������ϸ���-�����ӹ���ID',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������ϸ����',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_DateTime'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������ϸ������',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_WorkOrder'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_Pay'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���λ',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_PayCompany'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_Handler'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����ʺ�',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_BankNO'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��ע',
   'user', @CurrentUser, 'table', 'Tab_Balance', 'column', 'BL_Memo'
go

/*==============================================================*/
/* Table: Tab_BuildCompany                                      */
/*==============================================================*/
create table Tab_BuildCompany (
   BC_ID                int                  identity,
   BC_SubProjectID      int                  null,
   BC_Name              varchar(100)         null,
   BC_Work              varchar(500)         null,
   BC_Contactor         varchar(50)          null,
   BC_Tel               varchar(50)          null,
   BC_Memo              varchar(500)         null,
   constraint PK_TAB_BUILDCOMPANY primary key nonclustered (BC_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ʩ����λ',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ʩ����λ����-ʩ����λID',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany', 'column', 'BC_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ʩ����λ���-��������Ŀ���',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany', 'column', 'BC_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ʩ����λ����',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany', 'column', 'BC_Name'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ʩ����λ��Ҫ������',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany', 'column', 'BC_Work'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ʩ����λ��ϵ��',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany', 'column', 'BC_Contactor'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ʩ����λ��ϵ�˵绰',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany', 'column', 'BC_Tel'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��ע',
   'user', @CurrentUser, 'table', 'Tab_BuildCompany', 'column', 'BC_Memo'
go

/*==============================================================*/
/* Table: Tab_BusinessMode                                      */
/*==============================================================*/
create table Tab_BusinessMode (
   BP_ID                int                  identity,
   BP_Value             varchar(50)          null,
   constraint PK_TAB_BUSINESSMODE primary key nonclustered (BP_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ӫ��ʽ����',
   'user', @CurrentUser, 'table', 'Tab_BusinessMode'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ӫ��ʽ����-��Ӫ��ʽID',
   'user', @CurrentUser, 'table', 'Tab_BusinessMode', 'column', 'BP_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ӫ��ʽ��ֵ',
   'user', @CurrentUser, 'table', 'Tab_BusinessMode', 'column', 'BP_Value'
go

/*==============================================================*/
/* Table: Tab_CostAndReimburse                                  */
/*==============================================================*/
create table Tab_CostAndReimburse (
   CR_ID                int                  identity,
   CR_SubProjectID      int                  null,
   CR_DateTime          datetime             null,
   CR_WorkOrder         varchar(50)          null,
   CR_Amount            decimal(15,2)        null,
   CR_ManagerialFee     decimal(15,2)        null,
   CR_BackAmount        decimal(15,2)        null,
   CR_BillingUnit       varchar(100)         null,
   CR_Memo              varchar(500)         null,
   constraint PK_TAB_COSTANDREIMBURSE primary key nonclustered (CR_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ�������ϸ',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˱�����-�ɱ����˱�ID',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˱����-��������ĿID',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˼�¼��������',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_DateTime'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˼�¼������',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_WorkOrder'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˱�-��Ʊ���',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_Amount'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˱�-�����',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_ManagerialFee'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˱�-�ؿ���',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_BackAmount'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˱�-��Ʊ��λ',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_BillingUnit'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ɱ����˱�-��ע',
   'user', @CurrentUser, 'table', 'Tab_CostAndReimburse', 'column', 'CR_Memo'
go

/*==============================================================*/
/* Table: Tab_Customer                                          */
/*==============================================================*/
create table Tab_Customer (
   CU_ID                int                  identity,
   CU_Value             varchar(50)          null,
   constraint PK_TAB_CUSTOMER primary key nonclustered (CU_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ͻ�γ�ȹ���',
   'user', @CurrentUser, 'table', 'Tab_Customer'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ͻ�γ������-�ͻ�γ��ID',
   'user', @CurrentUser, 'table', 'Tab_Customer', 'column', 'CU_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ͻ�γ����ֵ',
   'user', @CurrentUser, 'table', 'Tab_Customer', 'column', 'CU_Value'
go

/*==============================================================*/
/* Table: Tab_Deal                                              */
/*==============================================================*/
create table Tab_Deal (
   DL_ID                int                  identity,
   DL_SubProjectID      int                  null,
   DL_Manager           varchar(50)          null,
   DL_Company           varchar(100)         null,
   DL_Moeny             decimal(15,2)        null,
   DL_Start             datetime             null,
   DL_End               datetime             null,
   DL_State             varchar(50)          null,
   DL_Date              datetime             null,
   constraint PK_TAB_DEAL primary key nonclustered (DL_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ڲ�Э��',
   'user', @CurrentUser, 'table', 'Tab_Deal'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ڲ�Э������-�ڲ�Э��ID',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ڲ�Э�����-��������ĿID',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ŀ����',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_Manager'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_Company'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ�����',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_Moeny'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ƻ�����ʱ��',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_Start'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ƻ��깤ʱ��',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_End'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Э��״̬',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_State'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Э�����ʱ��',
   'user', @CurrentUser, 'table', 'Tab_Deal', 'column', 'DL_Date'
go

/*==============================================================*/
/* Table: Tab_LoanRepay                                         */
/*==============================================================*/
create table Tab_LoanRepay (
   LR_ID                int                  identity,
   LR_SubProjectID      int                  null,
   LR_DateTime          datetime             null,
   LR_WorkOrder         varchar(50)          null,
   LR_Loan              decimal(15,2)        null,
   LR_Repay             decimal(15,2)        null,
   LR_Handler           varchar(50)          null,
   LR_Person            varchar(50)          null,
   LR_BankNO            varchar(50)          null,
   LR_Memo              varchar(500)         null,
   constraint PK_TAB_LOANREPAY primary key nonclustered (LR_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�軹����ϸ',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�軹����ϸ����-�軹��ID',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�軹����ϸ���-�ӹ���ID',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�軹������',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_DateTime'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�軹�����',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_WorkOrder'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_Loan'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_Repay'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_Handler'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�軹����',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_Person'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����ʺ�',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_BankNO'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��ע',
   'user', @CurrentUser, 'table', 'Tab_LoanRepay', 'column', 'LR_Memo'
go

/*==============================================================*/
/* Table: Tab_Material                                          */
/*==============================================================*/
create table Tab_Material (
   M_ID                 int                  identity,
   M_Name               varchar(100)         null,
   M_Type               varchar(100)         null,
   M_Unit               varchar(50)          null,
   M_Code               varchar(50)          null,
   M_Memo               varchar(500)         null,
   M_Class              varchar(100)         null,
   M_Count              decimal(10,2)        null,
   constraint PK_TAB_MATERIAL primary key nonclustered (M_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����嵥',
   'user', @CurrentUser, 'table', 'Tab_Material'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����嵥����-����ID',
   'user', @CurrentUser, 'table', 'Tab_Material', 'column', 'M_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��������',
   'user', @CurrentUser, 'table', 'Tab_Material', 'column', 'M_Name'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����ͺ�',
   'user', @CurrentUser, 'table', 'Tab_Material', 'column', 'M_Type'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ϵ�λ',
   'user', @CurrentUser, 'table', 'Tab_Material', 'column', 'M_Unit'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ϴ���',
   'user', @CurrentUser, 'table', 'Tab_Material', 'column', 'M_Code'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ϱ�ע',
   'user', @CurrentUser, 'table', 'Tab_Material', 'column', 'M_Memo'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�������',
   'user', @CurrentUser, 'table', 'Tab_Material', 'column', 'M_Class'
go

/*==============================================================*/
/* Table: Tab_MaterialFlow                                      */
/*==============================================================*/
create table Tab_MaterialFlow (
   MF_ID                int                  identity,
   MF_SubProjectID      int                  null,
   MF_Project           int                  null,
   MF_Amount            decimal(10,2)        null,
   MF_Flag              int                  null,
   MF_MaterialID        int                  null,
   MF_Datetime          datetime             null,
   MF_Memo              varchar(500)         null,
   constraint PK_TAB_MATERIALFLOW primary key (MF_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���Ͻ����ֿ���ˮ',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ֿ���ˮID',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ����-����ĿID',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����������ĿID(�����)',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_Project'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��������',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_Amount'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��ʾ�������ж�ֵ(1Ϊ���,0Ϊ����)',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_Flag'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����ID',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_MaterialID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ʱ��',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_Datetime'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ע��',
   'user', @CurrentUser, 'table', 'Tab_MaterialFlow', 'column', 'MF_Memo'
go

/*==============================================================*/
/* Table: Tab_Payment                                           */
/*==============================================================*/
create table Tab_Payment (
   PY_ID                int                  identity,
   PY_SubProjectID      int                  null,
   PY_DateTIme          datetime             null,
   PY_WorkOrder         varchar(50)          null,
   PY_Billing           decimal(15,2)        null,
   PY_Payment           decimal(15,2)        null,
   PY_PayCompany        varchar(100)         null,
   PY_Memo              varchar(500)         null,
   constraint PK_TAB_PAYMENT primary key nonclustered (PY_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ʊ�ؿ���ϸ',
   'user', @CurrentUser, 'table', 'Tab_Payment'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ʊ�ؿ���ϸ����-��Ʊ�ؿ�ID',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ʊ�ؿ����-��������ĿID',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ʊ�ؿ�ʱ��',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_DateTIme'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ʊ�ؿ����',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_WorkOrder'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Ʊ���',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_Billing'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ؿ���',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_Payment'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���λ',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_PayCompany'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��ע',
   'user', @CurrentUser, 'table', 'Tab_Payment', 'column', 'PY_Memo'
go

/*==============================================================*/
/* Table: Tab_ProjectCategory                                   */
/*==============================================================*/
create table Tab_ProjectCategory (
   PC_ID                int                  identity,
   PC_Name              varchar(50)          null,
   constraint PK_TAB_PROJECTCATEGORY primary key nonclustered (PC_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����������',
   'user', @CurrentUser, 'table', 'Tab_ProjectCategory'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����������-�������ID',
   'user', @CurrentUser, 'table', 'Tab_ProjectCategory', 'column', 'PC_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���������',
   'user', @CurrentUser, 'table', 'Tab_ProjectCategory', 'column', 'PC_Name'
go

/*==============================================================*/
/* Table: Tab_ProjectInfo                                       */
/*==============================================================*/
create table Tab_ProjectInfo (
   P_ID                 int                  identity,
   P_NO                 varchar(50)          null,
   P_Name               varchar(100)         null,
   P_Construction       varchar(100)         null,
   P_Builder            varchar(100)         null,
   P_State              varchar(50)          null,
   P_Customer           varchar(50)          null,
   P_Category           varchar(50)          null,
   P_BusinessPlan       varchar(50)          null,
   P_DateTime           datetime             null,
   P_ContractAmount     decimal(15,2)        null,
   P_Auditors           decimal(15,2)        null,
   P_Plan               decimal(15,2)        null,
   P_Ratio              decimal(15,4)        null,
   P_Disclosure         datetime             null,
   P_StartDate          datetime             null,
   P_EndDate            datetime             null,
   P_DesignChange       int                  null,
   P_DataIn             int                  null,
   P_Completion         varchar(50)          null,
   P_Manager            varchar(50)          null,
   P_Tel                varchar(50)          null,
   P_TeleComNO          varchar(50)          null,
   constraint PK_TAB_PROJECTINFO primary key nonclustered (P_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��������Ϣ',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����������-������ID',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̱��',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_NO'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����������',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Name'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̽��赥λ',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Construction'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������ʩ����λ',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Builder'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������״̬',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_State'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ͻ�γ��',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Customer'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���������',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Category'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̾�Ӫ��ʽ',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_BusinessPlan'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����������ʱ��',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_DateTime'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̺�ͬ���',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_ContractAmount'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ��ƽ��',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Auditors'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ�ɱ��ƻ�',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Plan'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ�ɱ�ռ�ձ�',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Ratio'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̼�������',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Disclosure'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̿�������',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_StartDate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�������깤����',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_EndDate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�������Ƿ�����Ʊ��',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_DesignChange'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��������Դ�Ƿ�¼��',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_DataIn'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̿�������״̬',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Completion'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��������Ŀ����',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Manager'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��������Ŀ������ϵ��ʽ',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_Tel'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�����̵��Ź�˾��ͬ��',
   'user', @CurrentUser, 'table', 'Tab_ProjectInfo', 'column', 'P_TeleComNO'
go

/*==============================================================*/
/* Table: Tab_ProjectState                                      */
/*==============================================================*/
create table Tab_ProjectState (
   PS_ID                int                  identity,
   PS_Value             varchar(50)          null,
   constraint PK_TAB_PROJECTSTATE primary key nonclustered (PS_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����״̬',
   'user', @CurrentUser, 'table', 'Tab_ProjectState'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����״̬����-����״̬ID',
   'user', @CurrentUser, 'table', 'Tab_ProjectState', 'column', 'PS_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����״̬������ֵ',
   'user', @CurrentUser, 'table', 'Tab_ProjectState', 'column', 'PS_Value'
go

/*==============================================================*/
/* Table: Tab_StateRecord                                       */
/*==============================================================*/
create table Tab_StateRecord (
   SR_ID                int                  identity,
   SR_ProjectID         int                  not null,
   SR_Modifier          varchar(50)          null,
   SR_Date              date                 null,
   SR_Memo              varchar(500)         null,
   SR_Sub               int                  null,
   SR_Flag              int                  null,
   constraint PK_TAB_STATERECORD primary key (SR_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����״̬��¼',
   'user', @CurrentUser, 'table', 'Tab_StateRecord'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '״̬�޸ļ�¼ID',
   'user', @CurrentUser, 'table', 'Tab_StateRecord', 'column', 'SR_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������ĿID',
   'user', @CurrentUser, 'table', 'Tab_StateRecord', 'column', 'SR_ProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '״̬�޸���',
   'user', @CurrentUser, 'table', 'Tab_StateRecord', 'column', 'SR_Modifier'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '״̬�޸�����',
   'user', @CurrentUser, 'table', 'Tab_StateRecord', 'column', 'SR_Date'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '״̬�޸ļ�¼��ע',
   'user', @CurrentUser, 'table', 'Tab_StateRecord', 'column', 'SR_Memo'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ӹ������֣�������Ϊ1,�ӹ���Ϊ0',
   'user', @CurrentUser, 'table', 'Tab_StateRecord', 'column', 'SR_Sub'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ӹ����ж�(0Ϊ������,1Ϊ�ӹ���)',
   'user', @CurrentUser, 'table', 'Tab_StateRecord', 'column', 'SR_Flag'
go

/*==============================================================*/
/* Table: Tab_Storage                                           */
/*==============================================================*/
create table Tab_Storage (
   St_ID                int                  identity,
   St_SubProjectID      int                  null,
   St_Material          varchar(100)         null,
   St_Count             decimal(10,1)        null,
   constraint PK_TAB_STORAGE primary key nonclustered (St_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ϲֿ�',
   'user', @CurrentUser, 'table', 'Tab_Storage'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ֿ�����-�ֿ�ID',
   'user', @CurrentUser, 'table', 'Tab_Storage', 'column', 'St_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ֿ����-��������Ŀ���',
   'user', @CurrentUser, 'table', 'Tab_Storage', 'column', 'St_SubProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����',
   'user', @CurrentUser, 'table', 'Tab_Storage', 'column', 'St_Material'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����',
   'user', @CurrentUser, 'table', 'Tab_Storage', 'column', 'St_Count'
go

/*==============================================================*/
/* Table: Tab_SubContractor                                     */
/*==============================================================*/
create table Tab_SubContractor (
   SC_ID                int                  identity,
   SC_Name              varchar(100)         null,
   SC_BankAccount       varchar(50)          null,
   SC_Bank              varchar(50)          null,
   SC_Contactor         varchar(50)          null,
   SC_Tel               varchar(50)          null,
   constraint PK_TAB_SUBCONTRACTOR primary key nonclustered (SC_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ��Ϣ',
   'user', @CurrentUser, 'table', 'Tab_SubContractor'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ����-�ְ���λID',
   'user', @CurrentUser, 'table', 'Tab_SubContractor', 'column', 'SC_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ����',
   'user', @CurrentUser, 'table', 'Tab_SubContractor', 'column', 'SC_Name'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ�����ʺ�',
   'user', @CurrentUser, 'table', 'Tab_SubContractor', 'column', 'SC_BankAccount'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ������',
   'user', @CurrentUser, 'table', 'Tab_SubContractor', 'column', 'SC_Bank'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ��ϵ��',
   'user', @CurrentUser, 'table', 'Tab_SubContractor', 'column', 'SC_Contactor'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ְ���λ��ϵ��ʽ',
   'user', @CurrentUser, 'table', 'Tab_SubContractor', 'column', 'SC_Tel'
go

/*==============================================================*/
/* Table: Tab_SubProjectInfo                                    */
/*==============================================================*/
create table Tab_SubProjectInfo (
   SP_ID                int                  identity,
   SP_ProjectID         int                  not null,
   SP_NO                varchar(50)          null,
   SP_Name              varchar(100)         null,
   SP_State             varchar(50)          null,
   SP_Date              datetime             null,
   SP_ContractAmount    decimal(15,2)        null,
   SP_Auditors          decimal(15,2)        null,
   SP_Ratio             decimal(15,4)        null,
   SP_Allocation        decimal(15,2)        null,
   SP_Manager           varchar(50)          null,
   SP_Tel               varchar(50)          null,
   constraint PK_TAB_SUBPROJECTINFO primary key nonclustered (SP_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ӹ�����Ϣ',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ����-����ĿID',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����������-������ID',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_ProjectID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ���',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_NO'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ����',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_Name'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ״̬',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_State'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ�������',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_Date'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ��ͬ���',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_ContractAmount'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ��ƽ��',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_Auditors'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ�ɱ�ռ�ձ�',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_Ratio'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ�ְ��ƻ�',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_Allocation'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ����',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_Manager'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����Ŀ������ϵ��ʽ',
   'user', @CurrentUser, 'table', 'Tab_SubProjectInfo', 'column', 'SP_Tel'
go

/*==============================================================*/
/* Table: Tab_Users                                             */
/*==============================================================*/
create table Tab_Users (
   U_ID                 int                  identity,
   U_Account            varchar(50)          null,
   U_Password           varchar(50)          null,
   U_Name               varchar(50)          null,
   U_Depart             varchar(50)          null,
   U_Privilege          varchar(50)          null,
   constraint PK_TAB_USERS primary key nonclustered (U_ID)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û���',
   'user', @CurrentUser, 'table', 'Tab_Users'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�����-�û�ID',
   'user', @CurrentUser, 'table', 'Tab_Users', 'column', 'U_ID'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û��ʺ�',
   'user', @CurrentUser, 'table', 'Tab_Users', 'column', 'U_Account'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�����',
   'user', @CurrentUser, 'table', 'Tab_Users', 'column', 'U_Password'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�����',
   'user', @CurrentUser, 'table', 'Tab_Users', 'column', 'U_Name'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�����',
   'user', @CurrentUser, 'table', 'Tab_Users', 'column', 'U_Depart'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�Ȩ��',
   'user', @CurrentUser, 'table', 'Tab_Users', 'column', 'U_Privilege'
go

alter table Tab_Balance
   add constraint FK_TAB_BALA_R7_TAB_SUBP foreign key (BL_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_BuildCompany
   add constraint FK_TAB_BUIL_R5_TAB_SUBP foreign key (BC_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_CostAndReimburse
   add constraint FK_TAB_COST_R2_TAB_SUBP foreign key (CR_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_Deal
   add constraint FK_TAB_DEAL_R4_TAB_SUBP foreign key (DL_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_LoanRepay
   add constraint FK_TAB_LOAN_R3_TAB_SUBP foreign key (LR_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_MaterialFlow
   add constraint FK_TAB_MATE_R9_TAB_SUBP foreign key (MF_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_Payment
   add constraint FK_TAB_PAYM_R6_TAB_SUBP foreign key (PY_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_Storage
   add constraint FK_TAB_STOR_R8_TAB_SUBP foreign key (St_SubProjectID)
      references Tab_SubProjectInfo (SP_ID)
         on update cascade on delete cascade
go

alter table Tab_SubProjectInfo
   add constraint FK_TAB_SUBP_R1_TAB_PROJ foreign key (SP_ProjectID)
      references Tab_ProjectInfo (P_ID)
         on update cascade on delete cascade
go


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraTab;
using MISClient.UI.Welcome;
using DevExpress.XtraEditors;
using MISClient.UI.NewProject;
using MISClient.UI.ProjectManagement;
using MISClient.UI.FinanceManagement;
using DevExpress.XtraReports.UserDesigner;

using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraEditors.Controls;
using MISClient.Sinicization;
using MISClient.Kit;

namespace MISClient
{
    public partial class MainFrame : RibbonForm
    {
        public MainFrame()
        {
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font(Font.FontFamily.Name,9);
            InitializeComponent();
            InitSkinGallery();
            InitMdiControl();
            InitOther();
           
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        } 

        void InitMdiControl()
        {
            xtraTabbedMdiManager1.ClosePageButtonShowMode = ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            XtraForm frm = new XtraForm();
            UI_Welcome ui_Welcome = new UI_Welcome();
            ui_Welcome.MdiParent = this;
            ui_Welcome.Show();            
        }
      
        void InitOther()
        {
            GlobeVariable gb = GlobeVariable.getInstance();
            this.si_Name.Caption = gb.username;
            this.si_Dpt.Caption = gb.depart;

        }
        /// <summary>
        /// 新建立项按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_NewProject ui_NewProject = new UI_NewProject();
            
            ui_NewProject.ShowDialog();
        }
        /// <summary>
        /// 项目查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_ProjectSelect ui_ProjectSelect = new UI_ProjectSelect();
            OpenMdiFormActive(ui_ProjectSelect);
        }
        /// <summary>
        /// 立项管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            MISClient.UI.NewProject.UI_ProjectManagement ui_ProjectManagement = new MISClient.UI.NewProject.UI_ProjectManagement();
            OpenMdiFormActive(ui_ProjectManagement);
        }

        /// <summary>
        /// 分包计划按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewPlanning_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_NewPlaning ui_NewPlaning = new UI_NewPlaning();
            OpenMdiFormActive(ui_NewPlaning);
        }

        /// <summary>
        /// 财务管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FinanceManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_FinanceManagement ui_FM = new UI_FinanceManagement();
            OpenMdiFormActive(ui_FM);
        }

        private void btn_usersManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.SystemManagement.UI_UserManagement ui_UM = new UI.SystemManagement.UI_UserManagement();
            OpenMdiFormActive(ui_UM);
        }

        private void btn_ProjectData_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.Report.UI_SubProjectChoose spc = new UI.Report.UI_SubProjectChoose();
            int projectID = 0;
            bool mainOrSubProject = false;//标记用户是需要显示主工程还是子工程的数据

            if (spc.ShowDialog() == DialogResult.OK)
            {
                projectID = spc.projectID;
                mainOrSubProject = spc.mainOrSubProject;
            }
            else
                return;

            UI.Report.UI_ContainerForm cf = new UI.Report.UI_ContainerForm("工程报表", projectID, mainOrSubProject);
            OpenMdiFormActive(cf);
        }

        private void btn_subCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_SubContractor ui_SubContractor = new UI_SubContractor();
            OpenMdiFormActive(ui_SubContractor);
        }
        /// <summary>
        /// 经营方式管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Business_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_BusinessMode ui_BusinessMode = new UI_BusinessMode();
            ui_BusinessMode.ShowDialog();
        }
        /// <summary>
        /// 客户维度管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Customer_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_Customer ui_Customer = new UI_Customer();
            ui_Customer.ShowDialog();
        }
        /// <summary>
        /// 工程类别管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ProjectClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_ProjectCategory ui_ProjectCategory = new UI_ProjectCategory();
            ui_ProjectCategory.ShowDialog();
        }
        /// <summary>
        /// 工程状态管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ProjectState_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_ProjectState ui_ProjectState = new UI_ProjectState();
            ui_ProjectState.ShowDialog();
        }
        /// <summary>
        /// 工程管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ProjectManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            MISClient.UI.ProjectManagement.UI_ProjectManagement ui_ProjectManagement = new UI.ProjectManagement.UI_ProjectManagement();
            OpenMdiFormActive(ui_ProjectManagement);
        }

        /// <summary>
        /// 材料库存管理
        /// 流水进出,流水总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StuffStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            MISClient.UI.ProjectManagement.UI_MaterialFlowManagement ui_MaterialFlowManagement = new UI_MaterialFlowManagement();
            OpenMdiFormActive(ui_MaterialFlowManagement);
        }

        /// <summary>
        /// 材料类别管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StuffClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            MISClient.UI.ProjectManagement.UI_MaterialClassManagement ui_MaterialClassManagement = new UI_MaterialClassManagement();
            OpenMdiFormActive(ui_MaterialClassManagement);
        }

        private void btn_PaymentIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_AddPayment payment = new UI_AddPayment();
            payment.ShowDialog();
        }

        private void btn_Cost_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_AddCost cost = new UI_AddCost();
            cost.ShowDialog();
        }

        private void btn_Balance_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_AddBalance balance = new UI_AddBalance();
            balance.ShowDialog();
        }

        private void btn_Loan_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_AddLoanRepay loanRepay = new UI_AddLoanRepay();
            loanRepay.ShowDialog();
        }
        /// <summary>
        /// 如果已经打开窗体，则直接激活该窗口
        /// </summary>
        /// <param name="mdiForm"></param>
        private void OpenMdiFormActive(DevExpress.XtraEditors.XtraForm mdiForm)
        {
            bool exist = false;
            if (this.MdiChildren.Length > 0)   //当子窗体个数大于0的时候遍历所有子窗体
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)// 遍历所有子窗
                {
                    if (this.MdiChildren[i].Text.Equals(mdiForm.Text))//如果两个窗口的标题是相同的,那么就认为它们是同一类窗口
                    {
                        this.MdiChildren[i].Activate();
                        exist = true;
                    }
                }
            }
            if (!exist)
            {
                mdiForm.MdiParent = this;
                mdiForm.Show();
            }
        }

        /// <summary>
        /// 如果已经打开了这个窗体,那么关闭之前的窗体,重新打开新窗体
        /// </summary>
        /// <param name="mdiForm"></param>
        private void OpenMdiFormInstead(DevExpress.XtraEditors.XtraForm mdiForm)
        {
            if (this.MdiChildren.Length > 0)   //当子窗体个数大于0的时候遍历所有子窗体
            {
                foreach (Form form in this.MdiChildren)// 遍历所有子窗
                {
                    if (form.Text.Equals(mdiForm.Text))//如果两个窗口的标题是相同的,那么就认为它们是同一类窗口
                    {
                        form.Close();
                    }
                }
            }
            mdiForm.MdiParent = this;
            mdiForm.Show();
        }

        private void btn_FinanceData_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.Report.UI_SubProjectChoose spc = new UI.Report.UI_SubProjectChoose();
            int projectID = 0;
            bool mainOrSubProject = false;//标记用户是需要显示主工程还是子工程的数据

            if (spc.ShowDialog() == DialogResult.OK)
            {
                projectID = spc.projectID;
                mainOrSubProject = spc.mainOrSubProject;
            }
            else
                return;

            UI.Report.UI_ContainerForm cf = new UI.Report.UI_ContainerForm("财务报表", projectID, mainOrSubProject);
            OpenMdiFormActive(cf);

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            #region 控件汉化
            DevExpress.XtraGrid.Localization.GridResLocalizer.Active = new Dxper.LocalizationCHS.Win.XtraGridCHS();

            DevExpress.XtraEditors.Controls.Localizer.Active = new Dxper.LocalizationCHS.Win.XtraEditorsCHS();

            DevExpress.XtraCharts.Localization.ChartResLocalizer.Active = new Dxper.LocalizationCHS.Win.XtraChartsCHS();

            //DevExpress.XtraBars.Localization.BarLocalizer.Active = new Dxper.LocalizationCHS.Win.XtraBars();

            DevExpress.XtraLayout.Localization.LayoutLocalizer.Active = new Dxper.LocalizationCHS.Win.XtraLayoutCHS();

            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new Dxper.LocalizationCHS.Win.XtraPrintingCHS();

            //DevExpress.XtraTreeList.Localization.TreeListResLocalizer.Active = new Dxper.LocalizationCHS.Win.XtraTreeListCHS();

            DevExpress.Office.Localization.OfficeResLocalizer.Active = new Dxper.LocalizationCHS.Win.OfficeCHS();

            //DevExpress.XtraSpreadsheet.Localization.XtraSpreadsheetLocalizer.Active = new Dxper.LocalizationCHS.Win.XtraSpreadsheetCHS();

            //汉化日期控件
            Localizer.Active = new ChEditLocalizer();
            #endregion
        }

        private void btn_Total_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.Report.UI_SubProjectChoose spc = new UI.Report.UI_SubProjectChoose();
            int projectID = 0;
            bool mainOrSubProject = false;//标记用户是需要显示主工程还是子工程的数据

            if (spc.ShowDialog() == DialogResult.OK)
            {
                projectID = spc.projectID;
                mainOrSubProject = spc.mainOrSubProject;
            }
            else
                return;

            UI.Report.UI_ContainerForm cf = new UI.Report.UI_ContainerForm("总报表", projectID, mainOrSubProject);
            OpenMdiFormActive(cf);
        }

        private void btn_passwordManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.SystemManagement.UI_PasswordManagement pm = new UI.SystemManagement.UI_PasswordManagement();
            pm.ShowDialog();
        }

        private void btn_changeState_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_ChangeState sr = new UI_ChangeState();
            sr.ShowDialog();
        }

        private void btn_Agreement_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI_DealManage dm = new UI_DealManage();
            dm.ShowDialog();
        }
    }
}
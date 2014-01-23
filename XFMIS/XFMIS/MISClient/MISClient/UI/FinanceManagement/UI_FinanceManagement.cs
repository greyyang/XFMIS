using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using MISClient.Service_FinanceManagement;
using MISClient.Service_ProjectManagement;
using MISClient.Service_NewProject;
using MISClient.Kit;
namespace MISClient.UI.FinanceManagement
{
    public partial class UI_FinanceManagement : DevExpress.XtraEditors.XtraForm
    {
        public UI_FinanceManagement()
        {
            InitializeComponent();
            InitData();
            InitGrid();
        }

        Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        Service_NewProject.Service_NewProject service_NP = new Service_NewProject.Service_NewProject();
        //子工程名称,子工程编号,子工程id
        string subProjectName, subProjectNO;
        int subProjectID = -1;
        //主项目名称，主项目编号，主项目id
        string projectName, projectNO;
        int projectID = -1;

        int curRow_project, curRow_subProject;

        Service_NewProject.TabProjectInfo[] projectInfos;
        Service_NewProject.TabSubProjectInfo[] subProjectInfos;
        TabPayment[] payments;
        TabCostAndReimburse[] costAndReimburses;
        TabDeal[] deals;
        TabBalance[] balances;
        TabLoanRepay[] loanRepays;
        List<FVSP> gridSP = null;
        List<FVP> gridP = null;
        private void InitData()
        {
            projectInfos = service_NP.select_ProjectInfo();
            subProjectInfos = service_NP.select_SubProjectInfo();
            payments = service_FM.select_TabPayment();
            costAndReimburses = service_FM.select_TabCostAndReimburse();
            deals = service_PM.Select_Deal();
            balances = service_FM.select_TabBalance();
            loanRepays = service_FM.select_TabLoanRepay();
        }

        private void InitGrid()
        {
            gridSP = new List<FVSP>();
            gridP = new List<FVP>();

            #region 子工程财务数据计算
            foreach (Service_NewProject.TabSubProjectInfo spi in subProjectInfos)
            {
                FVSP fvsp = new FVSP();
                fvsp.FVSP_Id = spi.SPID;
                fvsp.FVSP_NO = spi.SPNO;
                fvsp.FVSP_Name = spi.SPName;
                fvsp.FVSP_State = spi.SPState;
                fvsp.FVSP_DateTime = spi.SPDate;
                fvsp.FVSP_ProjectID = spi.SPProjectID;

                foreach (TabPayment p in payments)
                {
                    //ERRORMARK
                    //if (p.PYSubProjectID == spi.SPID)
                    //{
                    //    fvsp.FVSP_Billing += p.PYBilling;
                    //    fvsp.FVSP_Payment += p.PYPayment;
                    //}
                }

                foreach (TabCostAndReimburse cr in costAndReimburses)
                {
                    //ERRORMARK
                    //if (cr.CRSubProjectID == spi.SPID)
                    //{
                    //    fvsp.FVSP_Amount += cr.CRAmount;
                    //    fvsp.FVSP_BackAmount += cr.CRBackAmount;
                    //    fvsp.FVSP_ManagerialFee += cr.CRManagerialFee;
                    //}
                }


                foreach (TabDeal d in deals)
                {
                    if (d.DLSubProjectID == spi.SPID)
                    {
                        fvsp.FVSP_Deal += d.DLMoeny;
                    }
                }
                foreach (TabBalance b in balances)
                {
                    if (b.BLSubProjectID == spi.SPID)
                    {
                        fvsp.FVSP_Balance += b.BLPay;
                    }
                }

                foreach (TabLoanRepay lr in loanRepays)
                {
                    if (lr.LRSubProjectID == spi.SPID)
                    {
                        fvsp.FVSP_Loan += lr.LRLoan;
                        fvsp.FVSP_Repay += lr.LRRepay;
                    }
                }

                gridSP.Add(fvsp);
            }
            #endregion

            #region 对主工程的财务数据计算
            foreach (Service_NewProject.TabProjectInfo pi in projectInfos)
            {
                FVP fvp = new FVP();
                fvp.FVP_Id = pi.PID;
                fvp.FVP_NO = pi.PNO;
                fvp.FVP_Name = pi.PName;
                fvp.FVP_State = pi.PState;
                fvp.FVP_Customer = pi.PCustomer;
                fvp.FVP_Category = pi.PCategory;
                fvp.FVP_BusinessPlan = pi.PBusinessPlan;
                fvp.FVP_DateTime = pi.PDateTime;
                fvp.FVP_Plan = pi.PPlan;
                foreach (TabPayment p in payments)
                {
                    //ERRORMARK
                    if (p.PYPID == pi.PID)
                    {
                        fvp.FVP_Billing += p.PYBilling;
                        fvp.FVP_Payment += p.PYPayment;
                    }
                }

                foreach (TabCostAndReimburse cr in costAndReimburses)
                {
                    //ERRORMARK
                    if (cr.CRPID == pi.PID)
                    {
                        fvp.FVP_Amount += cr.CRAmount;
                        fvp.FVP_BackAmount += cr.CRBackAmount;
                        fvp.FVP_ManagerialFee += cr.CRManagerialFee;
                    }
                }


                foreach (FVSP fvsp in gridSP)
                {
                    if (fvsp.FVSP_ProjectID == pi.PID)
                    {
                        //fvp.FVP_Billing += fvsp.FVSP_Billing;
                        //fvp.FVP_Payment += fvsp.FVSP_Payment;

                        //fvp.FVP_Amount += fvsp.FVSP_Amount;
                        //fvp.FVP_BackAmount += fvsp.FVSP_BackAmount;
                        //fvp.FVP_ManagerialFee += fvsp.FVSP_ManagerialFee;

                        fvp.FVP_Deal += fvsp.FVSP_Deal;
                        fvp.FVP_Balance += fvsp.FVSP_Balance;

                        fvp.FVP_Loan += fvsp.FVSP_Loan;
                        fvp.FVP_Repay += fvsp.FVSP_Repay;
                    }
                }

                gridP.Add(fvp);
            }
            #endregion

            gridControl1.DataSource = gridP;
            gridControl2.DataSource = gridSP;

            DataAlias.setTableCaption("ProjectFinanceView", gridView1);
            DataAlias.setTableCaption("SubProjectFinanceView", gridView2);

            gridView1.Columns[0].Visible = false;
            gridView2.Columns[0].Visible = false;

            //不显示过滤面板
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;

            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;

            if (gridSP.Count > 0)
            {
                int id = int.Parse(gridView1.GetRowCellValue(0, "FVP_Id").ToString());
                InitSubProjectGrid(id);
            }

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

            //锁定表头,禁止拖动
            gridView2.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView2.OptionsView.ShowGroupPanel = false;
            //表底汇总
            gridView1.Columns["FVP_Billing"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Billing"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_Payment"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Payment"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_Amount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Amount"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_BackAmount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_BackAmount"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_ManagerialFee"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_ManagerialFee"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_Deal"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Deal"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_Balance"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Balance"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_Loan"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Loan"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_Repay"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Repay"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView1.Columns["FVP_Plan"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["FVP_Plan"].SummaryItem.DisplayFormat = "￥{0:N2}";

            gridView2.Columns["FVSP_Billing"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_Billing"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_Payment"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_Payment"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_Amount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_Amount"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_BackAmount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_BackAmount"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_ManagerialFee"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_ManagerialFee"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_Deal"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_Deal"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_Balance"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_Balance"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_Loan"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_Loan"].SummaryItem.DisplayFormat = "￥{0:N2}";
            gridView2.Columns["FVSP_Repay"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["FVSP_Repay"].SummaryItem.DisplayFormat = "￥{0:N2}";
            //默认选中第一行
            if (gridView1.RowCount > 0)
            {
                projectID = int.Parse(gridView1.GetRowCellValue(0, "FVP_Id").ToString());
                projectName = gridView1.GetRowCellValue(0, "FVP_Name").ToString();
                projectNO = gridView1.GetRowCellValue(0, "FVP_NO").ToString();
            }
            //显示行号
            CommonInit.InitGrid(gridView1);
            CommonInit.InitGrid(gridView2);
            //初始化Group中显示内容
            InitCount();
        }

        #region 视图类
        /// <summary>
        /// 表1 所用的视图类
        /// </summary>
        private class FVP
        {
            public int FVP_Id { get; set; }
            public string FVP_NO { get; set; }
            public string FVP_Name { get; set; }
            public string FVP_State { get; set; }
            public string FVP_Customer { get; set; }
            public string FVP_Category { get; set; }
            public string FVP_BusinessPlan { get; set; }
            public DateTime? FVP_DateTime { get; set; }

            public decimal? FVP_Plan { get; set; }

            public decimal? FVP_Billing { get; set; }
            public decimal? FVP_Payment { get; set; }

            public decimal? FVP_Amount { get; set; }
            public decimal? FVP_BackAmount { get; set; }
            public decimal? FVP_ManagerialFee { get; set; }

            public decimal? FVP_Deal { get; set; }
            public decimal? FVP_Balance { get; set; }

            public decimal? FVP_Loan { get; set; }
            public decimal? FVP_Repay { get; set; }
        }
        /// <summary>
        /// 表2 所用的视图类
        /// </summary>
        private class FVSP
        {
            public int FVSP_Id { get; set; }
            public string FVSP_NO { get; set; }
            public string FVSP_Name { get; set; }
            public string FVSP_State { get; set; }
            public DateTime? FVSP_DateTime { get; set; }
            public int? FVSP_ProjectID { get; set; }

            public decimal? FVSP_Billing { get; set; }
            public decimal? FVSP_Payment { get; set; }

            public decimal? FVSP_Amount { get; set; }
            public decimal? FVSP_BackAmount { get; set; }
            public decimal? FVSP_ManagerialFee { get; set; }

            public decimal? FVSP_Deal { get; set; }
            public decimal? FVSP_Balance { get; set; }

            public decimal? FVSP_Loan { get; set; }
            public decimal? FVSP_Repay { get; set; }
        }
        #endregion

        /// <summary>
        /// 开票回款按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_kphk_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                UI_Payment ui_payment = new UI_Payment(subProjectNO, subProjectName, subProjectID);
                if (ui_payment.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }
        /// <summary>
        /// 成本报账按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cbbz_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                UI_CostAndReimburse ui_cost = new UI_CostAndReimburse(projectNO, projectName, projectID);
                if (ui_cost.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }
        /// <summary>
        /// 结算按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_js_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRow() != null)
            {
                UI_Balance ui_balance = new UI_Balance(subProjectNO, subProjectName, subProjectID);
                if (ui_balance.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }
        /// <summary>
        /// 借还款按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_jhk_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRow() != null)
            {
                UI_LoanRepay ui_loanRepay = new UI_LoanRepay(subProjectNO, subProjectName, subProjectID);
                if (ui_loanRepay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetSelectedRows().Length > 0)
            {
                curRow_project = gridView1.GetSelectedRows()[0];
                if (curRow_project >= 0)
                {
                    projectID = int.Parse(gridView1.GetRowCellValue(curRow_project, "FVP_Id").ToString());
                    projectName = gridView1.GetRowCellValue(curRow_project, "FVP_Name").ToString();
                    projectNO = gridView1.GetRowCellValue(curRow_project, "FVP_NO").ToString();
                    InitSubProjectGrid(projectID);
                }
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.GetSelectedRows().Length > 0)
            {
                curRow_subProject = gridView2.GetSelectedRows()[0];
                if (curRow_subProject >= 0)
                {
                    subProjectID = int.Parse(gridView2.GetRowCellValue(curRow_subProject, "FVSP_Id").ToString());
                    subProjectName = gridView2.GetRowCellValue(curRow_subProject, "FVSP_Name").ToString();
                    subProjectNO = gridView2.GetRowCellValue(curRow_subProject, "FVSP_NO").ToString();
                }
            }
        }

        private void InitSubProjectGrid(int id)
        {
            if (gridView2.Columns.Count > 0)
            {
                DevExpress.XtraGrid.Columns.GridColumn a = gridView2.Columns["FVSP_ProjectID"];
                gridView2.Columns[5].FilterInfo = new ColumnFilterInfo("[FVSP_ProjectID] = " + id);
                if (gridView2.RowCount > 0)
                {
                    subProjectID = int.Parse(gridView2.GetRowCellValue(0, "FVSP_Id").ToString());
                    subProjectName = gridView2.GetRowCellValue(0, "FVSP_Name").ToString();
                    subProjectNO = gridView2.GetRowCellValue(0, "FVSP_NO").ToString();
                }
            }
        }

        /// <summary>
        /// 初始化Group中显示数据
        /// </summary>
        private void InitCount()
        {
            decimal? d_in = 0, d_out = 0;

            MISClient.Service_FinanceManagement.TabMoneyPool[] moneyPool = service_FM.select_MoneyPool();
            foreach (MISClient.Service_FinanceManagement.TabMoneyPool m in moneyPool)
            {
                if (m.MPFlag == 1)
                {
                    d_in += m.MPMoney;
                }
                else if (m.MPFlag == 0)
                {
                    d_out += m.MPMoney;
                }
            }

            decimal? d_pin = decimal.Parse(gridView1.Columns["FVP_Plan"].SummaryItem.SummaryValue.ToString());
            decimal? d_pout = decimal.Parse(gridView1.Columns["FVP_Loan"].SummaryItem.SummaryValue.ToString()) + decimal.Parse(gridView1.Columns["FVP_ManagerialFee"].SummaryItem.SummaryValue.ToString()) + decimal.Parse(gridView1.Columns["FVP_Balance"].SummaryItem.SummaryValue.ToString());
            this.label_In.Text = d_in.ToString();
            this.label_Out.Text = d_out.ToString();
            this.label_Pin.Text = d_pin.ToString();
            this.label_Pout.Text = d_pout.ToString();
            this.label_Balance.Text = (d_in + d_pin - d_out - d_pout).ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UI_MoneyPool mp = new UI_MoneyPool();
            if (mp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitGrid();
            }
        }
    }
}
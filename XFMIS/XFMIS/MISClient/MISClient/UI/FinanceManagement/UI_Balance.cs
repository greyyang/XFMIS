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
using MISClient.UI.BasicUI;
using MISClient.Kit;

namespace MISClient.UI.FinanceManagement
{
    public partial class UI_Balance : DevExpress.XtraEditors.XtraForm
    {
        public UI_Balance(string _NO, string _name, int _id)
        {
            InitializeComponent();
            InitGrid(_id);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            text_NO.Text = _NO;
            text_Name.Text = _name;
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        Service_FinanceManagement.TabBalance[] balances;
        Service_ProjectManagement.TabDeal[] deals;

        private void InitGrid(int _id)
        {
            balances = service_FM.select_TabBalance_BySubID(_id);
            deals = service_PM.select_Deal_BySubID(_id);
            gridControl1.DataSource = deals;
            gridControl2.DataSource = balances;

            gridView1.Columns["DLMoeny"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["DLMoeny"].SummaryItem.DisplayFormat = "总计:￥{0:N2}";
            //这一列始终最右
            gridView1.Columns["DLMoeny"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            gridView2.Columns["BLPay"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["BLPay"].SummaryItem.DisplayFormat = "总计:￥{0:N2}";
            //这一列始终最右
            gridView2.Columns["BLPay"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;

            gridView1.Columns["DLID"].Visible = false;
            gridView1.Columns["DLSubProjectID"].Visible = false;
            gridView2.Columns["BLID"].Visible = false;
            gridView2.Columns["BLSubProjectID"].Visible = false;

            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;

            text_deal.Text = gridView1.Columns["DLMoeny"].SummaryText.Substring(3);
            text_Balance.Text = gridView2.Columns["BLPay"].SummaryText.Substring(3);
            decimal d_deal = decimal.Parse(gridView1.Columns["DLMoeny"].SummaryItem.SummaryValue.ToString());
            decimal d_balance = decimal.Parse(gridView2.Columns["BLPay"].SummaryItem.SummaryValue.ToString());
            decimal d_diff = d_deal - d_balance;
            text_Difference.Text = "￥" + d_diff.ToString();

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            //锁定表头,禁止拖动
            gridView2.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView2.OptionsView.ShowGroupPanel = false;
            //表头汉化
            DataAlias.setTableCaption("TabDL", gridView1);
            DataAlias.setTableCaption("TabBL", gridView2);
            CommonInit.InitGrid(gridView1);
            CommonInit.InitGrid(gridView2);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
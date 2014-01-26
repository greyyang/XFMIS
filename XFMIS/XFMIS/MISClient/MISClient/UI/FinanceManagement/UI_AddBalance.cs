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
using DevExpress.XtraEditors.Controls;
namespace MISClient.UI.FinanceManagement
{
    public partial class UI_AddBalance : UI_Ancestor3
    {
        public UI_AddBalance()
        {
            InitializeComponent();
            InitInherit();
            GWorkOrder();
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        MISClient.Service_FinanceManagement.TabBalance balance = new Service_FinanceManagement.TabBalance();
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();

        private void InitInherit()
        {
            this.Text = "结算";
            this.AcceptButton = btn_save;
            this.CancelButton = btn_cancel;
            this.btn_save.Click += btn_save_Click;
            this.btn_cancel.Click += btn_cancel_Click;

            text_NO.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            text_Company.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            date_time.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            date_time.DateTime = DateTime.Now;
            text_NO.Properties.DataSource = service_PM.Select_SubProjectInfo() ;
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("SPNO"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("SPName"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("SPID"));

            text_NO.Properties.Columns["SPNO"].Caption = "工程编号";
            text_NO.Properties.Columns["SPName"].Caption = "工程名称";
            text_NO.Properties.Columns["SPID"].Visible = false;

            text_NO.Properties.DisplayMember = "SPName";
            text_NO.Properties.ValueMember = "SPID";
        }

        void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void btn_save_Click(object sender, EventArgs e)
        {
            {
                balance.BLWorkOrder = label_order.Text;
                balance.BLSubProjectID = int.Parse(text_NO.EditValue.ToString());
                balance.BLPay = decimal.Parse(text_Money.Text);
                balance.BLPayCompany = text_Company.Text;
                balance.BLHandler = text_inputer.Text;
                balance.BLDateTime = date_time.DateTime;
                balance.BLBankNO = text_BankNO.Text;
                balance.BLMemo = memo_memo.Text;
            }
            service_FM.create_TabBalance(balance);
        }

        private void GWorkOrder()
        {
            string workOrder = GenerateWorkOrder.generateWorkOrder_BySubIDAndType("Balance");
            label_order.Text = workOrder;   
        }

        private void text_NO_EditValueChanged(object sender, EventArgs e)
        {
            text_Company.Properties.Items.Clear();
            MISClient.Service_ProjectManagement.TabDeal[] deals = service_PM.select_Deal_BySubID(int.Parse(text_NO.EditValue.ToString()));
            foreach (MISClient.Service_ProjectManagement.TabDeal d in deals)
            {
                text_Company.Properties.Items.Add(d.DLCompany);
            }
        }
    }
}
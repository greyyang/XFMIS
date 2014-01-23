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
    public partial class UI_AddLoanRepay : UI_Ancestor3
    {
        public UI_AddLoanRepay()
        {
            InitializeComponent();
            InitInherit();
            GWorkOrder();
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        MISClient.Service_FinanceManagement.TabLoanRepay loanRepay = new Service_FinanceManagement.TabLoanRepay();
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        private void InitInherit()
        {
            this.label_Repay.Enabled = false;
            this.text_Repay.Text = "";
            this.text_Repay.Enabled = false;

            this.Text = "借还款";
            this.AcceptButton = btn_save;
            this.CancelButton = btn_cancel;
            this.btn_save.Click += btn_save_Click;
            this.btn_cancel.Click += btn_cancel_Click;

            this.text_NO.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            text_NO.Properties.DataSource = service_PM.Select_SubProjectInfo();
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("SPNO"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("SPName"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("SPID"));

            text_NO.Properties.Columns["SPNO"].Caption = "工程编号";
            text_NO.Properties.Columns["SPName"].Caption = "工程名称";
            text_NO.Properties.Columns["SPID"].Visible = false;

            text_NO.Properties.DisplayMember = "SPName";
            text_NO.Properties.ValueMember = "SPID";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            {
                loanRepay.LRWorkOrder = label_order.Text;
                loanRepay.LRSubProjectID = service_FM.select_SubID_BySubNO(text_NO.Text)[0].SPID;
                loanRepay.LRLoan = decimal.Parse(text_Loan.Text);
                loanRepay.LRRepay = decimal.Parse(text_Repay.Text);
                loanRepay.LRHandler = text_inputer.Text;
                loanRepay.LRPerson = text_doer.Text;
                loanRepay.LRBankNO = text_BankNO.Text;
                loanRepay.LRDateTime = date_time.DateTime;
                loanRepay.LRMemo = memo_memo.Text;
                loanRepay.LRFlag = radioGroup1.SelectedIndex;
            }
            service_FM.create_TabLoanRepay(loanRepay);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                this.label_Repay.Enabled = false;
                this.text_Repay.Text = "";
                this.text_Repay.Enabled = false;

                this.label_Loan.Enabled = true;
                this.text_Loan.Enabled = true;
            }
            else
            {
                this.label_Loan.Enabled = false;
                this.text_Loan.Text = "";
                this.text_Loan.Enabled = false;

                this.label_Repay.Enabled = true;
                this.text_Repay.Enabled = true;
            }
        }

        private void GWorkOrder()
        {
            string workOrder = GenerateWorkOrder.generateWorkOrder_BySubIDAndType("LoanRepay");
            label_order.Text = workOrder;
        }
    }
}
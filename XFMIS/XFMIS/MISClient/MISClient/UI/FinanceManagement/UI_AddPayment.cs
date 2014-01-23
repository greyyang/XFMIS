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
    public partial class UI_AddPayment : UI_Ancestor3
    {
        public UI_AddPayment()
        {
            InitializeComponent();
            InitInherit();
            GworkOrder();
            InitLookupEdit();
        }

        

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        MISClient.Service_FinanceManagement.TabPayment payment = new Service_FinanceManagement.TabPayment();
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();

        private void InitLookupEdit()
        {
            text_NO.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            text_NO.Properties.DataSource =  service_PM.Select_ProjectInfo();
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("PNO"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("PName"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("PID"));

            text_NO.Properties.Columns["PNO"].Caption = "工程编号";
            text_NO.Properties.Columns["PName"].Caption = "工程名称";
            text_NO.Properties.Columns["PID"].Visible = false;

            text_NO.Properties.DisplayMember = "PName";
            text_NO.Properties.ValueMember = "PID";
        }

        private void InitInherit()
        {
            label_kpje.Enabled = false;
            text_kpje.Text = "";
            text_kpje.Enabled = false;

            this.Text = "添加开票回款记录";
            this.AcceptButton = btn_save;
            this.CancelButton = btn_cancel;
            this.btn_save.Click += btn_save_Click;
            this.btn_cancel.Click += btn_cancel_Click;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            {
                payment.PYWorkOrder = label_order.Text;
                payment.PYPID = int.Parse(text_NO.EditValue.ToString());
                payment.PYPayment = decimal.Parse(text_Pay.Text);
                payment.PYBilling = decimal.Parse(text_kpje.Text);
                payment.PYPayCompany = text_company.Text;
                payment.PYDateTIme = date_time.DateTime;
                payment.PYMemo = memo_memo.Text;
                payment.PYFlag = radioGroup1.SelectedIndex;
            }
            service_FM.create_TabPayment(payment);
        }

        private void GworkOrder()
        {
            string workOrder = GenerateWorkOrder.generateWorkOrder_BySubIDAndType("LoanRepay");
            label_order.Text = workOrder;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                label_kpje.Enabled = false;
                text_kpje.Text = "";
                text_kpje.Enabled = false;

                text_Pay.Enabled = true;
                label_pay.Enabled = true;
            }
            else
            {
                label_pay.Enabled = false;
                text_Pay.Text = "";
                text_Pay.Enabled = false;

                text_kpje.Enabled = true;
                label_kpje.Enabled = true;
            }
        }
    }
}
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
    public partial class UI_AddCost : UI_Ancestor3
    {
        public UI_AddCost()
        {
            InitializeComponent();
            InitInherit();
            GWorkOrder();
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        MISClient.Service_FinanceManagement.TabCostAndReimburse cost = new Service_FinanceManagement.TabCostAndReimburse();
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();

        private void InitInherit()
        {
            DisableAll();
            this.label_Amount.Enabled = true;
            this.text_Amount.Enabled = true;
            this.date_time.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            this.date_time.DateTime = DateTime.Now;

            this.Text = "成本报账";
            this.AcceptButton = btn_save;
            this.CancelButton = btn_cancel;
            this.btn_save.Click += btn_save_Click;
            this.btn_cancel.Click += btn_cancel_Click;
            //初始化LookupEdit
            text_NO.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            text_NO.Properties.DataSource = service_PM.Select_ProjectInfo();
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("PNO"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("PName"));
            text_NO.Properties.Columns.Add(new LookUpColumnInfo("PID"));

            text_NO.Properties.Columns["PNO"].Caption = "工程编号";
            text_NO.Properties.Columns["PName"].Caption = "工程名称";
            text_NO.Properties.Columns["PID"].Visible = false;

            text_NO.Properties.DisplayMember = "PName";
            text_NO.Properties.ValueMember = "PID";
        }

        private void DisableAll()
        {
            this.label_Amount.Enabled = false;
            this.label_manageFee.Enabled = false;
            this.label_out.Enabled = false;
            this.text_Amount.Enabled = false;
            this.text_manageFee.Enabled = false;
            this.text_out.Enabled = false;
        }

        void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            {
                cost.CRWorkOrder = label_order.Text;
                //ERRORMARK
                cost.CRPID = int.Parse(text_NO.EditValue.ToString());
                cost.CRAmount = decimal.Parse(text_Amount.Text);
                cost.CRBackAmount = decimal.Parse(text_out.Text);
                cost.CRManagerialFee = decimal.Parse(text_manageFee.Text);
                cost.CRDateTime = date_time.DateTime;
                cost.CRHandler = text_Handler.Text;
                cost.CRPerson = text_Person.Text;
                cost.CRMemo = memo_memo.Text;
            }
            service_FM.create_CostAndReimburse(cost);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableAll();
            switch (radioGroup1.SelectedIndex)
            {
                case 0: { this.label_Amount.Enabled = true; this.text_Amount.Enabled = true; break; }
                case 1: { this.label_out.Enabled = true; this.text_out.Enabled = true; break; }
                case 2: { this.label_manageFee.Enabled = true; this.text_manageFee.Enabled = true; break; }
                default: return;
            }
        }

        private void GWorkOrder()
        {
            string workOrder = GenerateWorkOrder.generateWorkOrder_BySubIDAndType("CostAndReimburse");
            label_order.Text = workOrder;
        }
    }
}
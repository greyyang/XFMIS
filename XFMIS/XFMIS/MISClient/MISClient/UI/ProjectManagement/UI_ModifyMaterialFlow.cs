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

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_ModifyMaterialFlow : DevExpress.XtraEditors.XtraForm
    {
        Service_ProjectManagement.TabMaterialFlow materialFlow;
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();


        public UI_ModifyMaterialFlow(Service_ProjectManagement.TabMaterialFlow materialFlow)
        {
            InitializeComponent();
            this.materialFlow = materialFlow;
        }

        private void UI_ModifyMaterialFlow_Load(object sender, EventArgs e)
        {
            if (materialFlow.MFFlag == 1)
            {
                ce_In.Checked = true;
            }
            else
            {
                ce_In.Checked = false;
            }
            txt_Amount.Text = Math.Abs(materialFlow.MFAmount.Value).ToString();
            txt_Memo.Text = materialFlow.MFMemo;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;

            materialFlow.MFAmount = decimal.Parse(txt_Amount.Text);
            if (ce_Out.Checked)
                materialFlow.MFAmount *= -1;

            if (ce_In.Checked)
                materialFlow.MFFlag = 1;
            else
                materialFlow.MFFlag = 0;
            materialFlow.MFMemo = txt_Memo.Text;

            service_ProjectManagement.Update_MaterialFlow(materialFlow);

            this.DialogResult = DialogResult.OK;
        }

        private bool checkInput()
        {
            decimal amount = 0;
            if (!decimal.TryParse(txt_Amount.Text, out amount))
            {
                MessageBox.Show("请输入合法的数值!", "警告");
                return false;
            }
            if (amount < 0)
            {
                MessageBox.Show("物料数值只能为正数!", "警告");
                return false;
            }

            return true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ce_Out_CheckedChanged(object sender, EventArgs e)
        {
            ce_In.Checked = !ce_Out.Checked;
            if (ce_Out.Checked)
                label_Flag.Text = "-";
            else
                label_Flag.Text = "+";
        }

        private void ce_In_CheckedChanged(object sender, EventArgs e)
        {
            ce_Out.Checked = !ce_In.Checked;
            if (ce_Out.Checked)
                label_Flag.Text = "-";
            else
                label_Flag.Text = "+";
        }
    }
}
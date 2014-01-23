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
using MISClient.Service_ProjectManagement;
using DevExpress.XtraEditors.Controls;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_ModifySubProject : DevExpress.XtraEditors.XtraForm
    {
        private TabSubProjectInfo subProjectInfo = null;
        Service_ProjectManagement.Service_ProjectManagement pm = new Service_ProjectManagement.Service_ProjectManagement();

        public UI_ModifySubProject(TabSubProjectInfo subProjectInfo)
        {
            InitializeComponent();
            this.subProjectInfo = subProjectInfo;
            InitFrame();
            InitData();
        }

        void InitFrame()
        {
            //设置添加时间自动生成当天，不能输入修改。
            dateEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }


        void InitData()
        {
            text_SubProjectNO.Text = subProjectInfo.SPNO;
            text_SubProjectName.Text = subProjectInfo.SPName;
            dateEdit.DateTime = subProjectInfo.SPDate.GetValueOrDefault();
            text_ContractAmount.Text = subProjectInfo.SPContractAmount.GetValueOrDefault().ToString();
            text_Auditors.Text = subProjectInfo.SPAuditors.GetValueOrDefault().ToString();
            text_Ratio.Text = subProjectInfo.SPRatio.GetValueOrDefault().ToString();
            text_Manager.Text = subProjectInfo.SPManager;
            text_Tel.Text = subProjectInfo.SPTel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                subProjectInfo.SPNO = text_SubProjectNO.Text.Trim();
                subProjectInfo.SPName = text_SubProjectName.Text.Trim();
                subProjectInfo.SPContractAmount = Decimal.Parse(text_ContractAmount.Text.Trim());
                subProjectInfo.SPAuditors = Decimal.Parse(text_Auditors.Text.Trim());
                subProjectInfo.SPRatio = Decimal.Parse(text_Ratio.Text.Trim());
                subProjectInfo.SPManager = text_Manager.Text.Trim();
                subProjectInfo.SPTel = text_Tel.Text.Trim();
            }
            catch
            {
                MessageBox.Show("请输入正确的数据。", "提醒");
                return;
            }
            pm.Update_SubProjectInfo(subProjectInfo);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
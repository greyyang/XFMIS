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
    public partial class UI_AddMaterialFlow : DevExpress.XtraEditors.XtraForm
    {
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();
        MISClient.Service_ProjectManagement.TabProjectInfo[] allProjectInfo = null;
        MISClient.Service_ProjectManagement.TabMaterial[] allMaterial = null;
        MISClient.Service_ProjectManagement.TabSubProjectInfo[] chooseSubProjectInfo = null;

        public UI_AddMaterialFlow()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;

            MISClient.Service_ProjectManagement.TabMaterialFlow materialFlow = new Service_ProjectManagement.TabMaterialFlow();
            materialFlow.MFAmount = decimal.Parse(txt_Amount.Text);
            if (ce_Out.Checked)
                materialFlow.MFAmount *= -1;
            materialFlow.MFDatetime = DateTime.Now;
            if (ce_In.Checked)
                materialFlow.MFFlag = 1;
            else
                materialFlow.MFFlag = 0;
            materialFlow.MFMaterialID = allMaterial[cmb_MaterialName.SelectedIndex].MID;
            materialFlow.MFMemo = txt_Memo.Text;
            materialFlow.MFProject = allProjectInfo[cmb_ProjectNo.SelectedIndex].PID;
            materialFlow.MFSubProjectID = chooseSubProjectInfo[cmb_SubProjectNo.SelectedIndex].SPID;

            service_ProjectManagement.Create_MaterialFlow(materialFlow);

            this.DialogResult = DialogResult.OK;
        }

        private bool checkInput()
        {
            if (cmb_MaterialName.SelectedIndex < 0)
            {
                MessageBox.Show("请选定物料名称!", "警告");
                return false;
            }

            if (cmb_ProjectNo.SelectedIndex < 0)
            {
                MessageBox.Show("请选定主项目!", "警告");
                return false;
            }
            if (cmb_SubProjectNo.SelectedIndex < 0)
            {
                MessageBox.Show("请选定子项目!", "警告");
                return false;
            }
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

        /// <summary>
        /// 面板初始化时,加载所有主项目信息 和 物料信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_AddMaterialFlow_Load(object sender, EventArgs e)
        {
            allProjectInfo = service_ProjectManagement.Select_ProjectInfo();
            foreach (MISClient.Service_ProjectManagement.TabProjectInfo projectInfo in allProjectInfo)
            {
                cmb_ProjectNo.Properties.Items.Add(projectInfo.PNO);
            }
            allMaterial = service_ProjectManagement.Select_MaterialClass();
            foreach (MISClient.Service_ProjectManagement.TabMaterial material in allMaterial)
            {
                cmb_MaterialName.Properties.Items.Add(material.MName);
            }
        }

        /// <summary>
        /// 主项目combobox变化时,加载对应子项目信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_ProjectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int projectIndex = cmb_ProjectNo.SelectedIndex;
            if (projectIndex < 0)
                return;
            MISClient.Service_ProjectManagement.TabProjectInfo projectInfo = allProjectInfo[projectIndex];
            chooseSubProjectInfo = service_ProjectManagement.Select_SubProjectInfo_ByProjectID(projectInfo.PID);

            cmb_SubProjectNo.Properties.Items.Clear();

            foreach (MISClient.Service_ProjectManagement.TabSubProjectInfo subProjectInfo in chooseSubProjectInfo)
            {
                cmb_SubProjectNo.Properties.Items.Add(subProjectInfo.SPNO);
            }

            label_ProjectName.Text = projectInfo.PName;

        }

        private void cmb_SubProjectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subProjectIndex = cmb_SubProjectNo.SelectedIndex;
            if (subProjectIndex < 0)
                return;

            label_SubProjectName.Text = chooseSubProjectInfo[subProjectIndex].SPName;
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
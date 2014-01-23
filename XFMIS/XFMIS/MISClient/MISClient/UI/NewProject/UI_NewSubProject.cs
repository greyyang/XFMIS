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
using DevExpress.XtraEditors.Controls;

namespace MISClient.UI.NewProject
{
    public partial class UI_NewSubProject : DevExpress.XtraEditors.XtraForm
    {
        public UI_NewSubProject()
        {
            InitializeComponent();
            InitOther();
            this.AcceptButton = simpleButton1;
            this.CancelButton = simpleButton2;
        }

        MISClient.Service_NewProject.Service_NewProject service_NewSubProject = new Service_NewProject.Service_NewProject();
        MISClient.Service_NewProject.TabSubProjectInfo subProjectInfo = null;
        MISClient.Service_NewProject.TabProjectInfo[] projectInfo = null;

        
        private void InitOther()
        {

            projectInfo = service_NewSubProject.select_ProjectInfo();
            List<NVP> nvps = new List<NVP>();

            foreach (MISClient.Service_NewProject.TabProjectInfo p in projectInfo)
            {
                NVP nvp = new NVP() { NV_ID = p.PID, NV_Name = p.PName, NV_NO = p.PNO };
                nvps.Add(nvp);
            }

            #region 错误示例
            //不要用下面的方法实现LookupEdit，数据绑定会把整张表的字段都导入进去，对Columns的操作会报错（数组越界）
            //cmb_ProjectId.Properties.DataSource = nvps;
            //cmb_ProjectId.Properties.Columns[0].Visible = false;
            //cmb_ProjectId.Properties.Columns[1].Visible = false;
            //cmb_ProjectId.Properties.Columns[2].Caption = "项目编号";
            //或者进行填充列使得Columns不为空
            //cmb_ProjectId.Properties.PopulateColumns();
            #endregion

            cmb_ProjectId.Properties.DataSource = nvps;
            this.cmb_ProjectId.Properties.Columns.Add(new LookUpColumnInfo("NV_NO"));
            cmb_ProjectId.Properties.Columns["NV_NO"].Caption = "工程编号";
            cmb_ProjectId.Properties.DisplayMember = "NV_NO";
            cmb_ProjectId.Properties.ValueMember = "NV_ID";
            cmb_ProjectId.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

            this.cmb_ProjectName.Properties.Columns.Add(new LookUpColumnInfo("NV_Name"));
            cmb_ProjectName.Properties.Columns["NV_Name"].Caption = "工程名称";
            cmb_ProjectName.Properties.DataSource = nvps;
            cmb_ProjectName.Properties.DisplayMember = "NV_Name";
            cmb_ProjectName.Properties.ValueMember = "NV_ID";
            cmb_ProjectName.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

            //设置添加时间自动生成当天，不能输入修改。
            dateEdit.DateTime = DateTime.Now;
            dateEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

        }

        /// <summary>
        /// 视图类（用于cmb_ProjectId）
        /// </summary>
        private class NVP
        {
            public int NV_ID { get; set; }
            public string NV_Name { get; set; }
            public string NV_NO { get; set; }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (checkInput())
            {
                try
                {
                    service_NewSubProject = new Service_NewProject.Service_NewProject();
                    subProjectInfo = new Service_NewProject.TabSubProjectInfo();
                    subProjectInfo.SPProjectID = int.Parse(cmb_ProjectId.EditValue.ToString());
                    subProjectInfo.SPNO = text_SubProjectNO.Text.Trim();
                    subProjectInfo.SPName = text_SubProjectName.Text.Trim();
                    subProjectInfo.SPDate = dateEdit.DateTime;
                    subProjectInfo.SPContractAmount = Decimal.Parse(text_ContractAmount.Text.Trim());
                    subProjectInfo.SPAuditors = Decimal.Parse(text_Auditors.Text.Trim());
                    subProjectInfo.SPRatio = Decimal.Parse(text_Ratio.Text.Trim());
                    subProjectInfo.SPManager = text_Manager.Text.Trim();
                    subProjectInfo.SPTel = text_Tel.Text.Trim();
                    service_NewSubProject.add_SubProjectInfo(subProjectInfo);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("请输入合法数据！","提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入正确的数据。", "提醒");
            }
        }

        /// <summary>
        /// 对输入的数据进行判断
        /// </summary>
        private bool checkInput()
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextEdit || c is ComboBoxEdit)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        return false;
                    }
                }
                if (c is GroupControl)
                {
                    foreach (Control cc in c.Controls)
                    {
                        if (cc is TextEdit || cc is ComboBoxEdit)
                        {
                            if (string.IsNullOrEmpty(cc.Text))
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmb_ProjectId_EditValueChanged(object sender, EventArgs e)
        {
            this.cmb_ProjectName.EditValue = this.cmb_ProjectId.EditValue;
            text_SubProjectNO.Text = cmb_ProjectId.Text;
        }

        private void cmb_ProjectName_EditValueChanged(object sender, EventArgs e)
        {
            this.cmb_ProjectId.EditValue = this.cmb_ProjectName.EditValue;
        }
    }
}
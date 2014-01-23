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
using MISClient.Kit;
using DevExpress.XtraGrid.Views.Layout;

namespace MISClient.UI.NewProject
{
    public partial class UI_NewProject : DevExpress.XtraEditors.XtraForm
    {
        public UI_NewProject()
        {
            InitializeComponent();
            InitOther();
        }

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        MISClient.Service_ProjectManagement.TabCustomer[] tabCustomers = null;
        MISClient.Service_ProjectManagement.TabBusinessMode[] tabModes = null;
        MISClient.Service_ProjectManagement.TabProjectCategory[] tabCategorys = null;


        void InitOther()
        {
            #region 初始化下拉菜单
            //设置下拉框只读
            cmb_BusinessPlan.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            cmb_Category.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            cmb_Customer.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            date_datetime.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            tabCustomers = service_PM.Select_Customer();
            tabModes = service_PM.Select_BusinessMode();
            tabCategorys = service_PM.Select_ProjectCategory();

            foreach (MISClient.Service_ProjectManagement.TabCustomer c in tabCustomers)
            {
                cmb_Customer.Properties.Items.Add(c.CUValue);
            }

            foreach (MISClient.Service_ProjectManagement.TabBusinessMode b in tabModes)
            {
                cmb_BusinessPlan.Properties.Items.Add(b.BPValue);
            }

            foreach (MISClient.Service_ProjectManagement.TabProjectCategory a in tabCategorys)
            {
                cmb_Category.Properties.Items.Add(a.PCName);
            }
            #endregion

            //初始化时间
            date_datetime.DateTime = DateTime.Now;

            #region 禁用右键菜单
            //禁用右键菜单
            ContextMenu empty = new System.Windows.Forms.ContextMenu();
            foreach (Control c in this.Controls)
            {
                if (c is GroupControl)
                {
                    if (c is TextEdit || c is ComboBoxEdit)
                    {
                        (c as TextEdit).Properties.ContextMenu = empty;
                    }
                    foreach (Control cc in c.Controls)
                    {
                        if (cc is TextEdit || c is ComboBoxEdit)
                        {
                            (cc as TextEdit).Properties.ContextMenu = empty;
                        }
                    }
                }
            }
            #endregion

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {

                MISClient.Service_NewProject.Service_NewProject service_NewProjcet = new MISClient.Service_NewProject.Service_NewProject();
                MISClient.Service_NewProject.TabProjectInfo projectInfo = new MISClient.Service_NewProject.TabProjectInfo();
                try
                {
                    projectInfo.PNO = text_NO.Text;
                    projectInfo.PName = text_Name.Text;
                    projectInfo.PConstruction = text_Construction.Text;
                    projectInfo.PBuilder = text_Builder.Text;
                    projectInfo.PCustomer = cmb_Customer.Text;
                    projectInfo.PCategory = cmb_Category.Text;
                    projectInfo.PBusinessPlan = cmb_BusinessPlan.Text;
                    projectInfo.PDateTime = date_datetime.DateTime;
                    projectInfo.PContractAmount = Decimal.Parse(text_ContractAmount.Text);
                    projectInfo.PAuditors = Decimal.Parse(text_Auditors.Text);
                    projectInfo.PRatio = Decimal.Parse(text_Ratio.Text);
                    projectInfo.PTeleComNO = text_TeleComNO.Text;
                    projectInfo.PPlan = Decimal.Parse(text_Plan.Text);
                }
                catch
                {
                    MessageBox.Show("请输入合法数据！", "提示");
                }
                //执行存储
                int respose = service_NewProjcet.add_ProjectInfo(projectInfo);
                if (respose > 0)
                {
                    MessageBox.Show("创建成功！", "提醒");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("创建失败！", "提醒");
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

        #region 自动计算 成本计划=成本占收 x 审计金额
        private void text_Ratio_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_Auditors.Text) && !string.IsNullOrEmpty(text_Ratio.Text))
            {
                text_Plan.Text = (decimal.Parse(text_Auditors.Text) * decimal.Parse(text_Ratio.Text) / 100).ToString();
            }
        }

        private void text_Auditors_Leave(object sender, EventArgs e)
        {

        }

        private void text_Plan_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_Auditors.Text) && !string.IsNullOrEmpty(text_Plan.Text))
            {
                text_Ratio.Text = ((decimal.Parse(text_Plan.Text)) / (decimal.Parse(text_Auditors.Text)) * 100).ToString();
            }
        }
        #endregion

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            UI_NewImage ui_Image = new UI_NewImage();
            if (ui_Image.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
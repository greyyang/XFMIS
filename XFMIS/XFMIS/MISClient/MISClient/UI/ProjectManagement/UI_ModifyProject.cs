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
using MISClient.Service_ProjectManagement;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_ModifyProject : DevExpress.XtraEditors.XtraForm
    {
        private TabProjectInfo projectInfo = null;

        public UI_ModifyProject(TabProjectInfo projectInfo)
        {
            InitializeComponent();
            this.projectInfo = projectInfo;
            InitFrame();
            InitData();
        }

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        MISClient.Service_ProjectManagement.TabCustomer[] tabCustomers = null;
        MISClient.Service_ProjectManagement.TabBusinessMode[] tabModes = null;
        MISClient.Service_ProjectManagement.TabProjectCategory[] tabCategorys = null;

        void InitFrame()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btn_OK;
            this.CancelButton = btn_Cancel;

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

            this.textEdit4.Properties.Items.Add("未完成");
            this.textEdit4.Properties.Items.Add("制作中");
            this.textEdit4.Properties.Items.Add("已送审");
            this.textEdit4.Properties.Items.Add("已完成");

            this.textEdit2.Properties.Items.Add("有变更");
            this.textEdit2.Properties.Items.Add("无变更");

            this.textEdit5.Properties.Items.Add("未录入");
            this.textEdit5.Properties.Items.Add("已录入");
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


        void InitData()
        {

            text_NO.Text = projectInfo.PNO;
            text_Name.Text = projectInfo.PName;
            text_Construction.Text = projectInfo.PConstruction;
            text_Builder.Text = projectInfo.PBuilder;
            cmb_Customer.Text = projectInfo.PCustomer;
            cmb_Category.Text = projectInfo.PCategory;
            cmb_BusinessPlan.Text = projectInfo.PBusinessPlan;
            date_datetime.DateTime = projectInfo.PDateTime.GetValueOrDefault();
            text_ContractAmount.Text = projectInfo.PContractAmount.GetValueOrDefault().ToString();
            text_Auditors.Text = projectInfo.PAuditors.GetValueOrDefault().ToString();
            text_Ratio.Text = projectInfo.PRatio.GetValueOrDefault().ToString();
            text_TeleComNO.Text = projectInfo.PTeleComNO;
            text_Plan.Text = projectInfo.PPlan.GetValueOrDefault().ToString();

            textEdit1.DateTime = projectInfo.PDisclosure.GetValueOrDefault();
            textEdit4.Text = projectInfo.PCompletion;
            textEdit2.Text = projectInfo.PDesignChange;
            textEdit5.Text = projectInfo.PDataIn;
            textEdit3.DateTime = projectInfo.PStartDate.GetValueOrDefault();
            textEdit6.DateTime = projectInfo.PEndDate.GetValueOrDefault();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (checkInput())
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

                try { projectInfo.PDisclosure = textEdit1.DateTime; }
                catch {
                    projectInfo.PDisclosure = null;
                }
                try { projectInfo.PStartDate = textEdit1.DateTime; }
                catch
                {
                    projectInfo.PStartDate = null;
                }
                try { projectInfo.PEndDate = textEdit1.DateTime; }
                catch
                {
                    projectInfo.PEndDate = null;
                }
                projectInfo.PDisclosure = textEdit1.DateTime;
                projectInfo.PCompletion = textEdit4.Text;
                projectInfo.PDesignChange = textEdit2.Text;
                projectInfo.PDataIn = textEdit5.Text;
                //projectInfo.PStartDate = textEdit3.DateTime;
                //projectInfo.PEndDate = textEdit6.DateTime;

                service_PM.Update_ProjectInfo(projectInfo);
            }
            else
            {
                MessageBox.Show("请输入正确的数据。", "提醒");
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// 对输入的数据进行判断
        /// </summary>
        private bool checkInput()
        {

            //foreach (Control c in this.Controls)
            //{
            //    if (c is TextEdit || c is ComboBoxEdit)
            //    {
            //        if (string.IsNullOrEmpty(c.Text))
            //        {
            //            return false;
            //        }
            //    }
            //    if (c is GroupControl)
            //    {
            //        foreach (Control cc in c.Controls)
            //        {
            //            if (cc is TextEdit || cc is ComboBoxEdit)
            //            {
            //                if (string.IsNullOrEmpty(cc.Text))
            //                {
            //                    return false;
            //                }
            //            }
            //        }
            //    }
            //}

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

        private void text_Plan_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_Auditors.Text) && !string.IsNullOrEmpty(text_Plan.Text))
            {
                text_Ratio.Text = ((decimal.Parse(text_Plan.Text)) / (decimal.Parse(text_Auditors.Text)) * 100).ToString();
            }
        }
        #endregion
    }
}
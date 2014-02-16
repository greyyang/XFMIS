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
using MISClient.Service_NewProject;
using System.Data.SqlTypes;

namespace MISClient.UI.NewProject
{
    public partial class UI_ProjectExInto : DevExpress.XtraEditors.XtraForm
    {
        public UI_ProjectExInto(TabProjectInfo projectInfo)
        {
            InitializeComponent();
            InitFrame(projectInfo);
        }

        TabProjectInfo projectInfo = null;

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitFrame(TabProjectInfo projectInfo)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.projectInfo = projectInfo;
            this.label3.Text = projectInfo.PNO;
            this.label5.Text = projectInfo.PName;

            this.textEdit4.Properties.Items.Add("未完成");
            this.textEdit4.Properties.Items.Add("制作中");
            this.textEdit4.Properties.Items.Add("已送审");
            this.textEdit4.Properties.Items.Add("已完成");

            this.textEdit2.Properties.Items.Add("有变更");
            this.textEdit2.Properties.Items.Add("无变更");

            this.textEdit5.Properties.Items.Add("未录入");
            this.textEdit5.Properties.Items.Add("已录入");

            if (projectInfo.PDisclosure != null)
            {
                this.textEdit1.DateTime = (DateTime)projectInfo.PDisclosure;
            }
            this.textEdit2.Text = projectInfo.PDesignChange;
            if (projectInfo.PStartDate != null)
            {
                this.textEdit3.DateTime = (DateTime)projectInfo.PStartDate;
            }
            this.textEdit4.Text = projectInfo.PCompletion;
            this.textEdit5.Text = projectInfo.PDataIn;
            if (projectInfo.PEndDate != null)
            {
                this.textEdit6.DateTime = (DateTime)projectInfo.PEndDate;
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        /// <summary>
        /// 确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (checkInput())
            if(true)
            {
                TabProjectInfo projectExInfo = new TabProjectInfo();
                try
                {
                    projectExInfo.PID = projectInfo.PID;
                    projectExInfo.PDisclosure = textEdit1.DateTime;
                    projectExInfo.PCompletion = textEdit4.Text;
                    projectExInfo.PDesignChange = textEdit2.Text;
                    projectExInfo.PDataIn = textEdit5.Text;
                    projectExInfo.PStartDate = textEdit3.DateTime;
                    if (!String.IsNullOrEmpty(textEdit6.Text))
                    {
                        projectExInfo.PEndDate = textEdit6.DateTime;
                    }
                    else
                    {
                        projectExInfo.PEndDate = SqlDateTime.MinValue.Value;
                    }
                }
                catch
                {
                    MessageBox.Show("请输入合法数据！", "提示");
                }
                MISClient.Service_NewProject.Service_NewProject service_NP = new Service_NewProject.Service_NewProject();
                if (0 < service_NP.update_ExInfo(projectExInfo))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("更新失败!", "提醒");
                    this.DialogResult = System.Windows.Forms.DialogResult.Abort;
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
    }
}
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
using MISClient.Service_ProjectManagement;
using Drawing = System.Drawing;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_AddDeal : DevExpress.XtraEditors.XtraForm
    {
        //定义服务变量
        Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = null;
        //子项目
        TabSubProjectInfo subProject = null;


        public UI_AddDeal(TabSubProjectInfo subP)
        {
            this.subProject = subP;
            service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();
            InitializeComponent();
            InitInherit();
            InitGroup();
            this.text_Manager.Text = subP.SPManager;
        }

        private void InitInherit()
        {
            this.Text = "添加内部协议";
            text_Date.DateTime = DateTime.Now;
            this.simpleButton1.Click += btn_ok_Click;
            this.simpleButton2.Click += btn_cancel_Click;
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// 确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            TabDeal deal = new TabDeal();
            try
            {
                deal.DLSubProjectID = subProject.SPProjectID;
                deal.DLManager = text_Manager.Text;
                deal.DLCompany = text_Company.Text;
                deal.DLMoeny = Decimal.Parse(text_Cost.Text);
                deal.DLStart = text_StartTime.DateTime;
                deal.DLEnd = text_EndTime.DateTime;
                deal.DLState = text_State.Text;
                deal.DLDate = text_Date.DateTime;
                if (service_ProjectManagement.Create_Deal(deal) == 1)
                {
                    MessageBox.Show("添加成功", "提示");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("添加失败", "提示");
                }
            }
            catch
            {
                MessageBox.Show("请输入合法数据！", "提示");
                return;
            }
        }

        private void InitGroup()
        {
            //取得分包单位列表并分配给其下拉列表
            TabSubContractor[] subContractor = service_ProjectManagement.Select_SubContractor();
            foreach (TabSubContractor sc in subContractor)
            {
                text_Company.Properties.Items.Add(sc.SCName);
            }
            //取得协议状态列表并分配给其下拉列表
            TabProjectState[] projectState = service_ProjectManagement.Select_ProjectState();
            foreach (TabProjectState ps in projectState)
            {
                text_State.Properties.Items.Add(ps.PSValue);
            }

            //初始化协议流水号和子项目编号
            text_ID.Text = subProject.SPID.ToString();
            text_subNO.Text = subProject.SPNO;
        }
    }
}
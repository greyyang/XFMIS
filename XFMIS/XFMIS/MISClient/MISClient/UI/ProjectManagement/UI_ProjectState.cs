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
using MISClient.Kit;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_ProjectState : MISClient.UI.ProjectManagement.UI_Ancestor1
    {
        public UI_ProjectState()
        {
            InitializeComponent();
            InitData();
            InitGrid();
            currentRow = -1;
        }

        private void InitData()
        {
            this.Text = "工程状态";
            groupControl1.Text = "工程状态管理";
            simpleButton1.Click += simpleButton1_Click;
            simpleButton2.Click += simpleButton2_Click;
            gridView1.FocusedRowChanged += base.gridView1_FocusedRowChanged;
            gridView1.CustomDrawRowIndicator += base.gridView1_CustomDrawRowIndicator;
        }

        private void InitGrid()
        {
            service = new Service_ProjectManagement.Service_ProjectManagement();
            MISClient.Service_ProjectManagement.TabProjectState[] projectState = service.Select_ProjectState();
            gridControl1.DataSource = projectState;
            gridView1.Columns[0].Visible = false;

            DataAlias.setTableCaption("TabPS", gridView1);

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
        }

        /// <summary>
        /// 添加按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MISClient.Service_ProjectManagement.TabProjectState projectState = new Service_ProjectManagement.TabProjectState();
            service = new Service_ProjectManagement.Service_ProjectManagement();
            projectState.PSValue = textEdit1.Text.Trim();
            service.Create_ProjectState(projectState);
            textEdit1.Text = "";
            InitGrid();
        }
        /// <summary>
        /// 删除按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (currentRow >= 0 && gridView1.RowCount > 0)
            {
                service.Delete_ProjectState(int.Parse(gridView1.GetRowCellValue(currentRow, "PSID").ToString()));
                InitGrid();
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }
    }
}
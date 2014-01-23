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
    public partial class UI_ProjectCategory : MISClient.UI.ProjectManagement.UI_Ancestor1
    {
        public UI_ProjectCategory()
        {
            InitializeComponent();
            InitData();
            InitGrid();
            currentRow = -1;
        }

        private void InitData()
        {
            this.Text = "工程类别";
            groupControl1.Text = "工程类别管理";
            simpleButton1.Click += simpleButton1_Click;
            simpleButton2.Click += simpleButton2_Click;
            gridView1.FocusedRowChanged += base.gridView1_FocusedRowChanged;
            gridView1.CustomDrawRowIndicator += base.gridView1_CustomDrawRowIndicator;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void InitGrid()
        {
            service = new Service_ProjectManagement.Service_ProjectManagement();
            MISClient.Service_ProjectManagement.TabProjectCategory[] projectCategory = service.Select_ProjectCategory();
            gridControl1.DataSource = projectCategory;
            gridView1.Columns[0].Visible = false;

            DataAlias.setTableCaption("TabPC", gridView1);
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        /// <summary>
        /// 添加按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MISClient.Service_ProjectManagement.TabProjectCategory projectCategory = new Service_ProjectManagement.TabProjectCategory();
            service = new Service_ProjectManagement.Service_ProjectManagement();
            projectCategory.PCName = textEdit1.Text.Trim();
            service.Create_ProjectCategory(projectCategory);
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
                service.Delete_ProjectCategory(int.Parse(gridView1.GetRowCellValue(currentRow, "PCID").ToString()));
                InitGrid();
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }
    }
}
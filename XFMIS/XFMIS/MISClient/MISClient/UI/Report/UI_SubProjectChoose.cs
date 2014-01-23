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

namespace MISClient.UI.Report
{
    public partial class UI_SubProjectChoose : DevExpress.XtraEditors.XtraForm
    {
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();
        MISClient.Service_ProjectManagement.TabProjectInfo[] allProject = null;
        MISClient.Service_ProjectManagement.TabSubProjectInfo[] allSubProject = null;

        public int projectID = 0;
        public bool mainOrSubProject = true;//如果是ture,则是主项目被选中;如果是false,则是子项目被选中

        public UI_SubProjectChoose()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UI_SubProjectChoose_Load(object sender, EventArgs e)
        {
            allProject = service_ProjectManagement.Select_ProjectInfo();

            gridControl1.DataSource = allProject;
            gridView1.OptionsBehavior.Editable = false;

            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
            {
                column.Visible = false;
            }

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

            //锁定表头,禁止拖动
            gridView2.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView2.OptionsView.ShowGroupPanel = false;

            gridView1.Columns["PNO"].Visible = true;
            gridView1.Columns["PName"].Visible = true;
            gridControl1_Click(gridControl1, null);

            //表头汉化
            Kit.DataAlias.setTableCaption("TabProjectInfo", gridView1);

            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
            Kit.CommonInit.InitGrid(gridView2);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
                return;
            int currentRow = gridView1.GetSelectedRows()[0];
            if (currentRow >= 0)
            {
                int projectID = int.Parse(gridView1.GetRowCellValue(currentRow, "PID").ToString());
                allSubProject = service_ProjectManagement.Select_SubProjectInfo_ByProjectID(projectID);

                gridControl2.DataSource = allSubProject;
                gridView2.OptionsBehavior.Editable = false;

                gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;

                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView2.Columns)
                {
                    column.Visible = false;
                }
                gridView2.Columns["SPNO"].Visible = true;
                gridView2.Columns["SPName"].Visible = true;

                //表头汉化
                Kit.DataAlias.setTableCaption("TabSubProjectInfo", gridView2);

                mainOrSubProject = true;
            }
            else
                return;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (mainOrSubProject)//如果用户选定的是主工程
            {
                if (gridView1.GetSelectedRows().Length <= 0)
                {
                    MessageBox.Show("请选择确定的一行！", "提示");
                    return;
                }
                int currentRow = gridView1.GetSelectedRows()[0];
                projectID = int.Parse(gridView1.GetRowCellValue(currentRow, "PID").ToString());
                this.DialogResult = DialogResult.OK;
            }
            else//如果用户选定的是子工程
            {
                if (gridView2.GetSelectedRows().Length <= 0)
                {
                    MessageBox.Show("请选择确定的一行！", "提示");
                    return;
                }
                int currentRow = gridView2.GetSelectedRows()[0];
                projectID = int.Parse(gridView2.GetRowCellValue(currentRow, "SPID").ToString());
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
                return;
            int currentRow = gridView1.GetSelectedRows()[0];
            if (currentRow >= 0)
            {
                mainOrSubProject = false;
            }
        }

    }
}
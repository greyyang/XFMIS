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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MISClient.Kit;

namespace MISClient.UI.NewProject
{
    public partial class UI_ProjectManagement : DevExpress.XtraEditors.XtraForm
    {
        public UI_ProjectManagement()
        {
            InitializeComponent();
            InitVisibleIndex();
            InitSplitGrid();
        }

        private void InitVisibleIndex()
        {
            //手动设置表头顺序
            gridView1.Columns["PState"].VisibleIndex = 15;
            gridView1.Columns["PAllocation"].VisibleIndex += 2;
        }

        MISClient.Service_NewProject.Service_NewProject service = null;
        MISClient.Service_ProjectManagement.Service_ProjectManagement pm = null;

        void InitSplitGrid()
        {
            //创建服务器连接
            service = new Service_NewProject.Service_NewProject();
            pm = new Service_ProjectManagement.Service_ProjectManagement();
            //从远程服务器获取数据
            MISClient.Service_NewProject.TabProjectInfo[] projectInfo = service.select_ProjectInfo();
            MISClient.Service_NewProject.TabSubProjectInfo[] subProjectInfo = service.select_SubProjectInfo();
            //绑定数据源并隐藏第一列ID
            gridControl1.DataSource = projectInfo;
            (gridControl1.MainView as GridView).Columns[0].Visible = false;
            gridControl2.DataSource = subProjectInfo;
            (gridControl2.MainView as GridView).Columns[0].Visible = false;
            (gridControl2.MainView as GridView).Columns[1].Visible = false;
            //修改英文表头为中文显示
            DataAlias.setTableCaption("TabProjectInfo", gridControl1.MainView as GridView);
            DataAlias.setTableCaption("TabSubProjectInfo", gridControl2.MainView as GridView);


            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;

            
            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            //设置不自动控制列宽
            this.gridView1.OptionsView.ColumnAutoWidth = false;

            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
            Kit.CommonInit.InitGrid(gridView2);
            //锁定一列的方法
            //(gridControl1.MainView as GridView).OptionsView.ColumnAutoWidth = false;
            //(gridControl1.MainView as GridView).Columns["PName"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
        }

        private void gridSplitContainer_SplitViewCreated(object sender, EventArgs e)
        {
            ////数据分页
            //GridSplitContainer gsc = sender as GridSplitContainer;
            //gsc.SplitChildGrid.UseEmbeddedNavigator = true;
            //gsc.Grid.UseEmbeddedNavigator = true;
        }

        /// <summary>
        /// 主项目删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
            {
                MessageBox.Show("请选定指定的一行!", "提示");
                return;
            }

            if (DialogResult.OK != MessageBox.Show("确定要删除此主项目吗?", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }

            service = new Service_NewProject.Service_NewProject();
            int projectInfoId = int.Parse((gridControl1.MainView as GridView).GetRowCellValue((gridControl1.MainView as GridView).GetSelectedRows()[0], "PID").ToString());
            service.delete_ProjectInfo(projectInfoId);
            InitSplitGrid();
        }
        /// <summary>
        /// 主项目修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
            {
                MessageBox.Show("请选定指定的一行!", "提示");
                return;
            }

            int projectInfoId = int.Parse((gridControl1.MainView as GridView).GetRowCellValue((gridControl1.MainView as GridView).GetSelectedRows()[0], "PID").ToString());
            Service_ProjectManagement.TabProjectInfo project = pm.Select_ProjectInfoByID(projectInfoId);
            ProjectManagement.UI_ModifyProject mp = new ProjectManagement.UI_ModifyProject(project);
            if (DialogResult.OK == mp.ShowDialog())
            {
                InitSplitGrid();
                MessageBox.Show("主项目信息修改成功!", "提示");
            }
        }
        /// <summary>
        /// 添加子项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            UI_NewSubProject ui_NewSubproject = new UI_NewSubProject();
            if (DialogResult.OK == ui_NewSubproject.ShowDialog())
            {
                InitSplitGrid();
            }
        }
        /// <summary>
        /// 修改子项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (gridView2.GetSelectedRows().Length <= 0)
            {
                MessageBox.Show("请选定指定的一行!", "提示");
                return;
            }

            int subProjectInfoId = int.Parse((gridControl2.MainView as GridView).GetRowCellValue((gridControl2.MainView as GridView).GetSelectedRows()[0], "SPID").ToString());
            Service_ProjectManagement.TabSubProjectInfo subProject = pm.Query_SubProjectInfo_ByID(subProjectInfoId);
            ProjectManagement.UI_ModifySubProject msp = new ProjectManagement.UI_ModifySubProject(subProject);
            if (DialogResult.OK == msp.ShowDialog())
            {
                InitSplitGrid();
                MessageBox.Show("子项目信息修改成功!", "提示");
            }
        }
        /// <summary>
        /// 子项目删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton6_Click(object sender, EventArgs e)
        {

            if (gridView2.GetSelectedRows().Length <= 0)
            {
                MessageBox.Show("请选定指定的一行!", "提示");
                return;
            }

            if (DialogResult.OK != MessageBox.Show("确定要删除此子项目吗?", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }

            service = new Service_NewProject.Service_NewProject();
            int subProjectInfoId = int.Parse((gridControl2.MainView as GridView).GetRowCellValue((gridControl2.MainView as GridView).GetSelectedRows()[0], "SPID").ToString());
            service.delete_subProjectInfo(subProjectInfoId);
            InitSplitGrid();
        }
        /// <summary>
        /// 添加主项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UI_NewProject ui_NewProject = new UI_NewProject();
            if (DialogResult.OK == ui_NewProject.ShowDialog())
            {
                InitSplitGrid();
            }
        }
        /// <summary>
        /// 项目信息按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                MISClient.Service_NewProject.TabProjectInfo projectInfo = (MISClient.Service_NewProject.TabProjectInfo)gridView1.GetFocusedRow();

                UI_ProjectExInto ui_ProjectExInfo = new UI_ProjectExInto(projectInfo);
                if (DialogResult.OK == ui_ProjectExInfo.ShowDialog())
                {
                    InitSplitGrid();
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提醒");
            }
        }

        /// <summary>
        /// 合同信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            UI_ImageManage ui_imageManage = new UI_ImageManage();
            ui_imageManage.ShowDialog();
        }
    }
}
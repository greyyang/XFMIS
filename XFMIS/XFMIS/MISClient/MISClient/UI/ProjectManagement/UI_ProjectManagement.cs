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
using MISClient.Service_ProjectManagement;
using DevExpress.XtraGrid.Views.Grid;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_ProjectManagement : DevExpress.XtraEditors.XtraForm
    {
        public UI_ProjectManagement()
        {
            InitializeComponent();
            InitGrid();
            InitAction();
        }

        int currentRow = -1;
        int subCurrentRow = -1;

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();

        TabProjectInfo[] projectInfos = null;
        TabSubProjectInfo[] subProjectInfos = null;

        /// <summary>
        /// 初始化表格
        /// </summary>
        /// <returns>返回主工程数据条数</returns>
        public void InitGrid()
        {
            projectInfos = service_ProjectManagement.Select_ProjectInfo();
            subProjectInfos = service_ProjectManagement.Select_SubProjectInfo();

            gridControl1.DataSource = projectInfos;
            gridControl2.DataSource = subProjectInfos;

            DataAlias.setTableCaption("TabProjectInfo", gridView1);
            DataAlias.setTableCaption("TabSubProjectInfo", gridView2);

            gridView2.Columns[0].Visible = false;
            gridView1.Columns[0].Visible = false;
            gridView2.Columns["SPProjectID"].Visible = false;
            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            gridView2.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            //不显示过滤面板
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;

            //显示水平滚动条
            gridView1.OptionsView.ColumnAutoWidth = false;

            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
            Kit.CommonInit.InitGrid(gridView2);

        }

        public void InitAction()
        {
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridView2.FocusedRowChanged += gridView2_FocusedRowChanged;
            gridView1_FocusedRowChanged(gridView1, null);
            gridView2_FocusedRowChanged(gridView2, null);
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator ;
            gridView2.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
            //左边栏宽度
            this.gridView1.IndicatorWidth = 40;
            this.gridView2.IndicatorWidth = 40;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (int.Parse(e.RowHandle.ToString()) + 1).ToString() ;
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                subCurrentRow = gridView2.GetSelectedRows()[0];
            }
            else
            {
                subCurrentRow = -1;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                currentRow = gridView1.GetSelectedRows()[0];
                FilterSubGrid(int.Parse(gridView1.GetRowCellDisplayText(currentRow, "PID").ToString()));
            }
            else
            {
                currentRow = -1;
            }
        }

        private void FilterSubGrid(int projectID)
        {
            DevExpress.XtraGrid.Columns.GridColumn col_projectID = gridView2.Columns["SPProjectID"];
            col_projectID.FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[SPProjectID]=" + projectID);
        }

        /// <summary>
        /// 添加协议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string subID = gridView2.GetFocusedRowCellDisplayText("SPID");
            if (!string.IsNullOrEmpty(subID))
            {
                int subProjectID = int.Parse(subID);
                TabSubProjectInfo sp = service_ProjectManagement.Query_SubProjectInfo_ByID(subProjectID);
                UI_AddDeal add_deal = new UI_AddDeal(sp);
                if (add_deal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InitGrid();
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行!", "提示");
            }
        }

        /// <summary>
        /// 修改工程状态记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            UI_StateRecord stateRecord = new UI_StateRecord();
            stateRecord.ShowDialog();
        }
    }
}
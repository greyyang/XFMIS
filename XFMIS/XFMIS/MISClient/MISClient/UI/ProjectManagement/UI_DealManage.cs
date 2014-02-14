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
using MISClient.Service_ProjectManagement;
using DevExpress.XtraEditors.Controls;
using MISClient.Kit;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_DealManage : DevExpress.XtraEditors.XtraForm
    {
        public UI_DealManage()
        {
            InitializeComponent();
            InitGrid();
            InitOther();
        }

        private void InitOther()
        {
            //主工程
            TabProjectInfo[] projectInfo = service_PM.Select_ProjectInfo();
            lookUpEdit1.Properties.DataSource = projectInfo;
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PNO"));
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PName"));
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PID"));

            lookUpEdit1.Properties.Columns["PNO"].Caption = "工程编号";
            lookUpEdit1.Properties.Columns["PName"].Caption = "工程名称";
            lookUpEdit1.Properties.Columns["PID"].Visible = false;

            lookUpEdit1.Properties.DisplayMember = "PName";
            lookUpEdit1.Properties.ValueMember = "PID";
        }

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        TabDeal[] deal = null;

        private void InitGrid()
        {
            deal = service_PM.Select_Deal();
            gridControl1.DataSource = deal;

            gridView1.Columns["DLID"].Visible = false;
            DataAlias.setTableCaption("TabDL", gridView1);
            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            //隐藏过滤面板
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);

        }
        /// <summary>
        /// 筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.Columns["DLSubProjectID"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[DLSubProjectID] =" + lookUpEdit2.EditValue.ToString());
        }
        /// <summary>
        /// 删除协议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定删除", "提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (gridView1.GetSelectedRows().Length > 0)
                {
                    int id = int.Parse(gridView1.GetFocusedRowCellValue("DLID").ToString());
                    if (0 < service_PM.Delete_Deal(id))
                    {
                        MessageBox.Show("删除成功！", "提示");
                        InitGrid();
                    }
                }
            }
        }
        /// <summary>
        /// 清空修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView1.Columns["DLSubProjectID"].ClearFilter();
        }

        private void InitSubLookUp(int PID)
        {
            //子工程
            lookUpEdit2.Properties.Columns.Clear();
            TabSubProjectInfo[] subProject = service_PM.Select_SubProjectInfo_ByProjectID(PID);
            lookUpEdit2.Properties.DataSource = subProject;
            lookUpEdit2.Properties.Columns.Add(new LookUpColumnInfo("SPNO"));
            lookUpEdit2.Properties.Columns.Add(new LookUpColumnInfo("SPName"));
            lookUpEdit2.Properties.Columns.Add(new LookUpColumnInfo("SPID"));

            lookUpEdit2.Properties.Columns["SPNO"].Caption = "工程编号";
            lookUpEdit2.Properties.Columns["SPName"].Caption = "工程名称";
            lookUpEdit2.Properties.Columns["SPID"].Visible = false;

            lookUpEdit2.Properties.DisplayMember = "SPName";
            lookUpEdit2.Properties.ValueMember = "SPID";
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue != null)
            {
                InitSubLookUp(int.Parse(lookUpEdit1.EditValue.ToString()));
            }
        }
    }
}
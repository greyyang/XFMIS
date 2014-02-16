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
using DevExpress.XtraGrid.Views.Grid;
using MISClient.Kit;

namespace MISClient.UI.NewProject
{
    public partial class UI_NewPlaning : DevExpress.XtraEditors.XtraForm
    {

        decimal gb_money = 0;
        public UI_NewPlaning()
        {
            InitializeComponent();
            InitGrid();
            InitGroup();
            InitLabel();
        }

        private void InitLabel()
        {
            if (projectInfo.Length > 0)
            {
                labelControl2.Text = gridView1.GetRowCellValue(0, "PNO").ToString();
                labelControl4.Text = gridView1.GetRowCellValue(0, "PName").ToString();
            }
        }
        MISClient.Service_NewProject.Service_NewProject service = null;
        MISClient.Service_NewProject.TabProjectInfo[] projectInfo = null;
        int selectRow = -1;
        /// <summary>
        /// 初始化表格
        /// </summary>
        private void InitGrid()
        {
            service = new Service_NewProject.Service_NewProject();
            projectInfo = service.select_ProjectInfo();
            gridControl1.DataSource = projectInfo;
            GridView view = (gridControl1.MainView as GridView);
            view.Columns[0].Visible = false;
            DataAlias.setTableCaption("TabProjectInfo", view);
            view.OptionsView.ColumnAutoWidth = false;
            view.Columns["PAllocation"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            //显示页脚汇总（需要在OptionView中设置Showfooter为true）
            view.Columns["PAllocation"].Width = 150;
            view.Columns["PAllocation"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            view.Columns["PAllocation"].SummaryItem.DisplayFormat = "总计金额：￥{0:N2}";
            //不能修改单元格，选择一行
            view.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            view.OptionsSelection.EnableAppearanceFocusedCell = false;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }
        /// <summary>
        /// 初始化Group板块
        /// </summary>
        private void InitGroup()
        {
            labelControl2.Text = "";
            labelControl4.Text = "";
        }
        /// <summary>
        /// 行变换的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = (gridControl1.MainView as GridView);
            if (view.GetSelectedRows().Length > 0)
            {
                selectRow = view.GetSelectedRows()[0];
                labelControl2.Text = view.GetRowCellValue(selectRow, "PNO").ToString();
                labelControl4.Text = view.GetRowCellValue(selectRow, "PName").ToString();
                gb_money = decimal.Parse(view.GetRowCellValue(selectRow, "PAuditors").ToString());
                if (view.GetRowCellValue(selectRow, "PAuditors") != null && view.GetRowCellValue(selectRow, "PAllocation") != null)
                {
                    decimal auditors = decimal.Parse(view.GetRowCellValue(selectRow, "PAuditors").ToString());
                    decimal allocation = decimal.Parse(view.GetRowCellValue(selectRow, "PAllocation").ToString());
                    decimal percentage = (allocation / auditors * 100);
                    textEdit1.Text = allocation.ToString();
                    textEdit2.Text = percentage.ToString();
                }
                else
                {
                    textEdit1.Text = "";
                    textEdit2.Text = "";
                }
            }
        }
        /// <summary>
        /// 确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MISClient.Service_NewProject.TabProjectInfo projectInfo = new Service_NewProject.TabProjectInfo();
            GridView view = (gridControl1.MainView as GridView);
            if (!String.IsNullOrEmpty(textEdit1.Text))
            {
                if (selectRow >= 0)
                {
                    service = new Service_NewProject.Service_NewProject();
                    projectInfo.PID = int.Parse(view.GetRowCellValue(selectRow, "PID").ToString());
                    try
                    {
                        projectInfo.PAllocation = decimal.Parse(textEdit1.Text);

                    }
                    catch
                    {
                        MessageBox.Show("请输入数字！", "提示");
                        textEdit1.Text = "";
                    }
                    try
                    {
                        service.update_Plan(projectInfo);
                        int row = view.FocusedRowHandle;
                        InitGrid();
                        view.FocusedRowHandle = row;
                    }
                    catch
                    {
                        MessageBox.Show("服务器出错！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("请选择确定的一行！", "提示");
                }
            }
            else
            {
                MessageBox.Show("请输入值！", "提示");
            }
        }

        /// <summary>
        /// 分包金额文本框失去焦点时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEdit1_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textEdit1.Text))
            {
                try
                {
                    decimal plan = decimal.Parse(textEdit1.Text.ToString());
                    textEdit2.Text = (plan / gb_money * 100).ToString();
                }
                catch
                {
                    MessageBox.Show("请输入正确格式的数据。", "提示");
                    textEdit1.Text = "";
                }
            }
        }

        /// <summary>
        /// 比例文本框失去焦点时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEdit2_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textEdit2.Text))
            {
                try
                {
                    decimal percentage = decimal.Parse(textEdit2.Text.ToString()) / 100;
                    textEdit1.Text = (gb_money * percentage).ToString();
                }
                catch
                {
                    MessageBox.Show("请输入正确格式的数据。", "提示");
                    textEdit2.Text = "";
                }
            }
        }
    }
}
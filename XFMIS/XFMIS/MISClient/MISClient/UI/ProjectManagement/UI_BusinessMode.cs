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
    public partial class UI_BusinessMode : DevExpress.XtraEditors.XtraForm
    {

        MISClient.Service_ProjectManagement.Service_ProjectManagement service = null;
        int currentRow = -1;
        public UI_BusinessMode()
        {
            InitializeComponent();
            InitGrid();
            currentRow = -1;
        }

        /// <summary>
        /// 行变换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            currentRow = gridView1.GetSelectedRows()[0];
        }

        private void InitGrid()
        {
            service = new Service_ProjectManagement.Service_ProjectManagement();
            MISClient.Service_ProjectManagement.TabBusinessMode[] businessModes = service.Select_BusinessMode();
            gridControl1.DataSource = businessModes;
            gridView1.Columns[0].Visible = false;
            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            //左边栏宽度
            this.gridView1.IndicatorWidth = 40;

            DataAlias.setTableCaption("TabBP", gridView1);

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
        }

        /// <summary>
        /// 显示行号的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        /// <summary>
        /// 添加按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MISClient.Service_ProjectManagement.TabBusinessMode businessModes = new Service_ProjectManagement.TabBusinessMode();
            service = new Service_ProjectManagement.Service_ProjectManagement();
            businessModes.BPValue = textAdd.Text.Trim();
            service.Create_BusinessMode(businessModes);
            this.textAdd.Text = "";
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
                service.Delete_BusinessMode(int.Parse(gridView1.GetRowCellValue(currentRow, "BPID").ToString()));
                InitGrid();
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }


    }
}
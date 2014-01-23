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
using MISClient.Kit;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_SubContractor : DevExpress.XtraEditors.XtraForm
    {
        public UI_SubContractor()
        {
            InitializeComponent();
            InitGrid();
        }

        int currentRow = -1;
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = null;


        public void InitGrid()
        {
            service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();
            MISClient.Service_ProjectManagement.TabSubContractor[] subContractors = service_ProjectManagement.Select_SubContractor();
            gridControl1.DataSource = subContractors;
            gridView1.Columns[0].Visible = false;
            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

            //表头汉化
            DataAlias.setTableCaption("TabSC", gridView1);

            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        /// <summary>
        /// 添加分包单位的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //利用添加的构造方法构造UI_AMSubContrator
            UI_AMSubContractor ui_addSC = new UI_AMSubContractor();
            if (ui_addSC.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitGrid();
            }
        }
        /// <summary>
        /// 修改分包单位的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (currentRow >= 0)
            {
                MISClient.Service_ProjectManagement.TabSubContractor subcontractor = new Service_ProjectManagement.TabSubContractor();
                subcontractor.SCID = int.Parse(gridView1.GetRowCellValue(currentRow, "SCID").ToString());
                subcontractor.SCName = gridView1.GetRowCellValue(currentRow, "SCName").ToString();
                subcontractor.SCBank = gridView1.GetRowCellValue(currentRow, "SCBank").ToString();
                subcontractor.SCBankAccount = gridView1.GetRowCellValue(currentRow, "SCBankAccount").ToString();
                subcontractor.SCContactor = gridView1.GetRowCellValue(currentRow, "SCContactor").ToString();
                subcontractor.SCTel = gridView1.GetRowCellValue(currentRow, "SCTel").ToString();
                //利用修改的构造方法构造UI_AMSubContrator
                UI_AMSubContractor ui_modifySC = new UI_AMSubContractor(subcontractor);
                if (ui_modifySC.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InitGrid();
                }
            }
        }
        /// <summary>
        /// 删除分包单位的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (currentRow >= 0 && gridView1.RowCount > 0)
            {
                service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();
                string name = gridView1.GetRowCellValue(currentRow, "SCName").ToString();
                if (MessageBox.Show("确定删除：" + name, "提示",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    service_ProjectManagement.Delete_SubContractor(int.Parse(gridView1.GetRowCellValue(currentRow, "SCID").ToString()));
                    InitGrid();
                }
            }
        }

        /// <summary>
        /// 行变换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                currentRow = gridView1.GetSelectedRows()[0];
            }
        }
    }
}
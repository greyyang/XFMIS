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
    public partial class UI_ShowMaterialFlow : DevExpress.XtraEditors.XtraForm
    {
        Service_ProjectManagement.TabMaterialFlow[] materialFlowList = null;
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();
        bool ifShowAll;
        int materialID;

        public UI_ShowMaterialFlow(bool ifShowAll, int materialID)
        {
            InitializeComponent();
            this.ifShowAll = ifShowAll;
            this.materialID = materialID;
            RefreshMaterialFlow();

            DataAlias.setTableCaption("TabMF", gridView1);
            gridView1.Columns[0].Visible = false;
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        /// <summary>
        /// 先更新数据,然后显示
        /// </summary>
        private void RefreshMaterialFlow()
        {
            if (ifShowAll)
                this.materialFlowList = service_ProjectManagement.Select_MaterialFlowAll();
            else
                this.materialFlowList = service_ProjectManagement.Select_MaterialFlowByMaterialID(materialID);
            ShowMaterialFlow();
        }

        /// <summary>
        /// 单纯显示数据
        /// </summary>
        private void ShowMaterialFlow()
        {
            List<Service_ProjectManagement.TabMaterialFlow> showMaterialFlowList = new List<Service_ProjectManagement.TabMaterialFlow>();


            if (ce_MaterialIn.Checked && ce_MaterialOut.Checked)//全部显示
            {
                gridControl1.DataSource = materialFlowList;

            }
            else if (ce_MaterialIn.Checked)//只显示入库
            {
                foreach (Service_ProjectManagement.TabMaterialFlow materialFlow in materialFlowList)
                {
                    if (materialFlow.MFFlag == 1)
                        showMaterialFlowList.Add(materialFlow);
                }
                gridControl1.DataSource = showMaterialFlowList.ToArray();

            }
            else if (ce_MaterialOut.Checked)//只显示出库
            {
                foreach (Service_ProjectManagement.TabMaterialFlow materialFlow in materialFlowList)
                {
                    if (materialFlow.MFFlag == 0)
                        showMaterialFlowList.Add(materialFlow);
                }
                gridControl1.DataSource = showMaterialFlowList.ToArray();
            }
            else//全部都不显示
            {
                gridControl1.DataSource = showMaterialFlowList.ToArray();

            }

            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
            int currentRow = gridView1.GetSelectedRows()[0];

            if (currentRow >= 0)
            {
                if (MessageBox.Show("是否确定删除此流水记录！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Service_ProjectManagement.TabMaterialFlow materialFlow = new Service_ProjectManagement.TabMaterialFlow();
                    int materialFlowID = int.Parse(gridView1.GetRowCellValue(currentRow, "MFID").ToString());
                    materialFlow.MFID = materialFlowID;
                    service_ProjectManagement.Delete_MaterialFlow(materialFlow);
                    RefreshMaterialFlow();
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
            int currentRow = gridView1.GetSelectedRows()[0];

            if (currentRow >= 0)
            {

                int materialFlowID = int.Parse(gridView1.GetRowCellValue(currentRow, "MFID").ToString());
                Service_ProjectManagement.TabMaterialFlow materialFlow = service_ProjectManagement.Select_MaterialFlowByID(materialFlowID);

                UI_ModifyMaterialFlow mmf = new UI_ModifyMaterialFlow(materialFlow);
                if (mmf.ShowDialog() == DialogResult.OK)
                {
                    RefreshMaterialFlow();
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
        }

        private void UI_ShowMaterialFlow_Load(object sender, EventArgs e)
        {
            ShowMaterialFlow();
        }

        private void ce_MaterialOut_CheckedChanged(object sender, EventArgs e)
        {
            ShowMaterialFlow();
        }

        private void ce_MaterialIn_CheckedChanged(object sender, EventArgs e)
        {
            ShowMaterialFlow();
        }
    }
}
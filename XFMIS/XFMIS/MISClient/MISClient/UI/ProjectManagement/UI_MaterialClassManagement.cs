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
    public partial class UI_MaterialClassManagement : DevExpress.XtraEditors.XtraForm
    {

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();


        public UI_MaterialClassManagement()
        {
            InitializeComponent();
            InitVisableIndex();
        }

        private void InitVisableIndex()
        {
            //材料类别与材料备注位置互换
            int temp = gridView1.Columns["MClass"].VisibleIndex;
            gridView1.Columns["MClass"].VisibleIndex = gridView1.Columns["MMemo"].VisibleIndex;
            gridView1.Columns["MMemo"].VisibleIndex = temp;
        }

        private void showAllMaterialClass()
        {
            //读取所有材料类别
            Service_ProjectManagement.TabMaterial[] materialList = service_ProjectManagement.Select_MaterialClass();
            //数据绑定
            gc_MaterialClassList.DataSource = materialList;
            //隐藏ID列
            gridView1.Columns["MID"].Visible = false;
            //汉化表头
            DataAlias.setTableCaption("TabM", gridView1);

            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            //隐藏库存列
            gridView1.Columns["MCount"].Visible = false;
            

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        private void UI_MaterialClassManagement_Load(object sender, EventArgs e)
        {
            showAllMaterialClass();

        }

        private void btn_AddMaterialClass_Click(object sender, EventArgs e)
        {
            UI_AddMaterialClass amc = new UI_AddMaterialClass();
            if (amc.ShowDialog() == DialogResult.OK)
                showAllMaterialClass();
        }

        private void btn_ModifyMaterialClass_Click(object sender, EventArgs e)
        {
            Service_ProjectManagement.TabMaterial material = null;

            //int currentRow = gridView1.GetSelectedRows()[0];
            if (!string.IsNullOrEmpty(gridView1.GetFocusedRowCellDisplayText("MID")))
            {
                int materialID = int.Parse(gridView1.GetFocusedRowCellDisplayText("MID"));
                material = service_ProjectManagement.Select_MaterialClassByID(materialID);
                UI_ModifyMaterialClass mmc = new UI_ModifyMaterialClass(material);
                if (mmc.ShowDialog() == DialogResult.OK)
                {
                    showAllMaterialClass();
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
            //if (currentRow >= 0)
            //{
            //    int materialID = int.Parse(gridView1.GetRowCellValue(currentRow, "MID").ToString());
            //    material = service_ProjectManagement.Select_MaterialClassByID(materialID);
            //}
            //else
            //{
            //    MessageBox.Show("请选择确定的一行！", "提示");
            //    return;
            //}
        }

        private void btn_DeleteMaterialClass_Click(object sender, EventArgs e)
        {
            //int currentRow = gridView1.GetSelectedRows()[0];
            //if (currentRow >= 0)
            //{
            //    if (MessageBox.Show("是否确定删除此材料类别！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    {
            //        Service_ProjectManagement.TabMaterial material = new Service_ProjectManagement.TabMaterial();
            //        int materialID = int.Parse(gridView1.GetRowCellValue(currentRow, "MID").ToString());
            //        material.MID = materialID;
            //        service_ProjectManagement.Delete_MaterialClass(material);
            //        showAllMaterialClass();
            //    }
            //}
            if (!string.IsNullOrEmpty(gridView1.GetFocusedRowCellDisplayText("MID")))
            {
                if (MessageBox.Show("是否确定删除此材料类别！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Service_ProjectManagement.TabMaterial material = new Service_ProjectManagement.TabMaterial();
                    int materialID = int.Parse(gridView1.GetFocusedRowCellDisplayText("MID"));
                    material.MID = materialID;
                    service_ProjectManagement.Delete_MaterialClass(material);
                    showAllMaterialClass();
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
        }
    }
}
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
    public partial class UI_MaterialFlowManagement : DevExpress.XtraEditors.XtraForm
    {

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();


        public UI_MaterialFlowManagement()
        {
            InitializeComponent();
        }

        private void UI_MaterialFlowManagement_Load(object sender, EventArgs e)
        {
            showMaterialCount();
            //汉化表头
            DataAlias.setTableCaption("TabM", gridView1);
            gridView1.Columns[0].Visible = false;
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        private void showMaterialCount()
        {
            //读取所有材料类别
            Service_ProjectManagement.TabMaterial[] materialList = service_ProjectManagement.Select_MaterialClass();

            //gridView1.Columns[0].Visible = false;
            gc_MaterialCountList.DataSource = materialList;


            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

        }


        private void btn_ShowAllMaterialFlow_Click(object sender, EventArgs e)
        {

            UI_ShowMaterialFlow smf = new UI_ShowMaterialFlow(true, 0);
            smf.ShowDialog();
            showMaterialCount();
        }

        private void btnShowChooseMaterialFlow_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
            int currentRow = gridView1.GetSelectedRows()[0];

            if (currentRow >= 0)
            {

                Service_ProjectManagement.TabMaterial material = new Service_ProjectManagement.TabMaterial();
                int materialID = int.Parse(gridView1.GetRowCellValue(currentRow, "MID").ToString());

                UI_ShowMaterialFlow smf = new UI_ShowMaterialFlow(false, materialID);
                smf.ShowDialog();

            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (UI_AddMaterialFlow amf = new UI_AddMaterialFlow())
            {
                amf.ShowDialog();
            }
            showMaterialCount();
        }
    }
}
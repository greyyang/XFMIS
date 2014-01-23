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

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_Customer : MISClient.UI.ProjectManagement.UI_Ancestor1
    {
        public UI_Customer()
        {
            InitializeComponent();
            InitData();
            InitGrid();
            currentRow = -1;
        }

        private void InitData()
        {
            this.Text = "客户维度";
            groupControl1.Text = "客户维度管理";
            simpleButton1.Click += simpleButton1_Click;
            simpleButton2.Click += simpleButton2_Click;
            gridView1.FocusedRowChanged += base.gridView1_FocusedRowChanged;
            gridView1.CustomDrawRowIndicator += base.gridView1_CustomDrawRowIndicator;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
        }

        private void InitGrid()
        {
            service = new Service_ProjectManagement.Service_ProjectManagement();
            MISClient.Service_ProjectManagement.TabCustomer[] customer = service.Select_Customer();
            gridControl1.DataSource = customer;
            gridView1.Columns[0].Visible = false;
            DataAlias.setTableCaption("TabCU", gridView1);
            
        }

        /// <summary>
        /// 添加按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MISClient.Service_ProjectManagement.TabCustomer customer = new Service_ProjectManagement.TabCustomer();
            service = new Service_ProjectManagement.Service_ProjectManagement();
            customer.CUValue = textEdit1.Text.Trim();
            service.Create_Customer(customer);
            textEdit1.Text = "";
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
                service.Delete_Customer(int.Parse(gridView1.GetRowCellValue(currentRow, "CUID").ToString()));
                InitGrid();
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
            }
        }


        //显示行的序号 
        private new void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
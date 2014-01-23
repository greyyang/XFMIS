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
namespace MISClient.UI.FinanceManagement
{
    public partial class UI_MoneyPool : DevExpress.XtraEditors.XtraForm
    {
        public UI_MoneyPool()
        {
            InitializeComponent();
            InitGrid();
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        MISClient.Service_FinanceManagement.TabMoneyPool[] tabMoneyPool = null;

        private void InitGrid()
        {
            tabMoneyPool = service_FM.select_MoneyPool();
            gridControl1.DataSource = tabMoneyPool;
            gridView1.Columns["MPID"].Visible = false;
            gridView1.Columns["MPFlag"].Visible = false;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;

            //表头汉化
            Kit.DataAlias.setTableCaption("TabMP", gridView1);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Kit.CommonInit.InitGrid(gridView1);
        }

        /// <summary>
        /// 控制行颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string flag = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["MPFlag"]);
                if (flag == "0")
                {
                    e.Appearance.BackColor = Color.Red;
                }
                else if (flag == "1")
                {
                    e.Appearance.BackColor = Color.Green;
                }
            }
        }
        /// <summary>
        /// 资金入池
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("请输入合法数据!", "提示");
                return;
            }

            decimal? money = decimal.Parse(textEdit1.Text);
            MISClient.Service_FinanceManagement.TabMoneyPool entity = new Service_FinanceManagement.TabMoneyPool();

            entity.MPHandler = GlobeVariable.getInstance().username;
            entity.MPMemo = memoEdit1.Text;
            entity.MPMoney = money;
            entity.MPDate = DateTime.Now;
            entity.MPFlag = 1;

            service_FM.create_MoneyPool(entity);
            this.textEdit1.Text = "";
            this.memoEdit1.Text = "";
            InitGrid();
        }
        /// <summary>
        /// 资金出池
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("请输入合法数据!", "提示");
                return;
            }

            decimal? money = decimal.Parse(textEdit1.Text);
            MISClient.Service_FinanceManagement.TabMoneyPool entity = new Service_FinanceManagement.TabMoneyPool();

            entity.MPHandler = GlobeVariable.getInstance().username;
            entity.MPMemo = memoEdit1.Text;
            entity.MPMoney = money;
            entity.MPDate = DateTime.Now;
            entity.MPFlag = 0;

            service_FM.create_MoneyPool(entity);
            this.textEdit1.Text = "";
            this.memoEdit1.Text = "";
            InitGrid();
        }

        private bool check()
        {
            decimal d;
            return decimal.TryParse(textEdit1.Text, out d);
        }
    }
}
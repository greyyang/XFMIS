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
using MISClient.UI.BasicUI;
using MISClient.Kit;
namespace MISClient.UI.FinanceManagement
{
    public partial class UI_CostAndReimburse : UI_Ancestor4
    {
        public UI_CostAndReimburse(string _NO, string _name, int _id)
        {
            InitializeComponent();
            InitInherit(_NO, _name);
            InitGrid(_id);
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        Service_FinanceManagement.TabCostAndReimburse[] costAndReimburses;

        private void InitInherit(string _NO, string _name)
        {
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            base.Text = "开票回款明细";
            groupControl1.Text = "开票回款";
            label_NO.Text = _NO;
            label_Name.Text = _name;
        }

        private void InitGrid(int _id)
        {
            costAndReimburses = service_FM.select_TabCostAndReimburse_ByPID(_id);
            gridControl1.DataSource = costAndReimburses;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.Columns["CRID"].Visible = false;
            gridView1.Columns["CRSubProjectID"].Visible = false;

            //表头汉化
            Kit.DataAlias.setTableCaption("TabCostAndReimburse", gridView1);
            CommonInit.InitGrid(gridView1);
        }

    }
}
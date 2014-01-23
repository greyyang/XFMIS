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
namespace MISClient.UI.FinanceManagement
{
    public partial class UI_LoanRepay : UI_Ancestor4
    {
        public UI_LoanRepay(string _NO, string _name, int _id)
        {
            InitializeComponent();
            InitInherit(_NO, _name);
            InitGrid(_id);
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        Service_FinanceManagement.TabLoanRepay[] loanRepays;

        private void InitInherit(string _NO, string _name)
        {
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            base.Text = "借还款明细";
            groupControl1.Text = "借还款明细";
            label_NO.Text = _NO;
            label_Name.Text = _name;
        }

        private void InitGrid(int _id)
        {
            loanRepays = service_FM.select_TabLoanRepay_BySubID(_id);
            gridControl1.DataSource = loanRepays;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

            gridView1.Columns["LRID"].Visible = false;
            gridView1.Columns["LRSubProjectID"].Visible = false;

            //表头汉化
            Kit.DataAlias.setTableCaption("TabLoanRepay", gridView1);
            Kit.CommonInit.InitGrid(gridView1);
        }
    }
}
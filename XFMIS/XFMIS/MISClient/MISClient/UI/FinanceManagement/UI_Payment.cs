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
    public partial class UI_Payment : UI_Ancestor4
    {
        public UI_Payment(string _NO, string _name,int _id)
        {
            InitializeComponent();
            InitInherit(_NO,_name);
            InitGrid(_id);
        }

        MISClient.Service_FinanceManagement.Service_FinanceManagement service_FM = new Service_FinanceManagement.Service_FinanceManagement();
        Service_FinanceManagement.TabPayment[] payments;

        private void InitInherit(string _NO,string _name)
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
            payments = service_FM.select_TabPayment_ByPID(_id);
            gridControl1.DataSource = payments;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

            gridView1.Columns["PYID"].Visible = false;
            gridView1.Columns["PYSubProjectID"].Visible = false;

            //表头汉化
            Kit.DataAlias.setTableCaption("TabPayment", gridView1);
            Kit.CommonInit.InitGrid(gridView1);
        }
    }
}
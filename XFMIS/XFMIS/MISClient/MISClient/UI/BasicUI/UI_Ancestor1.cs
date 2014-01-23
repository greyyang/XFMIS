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

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_Ancestor1 : DevExpress.XtraEditors.XtraForm
    {

        public MISClient.Service_ProjectManagement.Service_ProjectManagement service = null;
        public int currentRow = -1;
        public UI_Ancestor1()
        {
            InitializeComponent();
            initAncestor();
        }

        private void initAncestor()
        {
            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            //左边栏宽度
            this.gridView1.IndicatorWidth = 40;

        }
        /// <summary>
        /// 显示行号的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        /// <summary>
        /// 行变换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                currentRow = gridView1.GetSelectedRows()[0];
            }
        }
    }
}
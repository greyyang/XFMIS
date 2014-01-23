using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISClient.Kit
{
    public static class CommonInit
    {
        public static void InitGrid(GridView gridView)
        {
            gridView.IndicatorWidth = 40;
            gridView.CustomDrawRowIndicator +=gridView_CustomDrawRowIndicator;
        }


        //显示行的序号 
        private static void gridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using MISClient.Kit;

namespace MISClient.UI.NewProject
{
    public partial class UI_ProjectSelect : DevExpress.XtraEditors.XtraForm
    {
        public UI_ProjectSelect()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            //表格样式
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;

            MISClient.Service_NewProject.Service_NewProject service = new Service_NewProject.Service_NewProject();
            MISClient.Service_NewProject.TabProjectInfo[] projectInfo = service.select_ProjectInfo();

            gridControl1.DataSource = projectInfo;
            gridView1.Columns[0].Visible = false;

            //初始化表头名称
            DataAlias.setTableCaption("TabProjectInfo", gridView1);
            gridView1.Columns[0].Visible = false;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        //#region 自定义表头右键菜单
        ///// <summary>
        ///// 映射GridStringId与本地化后的字段名
        ///// </summary>
        ///// <param name="menu"></param>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //private DXMenuItem GetItemByStringId(DXPopupMenu menu, GridStringId id)
        //{
        //    foreach (DXMenuItem item in menu.Items)
        //        if (item.Caption == GridLocalizer.Active.GetLocalizedString(id))
        //            return item;
        //    return null;
        //}
        ///// <summary>
        ///// 自定义表头右键菜单
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gridView1_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        //{
        //    if (e.MenuType == GridMenuType.Column)
        //    {
        //        //隐藏"不显示此字段"选项
        //        DXMenuItem hideItem1 = GetItemByStringId(e.Menu, GridStringId.MenuColumnRemoveColumn);
        //        if (hideItem1 != null)
        //            hideItem1.Visible = false;
        //        //隐藏"显示/隐藏字段选项"
        //        DXMenuItem hideItem2 = GetItemByStringId(e.Menu, GridStringId.MenuColumnColumnCustomization);
        //        if (hideItem2 != null)
        //            hideItem2.Visible = false;
        //    }
        //}
        //#endregion
    }
}
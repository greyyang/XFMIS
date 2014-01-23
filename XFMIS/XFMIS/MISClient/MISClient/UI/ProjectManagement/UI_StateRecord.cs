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
using MISClient.Service_ProjectManagement;
using MISClient.Kit;
using DevExpress.XtraGrid.Views.Grid;

namespace MISClient.UI.ProjectManagement
{
    public partial class UI_StateRecord : DevExpress.XtraEditors.XtraForm
    {
        public UI_StateRecord()
        {
            InitializeComponent();
            InitGrid();
        }

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();

        private void InitGrid()
        {

            TabStateRecord[] stateRecords = service_PM.Select_StateRecord();
            TabProjectInfo[] projects = service_PM.Select_ProjectInfo();
            TabSubProjectInfo[] subs = service_PM.Select_SubProjectInfo();

            List<FV_SR> projectR = new List<FV_SR>();
            List<FV_SR> subR = new List<FV_SR>();
            foreach (TabStateRecord t in stateRecords)
            {
                if (t.SRFlag == 0)
                {
                    //主工程
                    FV_SR sr = new FV_SR();
                    sr.FV_Date = t.SRDate;
                    sr.FV_Memo = t.SRMemo;
                    sr.FV_People = t.SRModifier;
                    TabProjectInfo p = service_PM.Select_ProjectInfoByID(t.SRProjectID);
                    sr.FV_PNO = p.PNO;
                    sr.FV_PName = p.PName;
                    sr.FV_PID = p.PID;
                    sr.FV_State = t.SRState;
                    projectR.Add(sr);
                }
                else
                {
                    //子工程
                    FV_SR sr = new FV_SR();
                    sr.FV_Date = t.SRDate;
                    sr.FV_Memo = t.SRMemo;
                    sr.FV_People = t.SRModifier;
                    TabSubProjectInfo p = service_PM.Query_SubProjectInfo_ByID(t.SRProjectID);
                    sr.FV_PNO = p.SPNO;
                    sr.FV_PName = p.SPName;
                    sr.FV_PID = p.SPProjectID;
                    sr.FV_State = t.SRState;

                    subR.Add(sr);
                }
            }

            DataTable dt_Project = ConvertListAndDataTable.ToDataTable(projectR);
            DataTable dt_Sub = ConvertListAndDataTable.ToDataTable(subR);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt_Project);
            ds.Tables.Add(dt_Sub);
            dt_Project.TableName = "Project";
            dt_Sub.TableName = "Sub";
            //主键
            DataColumn keyColumn = ds.Tables["Project"].Columns["FV_PID"];
            //外键
            DataColumn foreignColumn = ds.Tables["Sub"].Columns["FV_PID"];

            if (keyColumn != null && foreignColumn != null)
            {
                ds.Relations.Add("子项目", keyColumn, foreignColumn);
                gridControl1.DataSource = ds.Tables["Project"];
            }
            else if (keyColumn != null && foreignColumn == null)
            {
                gridControl1.DataSource = ds.Tables["Project"];
            }
            else if (keyColumn == null && foreignColumn != null)
            {
                gridControl1.DataSource = ds.Tables["Sub"];
            }
            else
            {
            }

            //gridControl1.DataSource = ds.Tables["Project"];
            DataAlias.setTableCaption("TabStateRecord", gridView1);

                        

            //不能修改单元格，选择一行
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;

            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 视图类
        /// </summary>
        public class FV_SR
        {
            public FV_SR()
            {
            }

            public string FV_PNO { get; set; }
            //子工程外键，主工程表中主键
            public int FV_PID { get; set; }
            public string FV_PName { get; set; }
            public string FV_People { get; set; }
            public string FV_State { get; set; }
            public DateTime FV_Date { get; set; }
            public string FV_Memo { get; set; }
        }

        /// <summary>
        /// 汉化子表表头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView view = gridView1.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            DataAlias.setTableCaption("TabStateRecord", view);
        }
    }
}
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
using DevExpress.XtraEditors.Controls;

namespace MISClient.UI.NewProject
{
    public partial class UI_ImageManage : DevExpress.XtraEditors.XtraForm
    {
        MISClient.Service_ProjectManagement.TabProjectInfo projectInfo = null;
        int gb_PID = -1;
        public UI_ImageManage(MISClient.Service_ProjectManagement.TabProjectInfo projectInfo)
        {
            InitializeComponent();
            InitGrid();
            InitLookupEdit();
            InitOther(projectInfo);
            this.projectInfo = projectInfo;
        }

        private void InitLookupEdit()
        {
            lookUpEdit1.Properties.DataSource = service_NP.select_ProjectInfo();
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PNO"));
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PName"));
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PID"));

            lookUpEdit1.Properties.Columns["PNO"].Caption = "工程编号";
            lookUpEdit1.Properties.Columns["PName"].Caption = "工程名称";
            lookUpEdit1.Properties.Columns["PID"].Visible = false;

            lookUpEdit1.Properties.DisplayMember = "PName";
            lookUpEdit1.Properties.ValueMember = "PID";

            //使lookUpEdit1默认不显示字
            lookUpEdit1.EditValue = "";
            lookUpEdit1.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        private void InitOther(MISClient.Service_ProjectManagement.TabProjectInfo projectInfo)
        {
            this.lookUpEdit1.EditValue = projectInfo.PID;
            layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            layoutView1.Columns["TIProjectID"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[TIProjectID] =" + lookUpEdit1.EditValue.ToString());
            gb_PID = projectInfo.PID;
        }

        MISClient.Service_NewProject.Service_NewProject service_NP = new Service_NewProject.Service_NewProject();
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        MISClient.Service_ProjectManagement.TabImage[] tabImages = null;

        /// <summary>
        /// 初始化Grid
        /// </summary>
        private void InitGrid()
        {
            tabImages = service_PM.Select_Image();
            gridControl1.DataSource = tabImages;

        }

        /// <summary>
        /// 添加按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UI_NewImage ui_Image = new UI_NewImage(gb_PID);
            if (ui_Image.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitGrid();
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            object focusOb = this.layoutView1.GetFocusedRow();
            if (focusOb != null)
            {
                int? id = (focusOb as MISClient.Service_ProjectManagement.TabImage).TIID;
                // TODO:删除方法        
            }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lookUpEdit1.EditValue.ToString()))
            {
                gb_PID = int.Parse(lookUpEdit1.EditValue.ToString());
                layoutView1.Columns["TIProjectID"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[TIProjectID] =" + lookUpEdit1.EditValue.ToString());
            }
        }

        /// <summary>
        /// 下载方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lookUpEdit1.EditValue.ToString()))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        int PID = int.Parse(lookUpEdit1.EditValue.ToString());
                        string path = fbd.SelectedPath;
                        string PNO = service_PM.Select_ProjectInfoByID(PID).PNO;

                        MISClient.Service_ProjectManagement.TabImage[] images = service_PM.Select_Image_ByPID(PID);
                        foreach (MISClient.Service_ProjectManagement.TabImage ti in images)
                        {
                            //string realpath = String.Format("{0}\\{1}合同图片\\{2}.jpg", path, PNO, ti.TINO);
                            string realDictionary = String.Format("{0}\\{1}合同图片", path, PNO);
                            System.IO.Directory.CreateDirectory(realDictionary);
                            System.IO.File.WriteAllBytes(String.Format("{0}\\{1}.jpg",realDictionary,ti.TINO), ti.TIImage);
                        }
                        MessageBox.Show("下载成功！", "提示");
                    }
                    catch
                    {
                        MessageBox.Show("下载失败！", "提示");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一个项目!", "提示");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
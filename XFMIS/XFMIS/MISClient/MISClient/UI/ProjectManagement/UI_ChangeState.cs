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
using DevExpress.XtraEditors.Controls;
namespace MISClient.UI.ProjectManagement
{
    public partial class UI_ChangeState : DevExpress.XtraEditors.XtraForm
    {
        public UI_ChangeState()
        {
            InitializeComponent();
            InitFrame();
            InitData();
        }

        MISClient.Service_ProjectManagement.Service_ProjectManagement service_PM = new Service_ProjectManagement.Service_ProjectManagement();
        MISClient.Service_ProjectManagement.TabStateRecord stateRecord = new Service_ProjectManagement.TabStateRecord();
        MISClient.Service_ProjectManagement.TabProjectState[] state = null;
        private void InitData()
        {
            MISClient.Service_NewProject.Service_NewProject service_NP = new Service_NewProject.Service_NewProject();
            if (int.Parse(this.radioGroup1.EditValue.ToString()) == 0)
            {
                lookUpEdit1.Properties.Columns.Clear();
                //子工程
                MISClient.Service_NewProject.TabSubProjectInfo[] subInfo = service_NP.select_SubProjectInfo();
                lookUpEdit1.Properties.DataSource = subInfo;
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("SPNO"));
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("SPName"));
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("SPID"));

                lookUpEdit1.Properties.Columns["SPNO"].Caption = "工程编号";
                lookUpEdit1.Properties.Columns["SPName"].Caption = "工程名称";
                lookUpEdit1.Properties.Columns["SPID"].Visible = false;

                lookUpEdit1.Properties.DisplayMember = "SPName";
                lookUpEdit1.Properties.ValueMember = "SPID";

            }
            else if (int.Parse(this.radioGroup1.EditValue.ToString()) == 1)
            {
                //主工程
                lookUpEdit1.Properties.Columns.Clear();
                MISClient.Service_NewProject.TabProjectInfo[] projectInfo = service_NP.select_ProjectInfo();
                lookUpEdit1.Properties.DataSource = projectInfo;
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PNO"));
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PName"));
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PID"));

                lookUpEdit1.Properties.Columns["PNO"].Caption = "工程编号";
                lookUpEdit1.Properties.Columns["PName"].Caption = "工程名称";
                lookUpEdit1.Properties.Columns["PID"].Visible = false;

                lookUpEdit1.Properties.DisplayMember = "PName";
                lookUpEdit1.Properties.ValueMember = "PID";
            }
        }

        private void InitFrame()
        {
            this.lookUpEdit1.Text = "";
            this.radioGroup1.SelectedIndex = 0;
            this.dateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit1.DateTime = DateTime.Now;
            GlobeVariable gb = GlobeVariable.getInstance();
            this.textEdit1.Text = gb.username;
            state = service_PM.Select_ProjectState();
            foreach (MISClient.Service_ProjectManagement.TabProjectState a in state)
            {
                comboBoxEdit1.Properties.Items.Add(a.PSValue);
            }
            this.AcceptButton = simpleButton1;
            this.CancelButton = simpleButton2;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.stateRecord.SRDate = dateEdit1.DateTime;
                this.stateRecord.SRFlag = radioGroup1.SelectedIndex;
                this.stateRecord.SRMemo = memoEdit1.Text;
                this.stateRecord.SRModifier = textEdit1.Text;
                this.stateRecord.SRProjectID = int.Parse(lookUpEdit1.EditValue.ToString());
                this.stateRecord.SRState = comboBoxEdit1.Text;
            }
            catch
            {
                MessageBox.Show("请输入合法数据！", "提示");
            }
            state = service_PM.Select_ProjectState();

            if (service_PM.Create_StateRecord(stateRecord) > 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("保存失败！", "提示");
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitData();
        }

    }
}
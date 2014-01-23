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
    public partial class UI_AMSubContractor : DevExpress.XtraEditors.XtraForm
    {
        //usefor 变量用于分别是进行新建还是修改操作
        string usefor = null;
        //如果是修改操作，储存传入ID的变量
        int modifyID = -1;
        //定义web服务变量
        MISClient.Service_ProjectManagement.Service_ProjectManagement service = null;

        /// <summary>
        /// 新建分包单位的构造方法
        /// </summary>
        public UI_AMSubContractor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            usefor = "new";
        }
        /// <summary>
        /// 修改分包单位的构造方法
        /// </summary>
        /// <param name="subContractor"></param>
        public UI_AMSubContractor(MISClient.Service_ProjectManagement.TabSubContractor subContractor)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            usefor = "modify";
            modifyID = subContractor.SCID;
            text_Name.Text = subContractor.SCName;
            text_Bank.Text = subContractor.SCBank;
            text_Account.Text = subContractor.SCBankAccount;
            text_Contactor.Text = subContractor.SCContactor;
            text_Tel.Text = subContractor.SCTel;
        }
        /// <summary>
        /// 取消按钮按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }
        /// <summary>
        /// 确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MISClient.Service_ProjectManagement.TabSubContractor subContractor = new Service_ProjectManagement.TabSubContractor();
            service = new Service_ProjectManagement.Service_ProjectManagement();
            subContractor.SCName = text_Name.Text.Trim();
            subContractor.SCBank = text_Bank.Text.Trim();
            subContractor.SCBankAccount = text_Account.Text.Trim();
            subContractor.SCContactor = text_Contactor.Text.Trim();
            subContractor.SCTel = text_Tel.Text.Trim();
            if (usefor.Equals("new"))
            {
                service.add_SubContractor(subContractor);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
            else if (usefor.Equals("modify"))
            {
                subContractor.SCID = modifyID;
                service.Update_SubContractor(subContractor);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
        }
    }
}
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

namespace MISClient.UI.SystemManagement
{
    public partial class UI_AddUser : DevExpress.XtraEditors.XtraForm
    {
        Service_SystemManagement.Service_SystemManagement sm = new Service_SystemManagement.Service_SystemManagement();

        public UI_AddUser()
        {
            InitializeComponent();
        }

        private bool check()
        {
            if (string.IsNullOrWhiteSpace(txt_Account.Text))
            {
                MessageBox.Show("请输入合法用户账户名", "提示");
                return false;
            }
            if (sm.Find_UserAccount(txt_Account.Text) > 0)
            {
                MessageBox.Show("用户账户名已存在", "提示");
                return false;
            }
            return true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!check())
                return;

            Service_SystemManagement.TabUsers user = new Service_SystemManagement.TabUsers();
            user.UAccount = txt_Account.Text;
            user.UDepart = txt_Depart.Text;
            user.UName = txt_Name.Text;
            user.UPassword = txt_Password.Text;

            sm.Create_User(user);

            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
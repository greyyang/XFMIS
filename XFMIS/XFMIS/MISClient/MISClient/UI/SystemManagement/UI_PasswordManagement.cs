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

namespace MISClient.UI.SystemManagement
{
    public partial class UI_PasswordManagement : DevExpress.XtraEditors.XtraForm
    {
        Service_SystemManagement.Service_SystemManagement sm = new Service_SystemManagement.Service_SystemManagement();


        public UI_PasswordManagement()
        {
            InitializeComponent();
        }

        private void UI_PasswordManagement_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string username = GlobeVariable.getInstance().userno;
            string oldPassword = txt_OldPassword.Text;
            if (sm.checkPassword(username, oldPassword) > 0)//老密码比对
            {
                if (txt_NewPassword.Text.Equals(txt_ConfirmPassword.Text))//两次新密码比对
                {
                    MISClient.Service_SystemManagement.TabUsers user = sm.Select_User_ByAcount(username)[0];
                    user.UPassword = txt_NewPassword.Text;
                    sm.Update_User(user);//更新密码
                    MessageBox.Show("密码修改成功!", "提示");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("两次新密码不匹配!", "提示");
                }
            }
            else
            {
                MessageBox.Show("旧密码错误!", "提示");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
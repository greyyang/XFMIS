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

namespace MISClient.UI.Login
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        MISClient.Service_SystemManagement.Service_SystemManagement service_SM = new Service_SystemManagement.Service_SystemManagement();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            check(this.text_username.Text, this.text_sn.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void check(string username, string password)
        {
            if (service_SM.checkPassword(username, password) > 0)
            {
                GlobeVariable f = GlobeVariable.getInstance();
                MISClient.Service_SystemManagement.TabUsers user = service_SM.Select_User_ByAcount(username)[0];
                f.userid = user.UID;
                f.userno = user.UAccount;
                f.username = user.UName;
                f.privilege = user.UPrivilege;
                f.depart = user.UDepart;
                this.Hide();
                MainFrame m = new MainFrame();
                //之后的几行是为了让主窗体被关闭之后, 程序可以完全退出,否则程序会一直有一个后台线程在运行
                m.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "提示");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            s.ShowDialog();
        }
    }
}
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
    public partial class UI_ModifyUser : DevExpress.XtraEditors.XtraForm
    {
        Service_SystemManagement.Service_SystemManagement sm = new Service_SystemManagement.Service_SystemManagement();
        Service_SystemManagement.TabUsers user = null;

        public UI_ModifyUser(int userID)
        {
            InitializeComponent();
            this.user = sm.Select_User(userID);
            init();
        }

        private void init()
        {
            txt_Account.Text = user.UAccount;
            txt_Depart.Text = user.UDepart;
            txt_Name.Text = user.UName;
            txt_Password.Text = user.UPassword;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            user.UDepart = txt_Depart.Text;
            user.UName = txt_Name.Text;
            user.UPassword = txt_Password.Text;

            sm.Update_User(user);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
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
    public partial class UI_UserManagement : DevExpress.XtraEditors.XtraForm
    {
        Service_SystemManagement.Service_SystemManagement sm = new Service_SystemManagement.Service_SystemManagement();


        public UI_UserManagement()
        {
            InitializeComponent();
            //显示行号
            Kit.CommonInit.InitGrid(gridView1);
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            UI_AddUser au = new UI_AddUser();
            if (au.ShowDialog() == DialogResult.OK)
                showAllUser();
        }

        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
                return;
            int currentRow = gridView1.GetSelectedRows()[0];

            if (currentRow >= 0)
            {

                int userID = int.Parse(gridView1.GetRowCellValue(currentRow, "UID").ToString());
                UI_ModifyUser mu = new UI_ModifyUser(userID);
                if (mu.ShowDialog() == DialogResult.OK)
                    showAllUser();

            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }


        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length <= 0)
                return;
            int currentRow = gridView1.GetSelectedRows()[0];

            if (currentRow >= 0)
            {
                if (gridView1.GetRowCellValue(currentRow, "UAccount").ToString().Equals("administrator"))
                {
                    MessageBox.Show("超级管理员不可被删除！", "提示");
                    return;
                }

                if (MessageBox.Show("是否确定删除此用户！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Service_SystemManagement.TabUsers user = new Service_SystemManagement.TabUsers();

                    int userID = int.Parse(gridView1.GetRowCellValue(currentRow, "UID").ToString());
                    user.UID = userID;
                    sm.Delete_User(user);
                    showAllUser();
                }
            }
            else
            {
                MessageBox.Show("请选择确定的一行！", "提示");
                return;
            }
        }

        private void UI_UserManagement_Load(object sender, EventArgs e)
        {
            showAllUser();
        }

        private void showAllUser()
        {

            Service_SystemManagement.TabUsers[] allUser = sm.Select_UserAll();
            gridControl1.DataSource = allUser;
            gridView1.OptionsBehavior.Editable = false;
            //在选择一行时焦点单元格颜色一致
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;


            //锁定表头,禁止拖动
            gridView1.OptionsCustomization.AllowColumnMoving = false;
            //手动设置group panel是否可见
            gridView1.OptionsView.ShowGroupPanel = false;

            gridView1.Columns["UID"].Visible = false;

            //表头汉化
            Kit.DataAlias.setTableCaption("TabU", gridView1);
        }
    }
}
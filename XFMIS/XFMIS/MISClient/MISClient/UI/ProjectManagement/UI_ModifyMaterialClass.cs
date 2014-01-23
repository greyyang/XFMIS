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
    public partial class UI_ModifyMaterialClass : DevExpress.XtraEditors.XtraForm
    {
        MISClient.Service_ProjectManagement.Service_ProjectManagement service_ProjectManagement = new Service_ProjectManagement.Service_ProjectManagement();

        private Service_ProjectManagement.TabMaterial material = new Service_ProjectManagement.TabMaterial();

        public UI_ModifyMaterialClass(Service_ProjectManagement.TabMaterial material)
        {
            this.material = material;
            InitializeComponent();
        }

        private bool checkInput()
        {
            return true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;

            material.MClass = txt_M_Class.Text;
            material.MCode = txt_M_Code.Text;
            material.MMemo = txt_M_Memo.Text;
            material.MName = txt_M_Name.Text;
            material.MType = txt_M_Type.Text;
            material.MUnit = txt_M_Unit.Text;

            service_ProjectManagement.Update_MaterialClass(material);

            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ModifyMaterialClass_Load(object sender, EventArgs e)
        {
            txt_M_Class.Text = material.MClass;
            txt_M_Code.Text = material.MCode;
            txt_M_Memo.Text = material.MMemo;
            txt_M_Name.Text = material.MName;
            txt_M_Type.Text = material.MType;
            txt_M_Unit.Text = material.MUnit;
        }
    }
}
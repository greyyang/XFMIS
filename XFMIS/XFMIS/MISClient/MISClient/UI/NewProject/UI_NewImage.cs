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
using System.IO;

namespace MISClient.UI.NewProject
{
    public partial class UI_NewImage : DevExpress.XtraEditors.XtraForm
    {
        public UI_NewImage(int PID)
        {
            InitializeComponent();
            InitFrame(PID);
        }

        MISClient.Service_NewProject.Service_NewProject service_NP = new Service_NewProject.Service_NewProject();
        MISClient.Service_NewProject.TabProjectInfo[] tabProjectInfos = null;
        MISClient.Service_NewProject.TabImage tabImage = null;

        private void InitFrame(int PID)
        {
            tabProjectInfos = service_NP.select_ProjectInfo();
            lookUpEdit1.Properties.DataSource = tabProjectInfos;
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PNO"));
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PName"));
            lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("PID"));

            lookUpEdit1.Properties.Columns["PNO"].Caption = "工程编号";
            lookUpEdit1.Properties.Columns["PName"].Caption = "工程名称";
            lookUpEdit1.Properties.Columns["PID"].Visible = false;

            lookUpEdit1.Properties.DisplayMember = "PName";
            lookUpEdit1.Properties.ValueMember = "PID";
            tabImage = new Service_NewProject.TabImage();

            //使lookUpEdit1默认不显示字
            lookUpEdit1.Properties.NullText = "";

            lookUpEdit1.EditValue = PID;
            lookUpEdit1.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            //使pictureEdit1默认不显示字
            pictureEdit1.Properties.NullText = "预览";

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    labelControl4.Text = openFileDialog1.FileName;
                    string imagePath = openFileDialog1.FileName;
                    Image image = Image.FromFile(imagePath);
                    pictureEdit1.Image = image;

                    //把图片变为byte流
                    System.IO.MemoryStream Ms = new MemoryStream();
                    image.Save(Ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] img = new byte[Ms.Length];
                    Ms.Position = 0;
                    Ms.Read(img, 0, Convert.ToInt32(Ms.Length));
                    Ms.Close();

                    tabImage.TIImage = img;
                }
            }
            catch
            {
                MessageBox.Show("显示图片错误。", "提示");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tabImage.TIProjectID = int.Parse(lookUpEdit1.EditValue.ToString());
            //合同图片暂时不关联子项目
            tabImage.TISubProjectID = -1;
            tabImage.TINO = int.Parse(textEdit1.Text);
            //提交服务器存入数据库
            service_NP.add_Image(tabImage);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
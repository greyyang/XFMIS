using System;
using System.Windows.Forms;

namespace CodeGeneratorWin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            newIBatisNet_Click(this, new EventArgs());
        }

        private void menuIBatis_Click(object sender, EventArgs e)
        {
            frmIBatisGeneratorMain frmIbatis = new frmIBatisGeneratorMain();
            frmIbatis.MdiParent = this;
            frmIbatis.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.MdiParent = this;
            about.Show();
        }

        private void newIBatisNet_Click(object sender, EventArgs e)
        {
            menuIBatis_Click(this, new EventArgs());
        }
    }
}
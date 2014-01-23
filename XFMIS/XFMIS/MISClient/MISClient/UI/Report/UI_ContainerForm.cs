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
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraPrinting;

namespace MISClient.UI.Report
{
    public partial class UI_ContainerForm : DevExpress.XtraEditors.XtraForm
    {

        public int projectID;
        public bool mainOrSubProject;
        public UI_ContainerForm(string kind, int projectID, bool mainOrSubProject)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.mainOrSubProject = mainOrSubProject;

            if (kind.Equals("财务报表"))
                initFinanceReport();
            else if (kind.Equals("工程报表"))
                initProjectReport();
            else if (kind.Equals("总报表"))
                initTotalReport();
        }

        private void initProjectReport()
        {
            this.Text = "工程报表";
            UI.Report.UI_ProjectDataReport pdr = new UI.Report.UI_ProjectDataReport(projectID, mainOrSubProject);

            PrintControl printControl = new PrintControl();
            printControl.PrintingSystem = pdr.PrintingSystem;

            PrintBarManager printBarManager = new PrintBarManager();
            printBarManager.Form = printControl;
            printBarManager.Initialize(printControl);
            printBarManager.MainMenu.Visible = false;
            printBarManager.AllowCustomization = false;

            //操作要显示什么按钮
            printControl.PrintingSystem.SetCommandVisibility(new PrintingSystemCommand[]{
                PrintingSystemCommand.Open,
                PrintingSystemCommand.Save,
                PrintingSystemCommand.ClosePreview,
                PrintingSystemCommand.Customize,
                PrintingSystemCommand.SendCsv,
                PrintingSystemCommand.SendFile,
                PrintingSystemCommand.SendGraphic,
                PrintingSystemCommand.SendMht,
                PrintingSystemCommand.SendPdf,
                PrintingSystemCommand.SendRtf,
                PrintingSystemCommand.SendTxt,
                PrintingSystemCommand.SendXls
            }, DevExpress.XtraPrinting.CommandVisibility.None);

            pdr.CreateDocument();

            Controls.Add(printControl);
            printControl.Dock = DockStyle.Fill;
        }

        private void initFinanceReport()
        {
            this.Text = "财务报表";
            UI.Report.UI_ProjectFinanceReport pfr = new UI.Report.UI_ProjectFinanceReport(projectID, mainOrSubProject);

            PrintControl printControl = new PrintControl();
            printControl.PrintingSystem = pfr.PrintingSystem;

            PrintBarManager printBarManager = new PrintBarManager();
            printBarManager.Form = printControl;
            printBarManager.Initialize(printControl);
            printBarManager.MainMenu.Visible = false;
            printBarManager.AllowCustomization = false;

            //操作要显示什么按钮
            printControl.PrintingSystem.SetCommandVisibility(new PrintingSystemCommand[]{
                PrintingSystemCommand.Open,
                PrintingSystemCommand.Save,
                PrintingSystemCommand.ClosePreview,
                PrintingSystemCommand.Customize,
                PrintingSystemCommand.SendCsv,
                PrintingSystemCommand.SendFile,
                PrintingSystemCommand.SendGraphic,
                PrintingSystemCommand.SendMht,
                PrintingSystemCommand.SendPdf,
                PrintingSystemCommand.SendRtf,
                PrintingSystemCommand.SendTxt,
                PrintingSystemCommand.SendXls
            }, DevExpress.XtraPrinting.CommandVisibility.None);

            pfr.CreateDocument();

            Controls.Add(printControl);
            printControl.Dock = DockStyle.Fill;

        }

        private void initTotalReport()
        {
            this.Text = "总报表";
            UI.Report.UI_TotalItemReport tir = new UI.Report.UI_TotalItemReport(projectID, mainOrSubProject);

            PrintControl printControl = new PrintControl();
            printControl.PrintingSystem = tir.PrintingSystem;

            PrintBarManager printBarManager = new PrintBarManager();
            printBarManager.Form = printControl;
            printBarManager.Initialize(printControl);
            printBarManager.MainMenu.Visible = false;
            printBarManager.AllowCustomization = false;

            //操作要显示什么按钮
            printControl.PrintingSystem.SetCommandVisibility(new PrintingSystemCommand[]{
                PrintingSystemCommand.Open,
                PrintingSystemCommand.Save,
                PrintingSystemCommand.ClosePreview,
                PrintingSystemCommand.Customize,
                PrintingSystemCommand.SendCsv,
                PrintingSystemCommand.SendFile,
                PrintingSystemCommand.SendGraphic,
                PrintingSystemCommand.SendMht,
                PrintingSystemCommand.SendPdf,
                PrintingSystemCommand.SendRtf,
                PrintingSystemCommand.SendTxt,
                PrintingSystemCommand.SendXls
            }, DevExpress.XtraPrinting.CommandVisibility.None);

            tir.CreateDocument();

            Controls.Add(printControl);
            printControl.Dock = DockStyle.Fill;

        }
    }
}
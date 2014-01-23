using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using MISClient.Sinicization;
using DevExpress.XtraEditors.Controls;
using MISClient.UI.Login;
namespace MISClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            //汉化GridControl控件
            //DevExpress.XtraGrid.Localization.GridLocalizer.Active = new DevLocalizer();
            //汉化日期控件
            Localizer.Active = new ChEditLocalizer();
            Application.Run(new Login());
        }
    }
}
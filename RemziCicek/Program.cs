using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Globalization;
using System.Threading;

namespace RemziCicek
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "McSkin";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowDefaultSvgImages = DevExpress.Utils.DefaultBoolean.False;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("TR-tr");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new frmLogin());
        }
    }
}

using QuanLySinhVien.Models;
using QuanLySinhVien.Views.DashbroadViews;
using QuanLySinhVien.Views.LoginView;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            InitWhenFristTime initWhenFristTime = new InitWhenFristTime();
            initWhenFristTime.InsertUserDemoData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.Authen)
            {
                Application.Run(new layout_MainScreen());
            }

            if (!Properties.Settings.Default.Authen)
            {
            login_frm:
                Application.Run(new layout_Login());
                if (Properties.Settings.Default.Authen)
                {
                    Application.Run(new layout_MainScreen());
                    if (!Properties.Settings.Default.Authen) goto login_frm;
                }
            }
        }
    }
}
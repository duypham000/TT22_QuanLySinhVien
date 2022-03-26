using QuanLySinhVien.Models;
using QuanLySinhVien.Views;
using QuanLySinhVien.Views.LoginView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitWhenFristTime initWhenFristTime = new InitWhenFristTime();
            initWhenFristTime.InsertUserDemoData();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new layout_Login());
        }
    }
}

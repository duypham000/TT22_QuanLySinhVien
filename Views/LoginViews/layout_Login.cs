using QuanLySinhVien.Views.LoginViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.LoginView
{
    public partial class layout_Login : Form
    {
        public layout_Login()
        {
            InitializeComponent();
            this.BringToFront();
            show_LoginForm();
        }

        public void show_LoginForm()
        {
            pnl_Login pnl_Login = new pnl_Login(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost=true, FormBorderStyle = FormBorderStyle.None};
            this.pnl_body.Controls.Clear();
            this.pnl_body.Controls.Add(pnl_Login);
            pnl_Login.Show();
        }

        public void show_ForgotForm()
        {
            pnl_ForgotPassword pnl_ForgotPassword = new pnl_ForgotPassword(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None};
            this.pnl_body.Controls.Clear();
            this.pnl_body.Controls.Add(pnl_ForgotPassword);

            pnl_ForgotPassword.Show();
        }
    }
}

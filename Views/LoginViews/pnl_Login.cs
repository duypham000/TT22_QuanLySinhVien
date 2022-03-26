using QuanLySinhVien.Controllers;
using QuanLySinhVien.Views.LoginView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.LoginViews
{
    public partial class pnl_Login : Form
    {
        layout_Login layout_Login = null;
        public pnl_Login(layout_Login layout)
        {
            InitializeComponent();
            layout_Login = layout;
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            this.inpt_username.Text = Properties.Settings.Default.Username;
            this.inpt_password.Text = Properties.Settings.Default.Password;

            if (Properties.Settings.Default.Password != "")
            {
                this.cbx_autoLogin.Checked = true;
            }
        }

        private void showPassword(object sender, EventArgs e)
        {
            if (this.cbx_showPass.Checked)
            {
                this.inpt_password.PasswordChar = '\0';
            }
            else
            {
                this.inpt_password.PasswordChar = '*';
            }
        }

        private void login(object sender, EventArgs e)
        {
            string username = this.inpt_username.Text;
            string password = this.inpt_password.Text;

            if (LoginController.authenticateAccount(username, password))
            {
                Properties.Settings.Default.Username = username;
                savePassword();
                Properties.Settings.Default.Save();
                MessageBox.Show("Hello admin");
            }
            else
            {
                Properties.Settings.Default.Password = "";
                MessageBox.Show("Dăng nhập thất bại, kiểm tra username và password!");
            }
        }

        private void savePassword()
        {
            if (this.cbx_autoLogin.Checked)
            {
                string password = this.inpt_password.Text;
                Properties.Settings.Default.Password = password;
            }
            else
            {
                Properties.Settings.Default.Password = "";
            }
        }

        private void loginError(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/duyn5822/");

            MessageBox.Show("Hãy liên hệ qua facebook của admin để được hỗ trợ trực tiếp!");
        }

        private void forgotPass(object sender, EventArgs e)
        {
            this.layout_Login.show_ForgotForm();
        }
    }
}

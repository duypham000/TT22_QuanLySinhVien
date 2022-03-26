using QuanLySinhVien.Controllers;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien.Views
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
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
                MessageBox.Show("Login failed!");
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
            frm_ForgotPassword frm = new frm_ForgotPassword(this);
            frm.Show();
            this.Hide();
        }
    }
}
using System;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews
{
    public partial class layout_MainScreen : Form
    {
        public layout_MainScreen()
        {
            InitializeComponent();
            this.user_username.Text = Properties.Settings.Default.Username;
            customizeDesing();


        }

        private void exitAuthen(object sender, EventArgs e)
        {
            Properties.Settings.Default.Authen = false;
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void customizeDesing()
        {
            this.submenu_qlsv.Visible = false;
            this.submenu_qltk.Visible = false;
        }

        private void hideSubmenu()
        {
            if (this.submenu_qlsv.Visible == true)
                this.submenu_qlsv.Visible = false;
            if (this.submenu_qltk.Visible == true)
                this.submenu_qltk.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void opt_qltk_Click(object sender, EventArgs e)
        {
            this.frm_title.Text = "Quản lý tài khoản";
            showSubmenu(this.submenu_qltk);
        }

        private void opt_qlsv_Click(object sender, EventArgs e)
        {
            this.frm_title.Text = "Quản lý sinh viên";
            showSubmenu(this.submenu_qlsv);
        }
    }
}
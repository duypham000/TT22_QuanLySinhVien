using System;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews
{
    public partial class layout_MainScreen : Form
    {
        public layout_MainScreen()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            this.submenu_qlk.Visible = false;
            this.submenu_qll.Visible = false;
            this.submenu_qlsv.Visible = false;
            this.submenu_qltk.Visible = false;
        }

        private void hideSubmenu()
        {
            if (this.submenu_qlk.Visible == true)
                this.submenu_qlk.Visible = false;
            if (this.submenu_qll.Visible == true)
                this.submenu_qll.Visible = false;
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
            showSubmenu(this.submenu_qltk);
        }

        private void otp_qlk_Click(object sender, EventArgs e)
        {
            showSubmenu(this.submenu_qlk);
        }

        private void opt_qll_Click(object sender, EventArgs e)
        {
            showSubmenu(this.submenu_qll);
        }

        private void opt_qlsv_Click(object sender, EventArgs e)
        {
            showSubmenu(this.submenu_qlsv);
        }
    }
}
using QuanLySinhVien.Views.DashbroadViews.UserViews;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews
{
    public partial class layout_MainScreen : Form
    {
        Form childForm = null;
        public layout_MainScreen()
        {
            InitializeComponent();
            this.user_username.Text = Properties.Settings.Default.Username;
            customizeDesing();
            UserListView userListView = new UserListView();

            openChildForm(userListView);
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
            //this.frm_title.Text = "Quản lý tài khoản";
            showSubmenu(this.submenu_qltk);
        }

        private void opt_qlsv_Click(object sender, EventArgs e)
        {
            //this.frm_title.Text = "Quản lý sinh viên";
            showSubmenu(this.submenu_qlsv);
        }

        private Form activeForm = null;

        public void openChildForm(Form form)
        {
            if (activeForm != null)
            {
                this.frm_body.Controls.Clear();
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.frm_body.Controls.Add(form);
            this.frm_body.Tag = form;
            this.childForm = form;
            form.FormClosing += new FormClosingEventHandler(this.navigate);
            form.BringToFront();
            form.Show();
        }

        protected void navigate(object sender, FormClosingEventArgs e)
        {
            string navTo = childForm.Tag.ToString();
            string[] nav =  navTo.Split('/');
            if (nav[0].Equals("add-user"))
            {
                UserAdd userAdd = new UserAdd();
                openChildForm(userAdd);
            }
            else if (nav[0].Equals("update-user"))
            {
                UserUpdate userUpdate = new UserUpdate(nav[1]);
                openChildForm(userUpdate);
            }
            else if (nav[0].Equals("list-user"))
            {
                UserListView userListView = new UserListView();
                openChildForm(userListView);
            }
        }

        private void link_home_Click(object sender, EventArgs e)
        {

        }
    }
}
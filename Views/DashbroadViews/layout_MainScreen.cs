using QuanLySinhVien.Views.DashbroadViews.StudentViews;
using QuanLySinhVien.Views.DashbroadViews.UserViews;
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

            showHome();
        }

        private void exitAuthen(object sender, EventArgs e)
        {
            Properties.Settings.Default.Authen = false;
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void customizeDesing()
        {
            this.submenu_qltk.Visible = false;
        }

        private void hideSubmenu()
        {
            //if (this.submenu_qlsv.Visible == true)
            //    this.submenu_qlsv.Visible = false;
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
            //showSubmenu(this.submenu_qlsv);

            StudentListView studentListView = new StudentListView();
            openChildForm(studentListView);

        }

        private Form activeForm = null;

        public void openChildForm(Form form)
        {
            if (activeForm != null)
            {
                this.frm_body.Controls.Clear();
            }

            this.activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.frm_body.Controls.Add(form);
            this.frm_body.Tag = form;
            form.FormClosing += new FormClosingEventHandler(this.navigate);
            form.BringToFront();
            form.Show();
        }

        protected void navigate(object sender, FormClosingEventArgs e)
        {
            string navTo = this.activeForm.Tag.ToString();
            string[] nav = navTo.Split('/');
            if (nav[0].Equals("add-user"))
            {
                UserAdd userAdd = new UserAdd();
                changeNav("user-add");
                openChildForm(userAdd);
            }
            else if (nav[0].Equals("update-user"))
            {
                UserUpdate userUpdate = new UserUpdate(nav[1]);
                changeNav("user-update");
                openChildForm(userUpdate);
            }
            else if (nav[0].Equals("list-user"))
            {
                UserListView userListView = new UserListView();
                changeNav("user-list");
                openChildForm(userListView);
            }else if (nav[0].Equals("list-student"))
            {
                StudentListView studentListView = new StudentListView();
                openChildForm(studentListView);
            }
            else if (nav[0].Equals("update-student"))
            {
                StudentUpdateView studentUpdateView = new StudentUpdateView(nav[1]);
                openChildForm(studentUpdateView);
            }
            else if (nav[0].Equals("add-student"))
            {
                StudentAdd studentAdd = new StudentAdd();
                openChildForm(studentAdd);
            }
            else if (nav[0].Equals("list-student"))
            {
                StudentListView studentListView = new StudentListView();
                openChildForm(studentListView);
            }
        }

        private void showHome()
        {
            this.nav12.Hide();
            this.nav2.Hide();
            this.nav23.Hide();
            this.nav3.Hide();
        }

        private void link_home_Click(object sender, EventArgs e)
        {
        }

        private void userList_Show(object sender, EventArgs e)
        {
            UserListView user = new UserListView();
            openChildForm(user);
            changeNav("user-list");
        }

        private void changeNav(string nav)
        {
            if (nav.Equals("user-list"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Quản lý danh sách tài khoản";
                this.nav2_txt.Width = 202;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Danh sách tài khoản";
                this.nav3_txt.Width = 149;
            }
            else if(nav.Equals("user-add"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.Plus;
                this.nav2_txt.Text = "Thêm tài khoản";
                this.nav2_txt.Width = 115;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Danh sách tài khoản";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("user-update"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.Pen;
                this.nav2_txt.Text = "Cập nhật tài khoản";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Danh sách tài khoản";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("student-update"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.Pen;
                this.nav2_txt.Text = "Cập nhật sinh viên";
                this.nav2_txt.Width = 115;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Danh sách sinh viên";
                this.nav3_txt.Width = 149;
            }
        }

        private void layout_MainScreen_ClientSizeChanged(object sender, EventArgs e)
        {
        }
    }
}
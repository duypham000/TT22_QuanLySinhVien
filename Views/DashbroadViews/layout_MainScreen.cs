using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using QuanLySinhVien.Views.DashbroadViews.ClassViews;
using QuanLySinhVien.Views.DashbroadViews.FacultyViews;
using QuanLySinhVien.Views.DashbroadViews.RoleViews;
using QuanLySinhVien.Views.DashbroadViews.StudentViews;
using QuanLySinhVien.Views.DashbroadViews.TeacherViews;
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
            this.role_name.Text = Properties.Settings.Default.Role;
            showHome();
        }

        private void permissionCheck()
        {
            string[] permis = Properties.Settings.Default.Permission.Split('-');
            int acc = 0;
            foreach (string per in permis)
            {
                char[] p = per.ToCharArray();
                if (p[1].Equals('0'))
                {
                    if (p[0].Equals('C'))
                    {
                        this.opt_qll.Hide();
                    }
                    else
                    if (p[0].Equals('A'))
                    {
                        this.btn_userlist.Hide();
                    }
                    else
                    if (p[0].Equals('R'))
                    {
                        this.btn_rolelist.Hide();
                    }
                    else
                    if (p[0].Equals('F'))
                    {
                        this.otp_qlk.Hide();
                    }
                    else
                    if (p[0].Equals('S'))
                    {
                        this.opt_qlsv.Hide();
                    }
                    else
                    if (p[0].Equals('T'))
                    {
                        this.opt_qlgv.Hide();
                    }
                }
                else
                {
                    if (p[0].Equals('C'))
                    {
                        this.opt_qll.Show();
                    }
                    else
                    if (p[0].Equals('A'))
                    {
                        acc++;
                        this.btn_userlist.Show();
                    }
                    else
                    if (p[0].Equals('R'))
                    {
                        acc++;
                        this.btn_rolelist.Show();
                    }
                    else
                    if (p[0].Equals('F'))
                    {
                        this.otp_qlk.Show();
                    }
                    else
                    if (p[0].Equals('S'))
                    {
                        this.opt_qlsv.Show();
                    }
                    else
                    if (p[0].Equals('T'))
                    {
                        this.opt_qlgv.Show();
                    }
                }
            }
            if (acc == 0)
            {
                this.opt_qltk.Hide();
            }
            else
            {
                this.opt_qltk.Show();
            }
        }

        private void exitAuthen(object sender, EventArgs e)
        {
            Properties.Settings.Default.Authen = false;
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Permission = "";
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void customizeDesing()
        {
            this.submenu_qltk.Visible = false;
        }

        private void hideSubmenu()
        {
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

        private void opt_qlsv_Click(object sender, EventArgs e)
        {
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
            changeNav(nav[0]);
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
            else if (nav[0].Equals("list-student"))
            {
                StudentListView studentListView = new StudentListView();
                openChildForm(studentListView);
            }
            else if (nav[0].Equals("update-student"))
            {
                StudentUpdateView studentUpdateView = new StudentUpdateView(Int32.Parse(nav[1]));
                openChildForm(studentUpdateView);
            }
            else if (nav[0].Equals("add-student"))
            {
                StudentAdd studentAdd = new StudentAdd();
                openChildForm(studentAdd);
            }
            else if (nav[0].Equals("list-faculty"))
            {
                FacultyListView facultyListView = new FacultyListView();
                openChildForm(facultyListView);
            }
            else if (nav[0].Equals("add-faculty"))
            {
                FacultyAdd facultyAdd = new FacultyAdd();
                openChildForm(facultyAdd);
            }
            else if (nav[0].Equals("update-faculty"))
            {
                FacultyUpdate facultyUpdate = new FacultyUpdate(Int32.Parse(nav[1]));
                openChildForm(facultyUpdate);
            }
            else if (nav[0].Equals("list-class"))
            {
                ClassListView classListView = new ClassListView();
                openChildForm(classListView);
            }
            else if (nav[0].Equals("add-class"))
            {
                ClassAdd classAdd = new ClassAdd();
                openChildForm(classAdd);
            }
            else if (nav[0].Equals("update-class"))
            {
                ClassUpdate classUpdate = new ClassUpdate(Int32.Parse(nav[1]));
                openChildForm(classUpdate);
            }
            else if (nav[0].Equals("list-role"))
            {
                RoleListView roleListView = new RoleListView();
                openChildForm(roleListView);
            }
            else if (nav[0].Equals("add-role"))
            {
                RoleAdd roleAdd = new RoleAdd();
                openChildForm(roleAdd);
            }
            else if (nav[0].Equals("update-role"))
            {
                RoleUpdate roleUpdate = new RoleUpdate(Int32.Parse(nav[1]));
                openChildForm(roleUpdate);
            }
            else if (nav[0].Equals("list-teacher"))
            {
                TeacherListView teacherListView = new TeacherListView();
                openChildForm(teacherListView);
            }
            else if (nav[0].Equals("add-teacher"))
            {
                TeacherAdd teacherAdd = new TeacherAdd();
                openChildForm(teacherAdd);
            }
            else if (nav[0].Equals("update-teacher"))
            {
                TeacherUpdate teacherUpdate = new TeacherUpdate(Int32.Parse(nav[1]));
                openChildForm(teacherUpdate);
            }
        }

        private void showHome()
        {
            this.nav12.Hide();
            this.nav2.Hide();
            this.nav23.Hide();
            this.nav3.Hide();
        }

        private void userList_Show(object sender, EventArgs e)
        {
            UserListView user = new UserListView();
            openChildForm(user);
            changeNav("list-user");
        }

        private void changeNav(string nav)
        {
            if (nav.Equals("list-user"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Danh sách tài khoản";
                this.nav2_txt.Width = 202;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý tài khoản";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("add-user"))
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
            else if (nav.Equals("update-user"))
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
            else if (nav.Equals("update-student"))
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
            else if (nav.Equals("list-faculty"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Danh sách khoa";
                this.nav2_txt.Width = 120;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý khoa";
                this.nav3_txt.Width = 120;
            }
            else if (nav.Equals("add-faculty"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Thêm khoa";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý khoa";
                this.nav3_txt.Width = 120;
            }
            else if (nav.Equals("update-faculty"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Sửa khoa";
                this.nav2_txt.Width = 120;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý khoa";
                this.nav3_txt.Width = 120;
            }
            else if (nav.Equals("list-class"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Danh sách lớp";
                this.nav2_txt.Width = 120;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý lớp";
                this.nav3_txt.Width = 120;
            }
            else if (nav.Equals("add-class"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Thêm lớp";
                this.nav2_txt.Width = 120;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý lớp";
                this.nav3_txt.Width = 120;
            }
            else if (nav.Equals("update-class"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Sửa lớp";
                this.nav2_txt.Width = 120;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý lớp";
                this.nav3_txt.Width = 120;
            }
            else if (nav.Equals("list-role"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Danh sách vai trò";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý vai trò";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("add-role"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Thêm vai trò";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý vai trò";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("update-role"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Sửa vai trò";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý vai trò";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("list-teacher"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Danh sách giáo viên";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý giáo viên";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("add-teacher"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Thêm giáo viên";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý giáo viên";
                this.nav3_txt.Width = 149;
            }
            else if (nav.Equals("update-teacher"))
            {
                this.nav2.Show();
                this.nav12.Show();
                this.nav2_icon.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
                this.nav2_txt.Text = "Sửa giáo viên";
                this.nav2_txt.Width = 149;

                this.nav3.Show();
                this.nav23.Show();
                this.nav3_icon.IconChar = FontAwesome.Sharp.IconChar.List;
                this.nav3_txt.Text = "Quản lý giáo viên";
                this.nav3_txt.Width = 149;
            }
        }

        private void otp_qlk_Click(object sender, EventArgs e)
        {
            FacultyListView facultyListView = new FacultyListView();
            changeNav("list-faculty");
            openChildForm(facultyListView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeNav("list-teacher");
            TeacherListView teacherListView = new TeacherListView();
            openChildForm(teacherListView);
        }

        private void btn_rolelist_Click(object sender, EventArgs e)
        {
            RoleListView roleListView = new RoleListView();
            changeNav("list-role");
            openChildForm(roleListView);
        }

        private void opt_qll_Click(object sender, EventArgs e)
        {
            ClassListView classListView = new ClassListView();
            changeNav("list-class");
            openChildForm(classListView);
        }

        private void layout_MainScreen_Load(object sender, EventArgs e)
        {
            permissionCheck();
        }
    }
}
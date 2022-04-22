using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.TeacherViews
{
    public partial class TeacherAdd : Form
    {
        private TeacherServices teacherServices = null;
        private ClassServices classServices = null;
        private UserServices userServices = null;

        private List<Teacher> teachers = null;
        private List<Class> classes = null;
        private List<User> users = null;

        public TeacherAdd()
        {
            InitializeComponent();

            teacherServices = new TeacherServices();
            classServices = new ClassServices();
            userServices = new UserServices();

            users = userServices.GetAllUsers();
            classes = classServices.GetAll();
            addDropdown();
        }

        private void addDropdown()
        {
            foreach (var user in users)
            {
                this.inpt_usr.Items.Add(user.Username);
            }
            foreach (var @class in classes)
            {
                this.inpt_class.Items.Add(@class.Name);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (
                this.inpt_name.Texts != "" &&
                this.inpt_phone.Texts != "" &&
                this.inpt_status.Text != ""
            )
            {
                Teacher teacher = new Teacher();

                teacher.Name = this.inpt_name.Texts;

                if (this.inpt_usr.Text != "")
                {
                    foreach (var user in users)
                    {
                        if (user.Username.Equals(this.inpt_usr.Text))
                        {
                            teacher.UserID = user.ID;
                        }
                    }
                }

                if (this.inpt_class.Text != "")
                {
                    foreach (var @class in classes)
                    {
                        if (@class.Name.Equals(this.inpt_class.Text))
                        {
                            teacher.ClassID = @class.ID;
                        }
                    }
                }

                teacher.Status = this.inpt_status.Text;
                teacher.Phone = this.inpt_phone.Texts;
                teacher.CreatedBy = Properties.Settings.Default.Username;
                teacher.CreatedDate = DateTime.Now;

                teacherServices.Add(teacher);
                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng và đủ thông tin!");
            }
        }

        private void backToList()
        {
            this.Tag = "list-teacher";
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            backToList();
        }

        private void inpt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void inpt_phone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
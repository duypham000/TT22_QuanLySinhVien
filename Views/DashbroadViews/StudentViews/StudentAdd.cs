using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.StudentViews
{
    public partial class StudentAdd : Form
    {
        private StudentServices studentServices = null;
        private ClassServices classServices = null;
        private UserServices userServices = null;

        private List<User> users = null;
        private List<Class> classes = null;
        private string[] studentStatus = { "Đã thôi học", "Đang học", "Bảo lưu" };

        public StudentAdd()
        {
            InitializeComponent();

            studentServices = new StudentServices();
            classServices = new ClassServices();
            userServices = new UserServices();
            classes = classServices.GetAll();
            users = userServices.GetAllUsers();

            addDropdownName();
        }

        private void addDropdownName()
        {
            foreach (var classi in this.classes)
            {
                this.inpt_class.Items.Add(classi.ID);
            }

            foreach (var status in studentStatus)
            {
                this.inpt_status.Items.Add(status);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (var user in users)
            {
                if (user.Username.Equals(this.inpt_id.Texts))
                {
                    MessageBox.Show("Hãy nhập đúng và đủ thông tin!");
                    return;
                }
            }

            if (
                this.inpt_id.Texts != "" &&
                this.inpt_roles.Texts != "" &&
                this.inpt_name.Texts != "" &&
                this.inpt_phone.Texts != "" &&
                this.inpt_status.Text != "" &&
                this.inpt_dateb.Texts != "" &&
                this.inpt_class.Text != "" &&
                this.inpt_class.SelectedIndex != -1 &&
                this.inpt_his.Texts != "" &&
                this.inpt_address.Texts != "" &&
                this.inpt_re.Texts != ""
            )
            {
                Student student = new Student();

                student.ID = this.inpt_id.Texts;
                student.Name = this.inpt_name.Texts;
                student.ClassRole = this.inpt_roles.Texts;
                student.Phone = this.inpt_phone.Texts;
                student.Status = this.inpt_status.Text;
                student.DateOfBirth = this.inpt_dateb.Texts;
                student.ClassID = this.inpt_class.Text;
                student.SchoolProfile = this.inpt_his.Texts;
                student.Address = this.inpt_address.Texts;
                student.Religion = this.inpt_re.Texts;

                studentServices.Add(student);

                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng và đủ thông tin!");
            }
        }

        private void backToList()
        {
            this.Tag = "list-student";
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            backToList();
        }
    }
}
using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.ClassViews
{
    public partial class ClassAdd : Form
    {
        private FacultyServices facultyServices = null;
        private ClassServices classServices = null;
        private StudentServices studentServices = null;
        private TeacherServices teacherServices = null;

        private List<Faculty> faculties = null;
        private List<Student> students = null;
        private List<Teacher> teachers = null;

        public ClassAdd()
        {
            InitializeComponent();

            facultyServices = new FacultyServices();
            classServices = new ClassServices();
            studentServices = new StudentServices();
            teacherServices = new TeacherServices();

            faculties = facultyServices.GetAll();
            students = studentServices.GetAll();
            teachers = teacherServices.GetAll();

            fillDropDown();
        }

        private void fillDropDown()
        {
            foreach (var faculty in faculties)
            {
                this.inpt_faculty.Items.Add(faculty.Name);
            }

            foreach (var student in students)
            {
                this.inpt_monitor.Items.Add(student.Name);
            }

            foreach (var teacher in teachers)
            {
                this.inpt_leader.Items.Add(teacher.Name);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (
                this.inpt_name.Texts != "")
            {
                Class @class = new Class();

                @class.Name = this.inpt_name.Texts;
                if (this.inpt_faculty.Text != "")
                {
                    foreach (var faculty in faculties)
                    {
                        if (this.inpt_faculty.Text.Equals(faculty.Name))
                        {
                            @class.FacultyID = faculty.ID;
                        }
                    }
                }

                if (this.inpt_leader.Text != "")
                {
                    foreach (var teacher in teachers)
                    {
                        if (this.inpt_leader.Text.Equals(teacher.Name))
                        {
                            @class.LeaderID = teacher.ID;
                        }
                    }
                }

                @class.CreatedBy = Properties.Settings.Default.Username;
                @class.CreatedDate = DateTime.Now;

                classServices.Add(@class);
                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên lớp!");
            }
        }

        private void backToList()
        {
            this.Tag = "list-class";
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
    }
}
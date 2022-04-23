using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.ClassViews
{
    public partial class ClassUpdate : Form
    {
        private FacultyServices facultyServices = null;
        private ClassServices classServices = null;
        private StudentServices studentServices = null;
        private TeacherServices teacherServices = null;

        private List<Faculty> faculties = null;
        private List<Student> students = null;
        private List<Teacher> teachers = null;
        private List<Class> classes = null;

        private int id = -1;

        public ClassUpdate(int id)
        {
            InitializeComponent();
            facultyServices = new FacultyServices();
            classServices = new ClassServices();
            studentServices = new StudentServices();
            teacherServices = new TeacherServices();

            faculties = facultyServices.GetAll();
            students = studentServices.GetAll();
            teachers = teacherServices.GetAll();
            classes = classServices.GetAll();

            this.id = id;

            fillDropDown();
            getData();
        }

        private void getData()
        {
            foreach (var @class in classes)
            {
                if (@class.ID.Equals(id))
                {
                    this.inpt_name.Texts = @class.Name;
                    if (@class.FacultyID != null)
                    {
                        foreach (var faculty in faculties)
                        {
                            if (@class.FacultyID.Equals(faculty.ID))
                            {
                                this.inpt_faculty.Text = faculty.Name;
                            }
                        }
                    }

                    if (@class.MonitorID != null)
                    {
                        foreach (var student in students)
                        {
                            if (@class.MonitorID.Equals(student.ID))
                            {
                                this.inpt_monitor.Text = student.Name;
                            }
                        }
                    }

                    if (@class.LeaderID != null)
                    {
                        foreach (var teacher in teachers)
                        {
                            if (@class.LeaderID.Equals(teacher.ID))
                            {
                                this.inpt_leader.Text = teacher.Name;
                            }
                        }
                    }
                }
            }
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (
                this.inpt_name.Texts != "" &&
                this.inpt_faculty.Text != ""
                )
            {
                Class @class = classServices.GetById(this.id);

                @class.Name = this.inpt_name.Texts;

                foreach (var faculty in faculties)
                {
                    if (this.inpt_faculty.Text.Equals(faculty.Name))
                    {
                        @class.FacultyID = faculty.ID;
                    }
                }

                if (inpt_leader.Text != "")
                {
                    foreach (var teacher in teachers)
                    {
                        if (this.inpt_leader.Text.Equals(teacher.Name))
                        {
                            @class.LeaderID = teacher.ID;
                        }
                    }
                }

                if (this.inpt_monitor.Text != "")
                {
                    foreach (var student in students)
                    {
                        if (this.inpt_monitor.Text.Equals(student.ID))
                        {
                            @class.MonitorID = student.ID;
                        }
                    }
                }

                @class.UpdatedBy = Properties.Settings.Default.Username;
                @class.UpdatedDate = DateTime.Now;

                classServices.Update(@class);
                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng và đủ thông tin!");
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
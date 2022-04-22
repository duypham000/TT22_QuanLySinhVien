using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.FacultyViews
{
    public partial class FacultyUpdate : Form
    {
        private int oldId = -1;
        private FacultyServices facultyServices = null;
        private TeacherServices teacherServices = null;
        private List<Teacher> teachers = null;

        public FacultyUpdate(int id)
        {
            InitializeComponent();

            this.oldId = id;
            teacherServices = new TeacherServices();
            facultyServices = new FacultyServices();

            addLeaderName();
            getData();
        }

        private void getData()
        {
            teachers = teacherServices.GetAll();
            Faculty faculty = facultyServices.GetById(oldId);
            this.inpt_name.Texts = faculty.Name;
            if (faculty.LeaderID != null)
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.ID == faculty.LeaderID)
                    {
                        this.inpt_leader.Text = teacher.Name;
                    }
                }
            }
        }

        private void addLeaderName()
        {
            this.teachers = teacherServices.GetAll();
            foreach (var teacher in this.teachers)
            {
                this.inpt_leader.Items.Add(teacher.Name);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (
                this.inpt_name.Texts != ""
            )
            {
                Faculty faculty = facultyServices.GetById(oldId);

                faculty.Name = this.inpt_name.Texts;

                if (this.inpt_leader.Text != "")
                {
                    foreach (var teacher in teachers)
                    {
                        if (teacher.Name.Equals(this.inpt_leader.Text))
                        {
                            faculty.LeaderID = teacher.ID;
                        }
                    }
                }

                faculty.CreatedBy = Properties.Settings.Default.Username;
                faculty.CreatedDate = DateTime.Now;

                facultyServices.Update(faculty);
                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên khoa!");
            }
        }

        private void backToList()
        {
            this.Tag = "list-faculty";
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
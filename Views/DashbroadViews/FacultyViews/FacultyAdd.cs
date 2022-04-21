using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.FacultyViews
{
    public partial class FacultyAdd : Form
    {
        private FacultyServices facultyServices = null;
        private TeacherServices teacherServices = null;
        private List<Teacher> teachers = null;

        public FacultyAdd()
        {
            InitializeComponent();

            teacherServices = new TeacherServices();
            facultyServices = new FacultyServices();

            addLeaderName();
        }

        private void addLeaderName()
        {
            this.teachers = teacherServices.GetAll();
            foreach (var teacher in this.teachers)
            {
                this.inpt_leader.Items.Add(teacher.Name);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (
                this.inpt_id.Texts != "" &&
                this.inpt_name.Texts != "" &&
                this.inpt_leader.Text != ""
            )
            {
                Faculty faculty = new Faculty();

                faculty.ID = this.inpt_id.Texts;
                faculty.Name = this.inpt_name.Texts;

                foreach (var teacher in teachers)
                {
                    if (teacher.Name.Equals(this.inpt_leader.Text))
                    {
                        faculty.LeaderID = teacher.ID;
                    }
                }

                faculty.CreatedBy = Properties.Settings.Default.Username;
                faculty.CreatedDate = DateTime.Now;

                facultyServices.Add(faculty);
                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng và đủ thông tin!");
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

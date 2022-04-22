using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.StudentViews
{
    public partial class StudentUpdateView : Form
    {
        private int oldID = 0;
        private StudentServices studentServices = null;
        private ClassServices classServices = null;
        private UserServices userServices = null;

        private List<User> users = null;
        private List<Class> classes = null;
        private List<Student> students = null;
        private string[] studentStatus = { "Đã thôi học", "Đang học", "Bảo lưu" };

        public StudentUpdateView(int id)
        {
            InitializeComponent();

            this.oldID = id;

            studentServices = new StudentServices();
            classServices = new ClassServices();
            userServices = new UserServices();
            classes = classServices.GetAll();
            users = userServices.GetAllUsers();
            students = studentServices.GetAll();

            addDropdownName();
            getData();
        }

        private void getData()
        {
            Student student = studentServices.GetByID(oldID);

            this.inpt_id.Texts = student.StudentID;
            this.inpt_roles.Texts = student.ClassRole;
            this.inpt_name.Texts = student.Name;
            this.inpt_phone.Texts = student.Phone;
            this.inpt_status.Text = student.Status;
            this.inpt_dateb.Texts = student.DateOfBirth;
            this.inpt_his.Texts = student.SchoolProfile;
            this.inpt_address.Texts = student.Address;
            this.inpt_re.Texts = student.Religion;

            for (int i = 0; i < classes.Count; i++)
            {
                if (student.ClassID.Equals(classes[i].ID))
                {
                    this.inpt_class.SelectedIndex = i;
                }
            }
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (
               this.inpt_id.Texts != "" &&
               this.inpt_name.Texts != "" &&
               this.inpt_phone.Texts != "" &&
               this.inpt_status.Text != "" &&
               this.inpt_dateb.Texts != "" &&
               this.inpt_address.Texts != "" &&
               this.inpt_re.Texts != ""
           )
            {
                foreach (var student1 in students)
                {
                    if (student1.StudentID.Equals(this.inpt_id.Texts))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại!");
                        return;
                    }
                }

                Student student = studentServices.GetByID(this.oldID);

                student.StudentID = this.inpt_id.Texts;
                student.Name = this.inpt_name.Texts;
                if (this.inpt_roles.Texts != "")
                {
                    student.ClassRole = this.inpt_roles.Texts;
                }
                student.Phone = this.inpt_phone.Texts;
                student.Status = this.inpt_status.Text;
                student.DateOfBirth = this.inpt_dateb.Texts;

                if (this.inpt_class.Text != "")
                {
                    foreach (var @class in classes)
                    {
                        if (@class.Name.Equals(this.inpt_class.Text))
                        {
                            student.ClassID = @class.ID;
                        }
                    }
                }

                if (this.inpt_his.Texts != "")
                {
                    student.SchoolProfile = this.inpt_his.Texts;
                }

                student.Address = this.inpt_address.Texts;
                student.Religion = this.inpt_re.Texts;
                student.UpdatedBy = Properties.Settings.Default.Username;
                student.UpdatedDate = DateTime.Now;
                studentServices.Update(student);

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

        private void inpt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
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

namespace QuanLySinhVien.Views.DashbroadViews.StudentViews
{
    public partial class StudentAdd : Form
    {
        private StudentServices studentServices = null;
        private ClassServices classServices = null;
        private UserServices userServices = null;

        private List<User> users = null;
        private List<Class> classes = null;
        private string[] studentStatus = { "Đã thôi học", "Đang học", "Bảo lưu"};

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
                this.inpt_class.Items.Add(classi.Name);
            }

            foreach (var status in studentStatus)
            {
                this.inpt_status.Items.Add(status);
            }
            foreach (var user in users)
            {
                this.inpt_user.Items.Add(user.Name);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int index;

            if (
                this.inpt_id.Texts != "" &&
                this.inpt_roles.Texts != ""
            )
            {
                Student student = new Student();

                student.ID = this.inpt_id.Texts;
                student.ClassRole = this.inpt_roles.Texts;

                student.Status = this.inpt_status.Text;

                index = this.inpt_class.SelectedIndex;
                student.ClassID = this.classes[index].ID;
                
                index = this.inpt_user.SelectedIndex;
                student.UserID = users[index].Username;

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
using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.RoleViews
{
    public partial class RoleAdd : Form
    {
        private RoleServices roleServices = null;
        private List<Role> roles = null;

        public RoleAdd()
        {
            InitializeComponent();

            roleServices = new RoleServices();
            roles = roleServices.GetAll();
        }

        // chữ cái đầu của quản lý + mã truy cập thêm sửa xóa
        // vs xem xóa khoa: F1001
        private string perToString()
        {
            string res = "";

            res += "F";
            if (this.faculty_view.Checked)
                res += "1";
            else
                res += "0";
            if (this.faculty_add.Checked)
                res += "1";
            else
                res += "0";
            if (this.faculty_update.Checked)
                res += "1";
            else
                res += "0";
            if (this.faculty_remove.Checked)
                res += "1";
            else
                res += "0";
            res += "-";

            res += "R";
            if (this.role_view.Checked)
                res += "1";
            else
                res += "0";
            if (this.role_add.Checked)
                res += "1";
            else
                res += "0";
            if (this.role_update.Checked)
                res += "1";
            else
                res += "0";
            if (this.role_remove.Checked)
                res += "1";
            else
                res += "0";
            res += "-";

            res += "T";
            if (this.teacher_view.Checked)
                res += "1";
            else
                res += "0";
            if (this.teacher_add.Checked)
                res += "1";
            else
                res += "0";
            if (this.teacher_update.Checked)
                res += "1";
            else
                res += "0";
            if (this.teacher_remove.Checked)
                res += "1";
            else
                res += "0";
            res += "-";

            res += "C";
            if (this.class_view.Checked)
                res += "1";
            else
                res += "0";
            if (this.class_add.Checked)
                res += "1";
            else
                res += "0";
            if (this.class_update.Checked)
                res += "1";
            else
                res += "0";
            if (this.class_remove.Checked)
                res += "1";
            else
                res += "0";
            res += "-";

            res += "S";
            if (this.student_view.Checked)
                res += "1";
            else
                res += "0";
            if (this.student_add.Checked)
                res += "1";
            else
                res += "0";
            if (this.student_update.Checked)
                res += "1";
            else
                res += "0";
            if (this.student_remove.Checked)
                res += "1";
            else
                res += "0";
            res += "-";

            res += "A";
            if (this.acc_view.Checked)
                res += "1";
            else
                res += "0";
            if (this.acc_add.Checked)
                res += "1";
            else
                res += "0";
            if (this.acc_update.Checked)
                res += "1";
            else
                res += "0";
            if (this.acc_remove.Checked)
                res += "1";
            else
                res += "0";

            return res;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (
                this.inpt_name.Texts != ""
            )
            {
                Role role = new Role();
                role.Name = this.inpt_name.Texts;
                if (inpt_desc.Texts != "")
                {
                    role.Description = this.inpt_desc.Texts;
                }

                role.Permission = perToString();
                role.CreatedBy = Properties.Settings.Default.Username;
                role.CreatedDate = DateTime.Now;
                roleServices.Add(role);

                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng và đủ thông tin!");
            }
        }

        private void backToList()
        {
            this.Tag = "list-role";
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
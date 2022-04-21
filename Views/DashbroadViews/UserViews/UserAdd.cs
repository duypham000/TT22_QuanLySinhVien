using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.UserViews
{
    public partial class UserAdd : Form
    {
        private UserServices userServices = null;
        private RoleServices roleServices = null;
        private List<Role> roles = null;

        public UserAdd()
        {
            InitializeComponent();

            userServices = new UserServices();
            roleServices = new RoleServices();
            addRoleName();
        }

        private void addRoleName()
        {
            this.roles = roleServices.GetAll();
            foreach (Role role in this.roles)
            {
                this.inpt_role.Items.Add(role.Name);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (
                this.inpt_username.Texts != "" &&
                this.inpt_password.Texts != "" &&
                this.inpt_email.Texts != "" 
            )
            {
                User user = new User();
                user.Username = this.inpt_username.Texts;
                user.Password = this.inpt_password.Texts;
                user.Email = this.inpt_email.Texts;
                user.RoleID = roles[this.inpt_role.SelectedIndex].ID;
                user.CreatedBy = Properties.Settings.Default.Username;
                user.CreatedDate = DateTime.Now;

                userServices.Add(user);
                backToList();
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng và đủ thông tin!");
            }
        }

        private void backToList()
        {
            this.Tag = "list-user";
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
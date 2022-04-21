using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.UserViews
{
    public partial class UserUpdate : Form
    {
        private UserServices userServices = null;
        private RoleServices roleServices = null;
        private List<Role> roles = null;
        private string username = null;

        public UserUpdate(string username)
        {
            InitializeComponent();

            userServices = new UserServices();
            roleServices = new RoleServices();
            this.username = username;
            addRoleName();
            getData();
        }

        private void getData()
        {
            User user = userServices.GetByUsername(this.username);
            this.inpt_username.Texts = user.Username;
            this.inpt_password.Texts = user.Password;
            this.inpt_email.Texts = user.Email;
            for (int i = 0; i < roles.Count; i++)
            {
                if (roles[i].ID == user.RoleID)
                {
                    this.inpt_role.SelectedIndex = i;
                }
            }
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
                user.UpdatedBy = Properties.Settings.Default.Username;
                user.UpdatedDate = DateTime.Now;

                userServices.Update(user, this.username);
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
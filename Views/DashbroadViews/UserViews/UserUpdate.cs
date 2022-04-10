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

            // do không có license của siticone nên phải chỉnh code ở đây
            changeStyle();
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
            this.inpt_name.Texts = user.Name;
            this.inpt_address.Texts = user.Address;
            this.inpt_phone.Texts = user.Phone;
            if (user.Age != null)
            {
                this.inpt_age.Value = (decimal)user.Age;
            }
        }

        private void changeStyle()
        {
            this.inpt_age.ForeColor = Color.White;
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
                this.inpt_email.Texts != "" &&
                this.inpt_address.Texts != "" &&
                this.inpt_phone.Texts != "" &&
                this.inpt_age.Value != 0
            )
            {
                User user = new User();
                user.Username = this.inpt_username.Texts;
                user.Password = this.inpt_password.Texts;
                user.Email = this.inpt_email.Texts;
                user.RoleID = roles[this.inpt_role.SelectedIndex].ID;
                user.Name = this.inpt_name.Texts;
                user.Address = this.inpt_address.Texts;
                user.Phone = this.inpt_phone.Texts;
                user.Age = (int)this.inpt_age.Value;
                user.Status = true;
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
    }
}
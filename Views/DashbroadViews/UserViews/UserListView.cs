using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.UserViews
{
    public partial class UserListView : Form
    {
        private UserServices userServices = null;
        private int pageSize = 22;
        private int curPage = 1;
        public UserListView(Form form)
        {
            InitializeComponent();
            userServices = new UserServices();
            intitalFillToTable(this.curPage, this.pageSize);
        }

        private void intitalFillToTable(int page, int size)
        {
            this.userTable.Rows.Clear();
            List<User> users = userServices.GetAllPaging(page, size);
            foreach (var user in users)
            {
                this.userTable.Rows.Add(user.Username, user.Name, user.RoleID, user.Age, user.Email, user.Address, user.Phone);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            // 424 16
            double currSize = this.userTable.Height, sSize = 424;
            double size = ((currSize - sSize) / 16) + 22;
            intitalFillToTable(this.curPage, (int)Math.Floor(size));
            this.pageSize = (int)size;
        }

        private string getCurrentUsername()
        {
            int index = this.userTable.SelectedRows[0].Index;
            return this.userTable.Rows[index].Cells[0].Value.ToString();
        }

        private void test(object sender, EventArgs e)
        {
            this.Tag = "add-user";
            this.Close();
        }
    }
}
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
        private RoleServices roleServices = null;
        private int pageSize = 22;
        private int curPage = 1;
        private int totalPage = 1;

        public UserListView()
        {
            InitializeComponent();
            userServices = new UserServices();
            roleServices = new RoleServices();

            fillToTable(this.curPage, this.pageSize);
        }

        private void fillToTable(int page, int size)
        {
            this.userTable.Rows.Clear();

            // đoạn này cần chuyển sang double để không bị tự làm tròn xuống
            double userCount = userServices.Count();
            double pagSz = pageSize;
            double total = userCount / pagSz;
            int totalpage = (int)Math.Ceiling(total);
            this.nav_display.Text = curPage + "/" + totalpage;
            this.totalPage = totalpage;

            if (this.curPage == 1)
            {
                this.nav_toFirst.Enabled = false;
                this.nav_toPre.Enabled = false;
            }
            else
            {
                this.nav_toFirst.Enabled = true;
                this.nav_toPre.Enabled = true;
            }
            if (this.curPage == totalPage)
            {
                this.nav_toLast.Enabled = false;
                this.nav_toNext.Enabled = false;
            }
            else
            {
                this.nav_toLast.Enabled = true;
                this.nav_toNext.Enabled = true;
            }
            if (this.curPage > totalPage)
            {
                this.curPage = this.totalPage;
            }

            List<User> users = userServices.GetAllPaging(page, size);
            foreach (var user in users)
            {
                Role role = roleServices.GetByID(user.RoleID);
                this.userTable.Rows.Add(user.Username, user.Name, role.Name, user.Age, user.Email, user.Address, user.Phone);
            }
        }

        private void nextPage(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage++;
                fillToTable(this.curPage, this.pageSize);
            }
        }

        private void prevPage(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage--;
                fillToTable(this.curPage, this.pageSize);
            }
        }

        private void toFirst(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage = 1;
                fillToTable(this.curPage, this.pageSize);
            }
        }

        private void toLast(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage = this.totalPage;
                fillToTable(this.curPage, this.pageSize);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            // 524 22
            double currSize = this.userTable.Height, sSize = 524;
            double size = ((currSize - sSize) / 22) + 20;
            this.pageSize = (int)size;
            fillToTable(this.curPage, (int)Math.Floor(size));
        }

        private string[] getCurrentUsername()
        {
            int total = this.userTable.SelectedRows.Count;
            string[] res = new string[total];
            for (int i = 0; i < total; i++)
            {
                int index = this.userTable.SelectedRows[i].Index;
                res[i] = this.userTable.Rows[index].Cells[0].Value.ToString();
            }
            return res;
        }

        private void addUser(object sender, EventArgs e)
        {
            this.Tag = "add-user";
            this.Close();
        }

        private void removeUser(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa các mục đã chọn?";
            string title = "Xóa users";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                foreach (var username in getCurrentUsername())
                {
                    userServices.DeleteByUsername(username);
                    fillToTable(curPage, this.pageSize);
                }
            }
        }

        private void updateUser(object sender, EventArgs e)
        {
            this.Tag = "update-user/" + getCurrentUsername();
            this.Close();
        }
    }
}
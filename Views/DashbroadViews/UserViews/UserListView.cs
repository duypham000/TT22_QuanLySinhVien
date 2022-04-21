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
        private List<User> users = null;
        private int pageSize = 11;
        private int curPage = 1;
        private int totalPage = 1;
        private string searchType = null;
        private string[] searchOption = { "username", "email" };

        public UserListView()
        {
            InitializeComponent();
            this.userServices = new UserServices();
            this.roleServices = new RoleServices();
            this.users = userServices.GetAllUsers();
            this.searchType = "username";
            this.type_search.SelectedIndex = 0;

            fillToTable(this.curPage, this.pageSize, this.users);
        }

        private void fillToTable(int page, int size, List<User> usersList)
        {
            this.userTable.Rows.Clear();

            // đoạn này cần chuyển sang double để không bị tự làm tròn xuống
            double userCount = usersList.Count;
            double pagSz = pageSize;
            double total = userCount / pagSz;
            int totalpage = (int)Math.Ceiling(total);

            if (this.curPage > totalpage)
            {
                this.curPage = totalpage;
            }

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

            List<User> listUsers = new List<User>();
            if (usersList.Count > size)
            {
                int skipCount = (page - 1) * size;
                if ((skipCount + size) > usersList.Count)
                {
                    for (int i = skipCount; i < usersList.Count; i++)
                    {
                        listUsers.Add(usersList[i]);
                    }
                }
                else
                    listUsers = usersList.GetRange(skipCount, size);
            }
            else
            {
                listUsers = usersList;
            }
            foreach (var user in listUsers)
            {
                Role role = roleServices.GetByID(user.RoleID);
                this.userTable.Rows.Add(user.Username, role.Name, user.Email);
            }
        }

        #region NavControl

        private void nextPage(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage++;
                fillToTable(this.curPage, this.pageSize, this.users);
            }
        }

        private void prevPage(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage--;
                fillToTable(this.curPage, this.pageSize, this.users);
            }
        }

        private void toFirst(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage = 1;
                fillToTable(this.curPage, this.pageSize, this.users);
            }
        }

        private void toLast(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage = this.totalPage;
                fillToTable(this.curPage, this.pageSize, this.users);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            double currSize = this.userTable.Height - this.userTable.ColumnHeadersHeight;
            double size = currSize / this.userTable.RowTemplate.Height;
            this.pageSize = (int)Math.Floor(size);
            fillToTable(this.curPage, this.pageSize, this.users);
        }

        #endregion NavControl

        #region UserControl

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
                }
                this.users = userServices.GetAllUsers();
                fillToTable(curPage, this.pageSize, this.users);
            }
        }

        private void updateUser(object sender, EventArgs e)
        {
            if (getCurrentUsername().Length < 2)
            {
                this.Tag = "update-user/" + getCurrentUsername()[0];
                this.Close();
            }
        }

        #endregion UserControl

        private void findAndDisplay(object sender, EventArgs e)
        {
            this.users = userServices.GetAllUsers();
            List<User> res = new List<User>();
            var searchValue = this.inpt_search.Text;
            if (this.searchType.Equals("username")) {
                foreach (var user in users)
                {
                    if (user.Username.Contains(searchValue))
                    {
                        res.Add(user);
                    }
                }
            }else if (this.searchType.Equals("email"))
            {
                foreach (var user in users)
                {
                    if (user.Email.Contains(searchValue))
                    {
                        res.Add(user);
                    }
                }
            }
            this.users.Clear();
            this.users = res;
            this.curPage = 1;
            fillToTable(this.curPage, this.pageSize, res);
        }

        private void type_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.type_search.SelectedIndex;
            searchType = searchOption[index];
        }

        private void inpt_search_KeyDown(object sender, KeyEventArgs e)
        {
            findAndDisplay(null, null);
        }
    }
}
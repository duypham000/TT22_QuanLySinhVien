using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.RoleViews
{
    public partial class RoleListView : Form
    {
        private RoleServices roleServices = null;
        private List<Role> roles = null;

        private int pageSize = 11;
        private int curPage = 1;
        private int totalPage = 1;
        private string searchType = null;
        private string[] searchOption = { "name", "per" };

        public RoleListView()
        {
            InitializeComponent();

            roleServices = new RoleServices();
            roles = roleServices.GetAll();

            this.searchType = "name";
            this.type_search.SelectedIndex = 0;

            fillToTable(this.curPage, this.pageSize, this.roles);
            permissionCheck();
        }
        private void permissionCheck()
        {
            string[] permis = Properties.Settings.Default.Permission.Split('-');
            foreach (var per in permis)
            {
                char[] p = per.ToCharArray();
                if (p[0].Equals('R'))
                {
                    if (p[2].Equals('0'))
                    {
                        this.btn_add.Enabled = false;
                    }
                    if (p[3].Equals('0'))
                    {
                        this.btn_update.Enabled = false;
                    }
                    if (p[4].Equals('0'))
                    {
                        this.btn_delete.Enabled = false;
                    }
                }
            }
        }

        private void fillToTable(int page, int size, List<Role> roleList)
        {
            this.roleTable.Rows.Clear();

            // đoạn này cần chuyển sang double để không bị tự làm tròn xuống
            double userCount = roleList.Count;
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

            List<Role> newRoleList = new List<Role>();
            if (roleList.Count > size)
            {
                int skipCount = (page - 1) * size;
                if ((skipCount + size) > roleList.Count)
                {
                    for (int i = skipCount; i < roleList.Count; i++)
                    {
                        newRoleList.Add(roleList[i]);
                    }
                }
                else
                    newRoleList = roleList.GetRange(skipCount, size);
            }
            else
            {
                newRoleList = roleList;
            }
            foreach (var role in newRoleList)
            {
                this.roleTable.Rows.Add(role.Name, role.Description, role.Permission);
            }
        }

        #region NavControl

        private void nextPage(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage++;
                fillToTable(this.curPage, this.pageSize, this.roles);
            }
        }

        private void prevPage(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage--;
                fillToTable(this.curPage, this.pageSize, this.roles);
            }
        }

        private void toFirst(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage = 1;
                fillToTable(this.curPage, this.pageSize, this.roles);
            }
        }

        private void toLast(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage = this.totalPage;
                fillToTable(this.curPage, this.pageSize, this.roles);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            double currSize = this.roleTable.Height - this.roleTable.ColumnHeadersHeight;
            double size = currSize / this.roleTable.RowTemplate.Height;
            int oldSize = this.pageSize;
            this.pageSize = (int)Math.Floor(size);
            if (oldSize != this.pageSize)
            {
                fillToTable(this.curPage, this.pageSize, this.roles);
            }
        }

        #endregion NavControl

        #region UserControl

        private int[] getCurrentId()
        {
            int total = this.roleTable.SelectedRows.Count;
            int[] res = new int[total];
            for (int i = 0; i < total; i++)
            {
                int index = this.roleTable.SelectedRows[i].Index;
                index += (curPage - 1) * pageSize;
                res[i] = this.roles[index].ID;
            }
            return res;
        }

        private void addUser(object sender, EventArgs e)
        {
            this.Tag = "add-role";
            this.Close();
        }

        private void removeUser(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa các mục đã chọn?";
            string title = "Xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                foreach (var id in getCurrentId())
                {
                    roleServices.DeteleById(id);
                }
                this.roles = roleServices.GetAll();
                fillToTable(curPage, this.pageSize, this.roles);
            }
        }

        private void updateUser(object sender, EventArgs e)
        {
            if (btn_update.Enabled)
            {
                if (getCurrentId().Length < 2)
                {
                    this.Tag = "update-role/" + getCurrentId()[0];
                    this.Close();
                }
            }
        }

        #endregion UserControl

        private void findAndDisplay(object sender, EventArgs e)
        {
            this.roles = roleServices.GetAll();
            List<Role> res = new List<Role>();
            var searchValue = this.inpt_search.Text;

            if (this.searchType.Equals("name"))
            {
                foreach (var role in roles)
                {
                    if (role.Name.Contains(searchValue))
                    {
                        res.Add(role);
                    }
                }
            }
            else if (this.searchType.Equals("per"))
            {
                foreach (var role in roles)
                {
                    if (role.Permission.Contains(searchValue))
                    {
                        res.Add(role);
                    }
                }
            }

            this.roles.Clear();
            this.roles = res;
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
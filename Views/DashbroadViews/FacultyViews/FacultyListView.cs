using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.FacultyViews
{
    public partial class FacultyListView : Form
    {
        private FacultyServices facultyServices = null;
        private TeacherServices teacherServices = null;
        private List<Teacher> teachers = null;
        private List<Faculty> faculties = null;
        private int pageSize = 11;
        private int curPage = 1;
        private int totalPage = 1;
        private string searchType = null;
        private string[] searchOption = { "name", "leader" };

        public FacultyListView()
        {
            InitializeComponent();
            this.facultyServices = new FacultyServices();
            this.teacherServices = new TeacherServices();
            this.teachers = teacherServices.GetAll();
            this.faculties = facultyServices.GetAll();

            this.searchType = "name";
            this.type_search.SelectedIndex = 0;

            fillToTable(this.curPage, this.pageSize, this.faculties);
            permissionCheck();
        }
        private void permissionCheck()
        {
            string[] permis = Properties.Settings.Default.Permission.Split('-');
            foreach (var per in permis)
            {
                char[] p = per.ToCharArray();
                if (p[0].Equals('F'))
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

        private void fillToTable(int page, int size, List<Faculty> faculityList)
        {
            this.classTable.Rows.Clear();

            // đoạn này cần chuyển sang double để không bị tự làm tròn xuống
            double userCount = faculityList.Count;
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

            List<Faculty> newFaculityList = new List<Faculty>();
            if (faculityList.Count > size)
            {
                int skipCount = (page - 1) * size;
                if ((skipCount + size) > faculityList.Count)
                {
                    for (int i = skipCount; i < faculityList.Count; i++)
                    {
                        newFaculityList.Add(faculityList[i]);
                    }
                }
                else
                    newFaculityList = faculityList.GetRange(skipCount, size);
            }
            else
            {
                newFaculityList = faculityList;
            }
            foreach (var faculty in newFaculityList)
            {
                string leaderName = "";
                foreach (var teacher in teachers)
                {
                    if (teacher.ID.Equals(faculty.LeaderID))
                    {
                        leaderName = teacher.Name;
                    }
                }
                this.classTable.Rows.Add(faculty.Name, leaderName);
            }
        }

        #region NavControl

        private void nextPage(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage++;
                fillToTable(this.curPage, this.pageSize, this.faculties);
            }
        }

        private void prevPage(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage--;
                fillToTable(this.curPage, this.pageSize, this.faculties);
            }
        }

        private void toFirst(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage = 1;
                fillToTable(this.curPage, this.pageSize, this.faculties);
            }
        }

        private void toLast(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage = this.totalPage;
                fillToTable(this.curPage, this.pageSize, this.faculties);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            double currSize = this.classTable.Height - this.classTable.ColumnHeadersHeight;
            double size = currSize / this.classTable.RowTemplate.Height;
            int oldSize = this.pageSize;
            this.pageSize = (int)Math.Floor(size);
            if (oldSize != this.pageSize)
            {
                fillToTable(this.curPage, this.pageSize, this.faculties);
            }
        }

        #endregion NavControl

        #region UserControl

        private int[] getCurrentId()
        {
            int total = this.classTable.SelectedRows.Count;
            int[] res = new int[total];
            for (int i = 0; i < total; i++)
            {
                int index = this.classTable.SelectedRows[i].Index;
                index += (curPage - 1) * pageSize;
                res[i] = faculties[index].ID;
            }
            return res;
        }

        private void addUser(object sender, EventArgs e)
        {
            this.Tag = "add-faculty";
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
                    facultyServices.DeleteByID(id);
                }
                this.faculties = facultyServices.GetAll();
                fillToTable(curPage, this.pageSize, this.faculties);
            }
        }

        private void updateUser(object sender, EventArgs e)
        {
            if (this.btn_update.Enabled)
            {
                if (getCurrentId().Length < 2)
                {
                    this.Tag = "update-faculty/" + getCurrentId()[0];
                    this.Close();
                }
            }
        }

        #endregion UserControl

        private void findAndDisplay(object sender, EventArgs e)
        {
            this.faculties = facultyServices.GetAll();
            List<Faculty> res = new List<Faculty>();
            var searchValue = this.inpt_search.Text;
            if (this.searchType.Equals("name"))
            {
                foreach (var faculty in faculties)
                {
                    if (faculty.Name.Contains(searchValue))
                    {
                        res.Add(faculty);
                    }
                }
            }
            else if (this.searchType.Equals("leader"))
            {
                foreach (var faculty in faculties)
                {
                    foreach (var teacher in teachers)
                    {
                        if (faculty.LeaderID.Equals(teacher.ID) && teacher.Name.Contains(searchValue))
                        {
                            res.Add(faculty);
                        }
                    }
                }
            }
            this.faculties.Clear();
            this.faculties = res;
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
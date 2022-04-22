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

namespace QuanLySinhVien.Views.DashbroadViews.TeacherViews
{
    public partial class TeacherListView : Form
    {
        private ClassServices classServices = null;
        private TeacherServices teacherServices = null;
        private UserServices userServices = null;
        private List<Teacher> teachers = null;
        private List<Class> classes = null;
        private List<User> users = null;
        private int pageSize = 11;
        private int curPage = 1;
        private int totalPage = 1;
        private string searchType = null;
        private string[] searchOption = { "name", "class" };


        public TeacherListView()
        {
            InitializeComponent();
            this.classServices = new ClassServices();
            this.teacherServices = new TeacherServices();
            this.userServices = new UserServices();
            this.teachers = teacherServices.GetAll();
            this.classes = classServices.GetAll();
            this.users = userServices.GetAllUsers();

            this.searchType = "name";
            this.type_search.SelectedIndex = 0;

            fillToTable(this.curPage, this.pageSize, this.teachers);
        }

        private void fillToTable(int page, int size, List<Teacher> teacherList)
        {
            this.teacherTable.Rows.Clear();

            // đoạn này cần chuyển sang double để không bị tự làm tròn xuống
            double userCount = teacherList.Count;
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

            List<Teacher> newTeacherList = new List<Teacher>();
            if (teacherList.Count > size)
            {
                int skipCount = (page - 1) * size;
                if ((skipCount + size) > teacherList.Count)
                {
                    for (int i = skipCount; i < teacherList.Count; i++)
                    {
                        newTeacherList.Add(teacherList[i]);
                    }
                }
                else
                    newTeacherList = teacherList.GetRange(skipCount, size);
            }
            else
            {
                newTeacherList = teacherList;
            }
            foreach (var teacher1 in newTeacherList)
            {
                string className = "", username = "";
                foreach (var @class in classes)
                {
                    if (@class.ID.Equals(teacher1.ID))
                    {
                        className = @class.Name;
                    }
                }
                foreach (var user in users)
                {
                    if (user.ID.Equals(teacher1.UserID))
                    {
                        username = user.Username;
                    }
                }
                this.teacherTable.Rows.Add(teacher1.Name, username, teacher1.Phone, className, teacher1.Status);
            }
        }

        #region NavControl

        private void nextPage(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage++;
                fillToTable(this.curPage, this.pageSize, this.teachers);
            }
        }

        private void prevPage(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage--;
                fillToTable(this.curPage, this.pageSize, this.teachers);
            }
        }

        private void toFirst(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage = 1;
                fillToTable(this.curPage, this.pageSize, this.teachers);
            }
        }

        private void toLast(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage = this.totalPage;
                fillToTable(this.curPage, this.pageSize, this.teachers);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            double currSize = this.teacherTable.Height - this.teacherTable.ColumnHeadersHeight;
            double size = currSize / this.teacherTable.RowTemplate.Height;
            int oldSize = this.pageSize;
            this.pageSize = (int)Math.Floor(size);
            if (oldSize != this.pageSize)
            {
                fillToTable(this.curPage, this.pageSize, this.teachers);
            }
        }

        #endregion NavControl

        #region UserControl

        private int[] getCurrentId()
        {
            int total = this.teacherTable.SelectedRows.Count;
            int[] res = new int[total];
            for (int i = 0; i < total; i++)
            {
                int index = this.teacherTable.SelectedRows[i].Index;
                index += (curPage - 1) * pageSize;
                res[i] = teachers[index].ID;
            }
            return res;
        }

        private void addUser(object sender, EventArgs e)
        {
            this.Tag = "add-teacher";
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
                    teacherServices.DeleteById(id);
                }
                this.teachers = teacherServices.GetAll();
                fillToTable(curPage, this.pageSize, this.teachers);
            }
        }

        private void updateUser(object sender, EventArgs e)
        {
            if (getCurrentId().Length < 2)
            {
                this.Tag = "update-teacher/" + getCurrentId()[0];
                this.Close();
            }
        }

        #endregion UserControl

        private void findAndDisplay(object sender, EventArgs e)
        {
            this.teachers = teacherServices.GetAll();
            List<Teacher> res = new List<Teacher>();
            var searchValue = this.inpt_search.Text;
            if (this.searchType.Equals("name"))
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Name.Contains(searchValue))
                    {
                        res.Add(teacher);
                    }
                }
            }
            else if (this.searchType.Equals("class"))
            {
                foreach (var teacher in teachers)
                {
                    foreach (var @class in classes)
                    {
                        if (teacher.ClassID.Equals(@class.ID) && @class.Name.Contains(searchValue))
                        {
                            res.Add(teacher);
                        }
                    }
                }
            }
            this.teachers.Clear();
            this.teachers = res;
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

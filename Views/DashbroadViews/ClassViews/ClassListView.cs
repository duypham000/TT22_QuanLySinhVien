using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.ClassViews
{
    public partial class ClassListView : Form
    {
        private FacultyServices facultyServices = null;
        private TeacherServices teacherServices = null;
        private ClassServices classServices = null;
        private StudentServices studentServices = null;

        private List<Student> students = null;
        private List<Teacher> teachers = null;
        private List<Faculty> faculties = null;
        private List<Class> classes = null;

        private int pageSize = 11;
        private int curPage = 1;
        private int totalPage = 1;
        private string searchType = null;
        private string[] searchOption = { "id", "leader", "monitor" };

        public ClassListView()
        {
            InitializeComponent();
            this.facultyServices = new FacultyServices();
            this.teacherServices = new TeacherServices();
            this.classServices = new ClassServices();
            this.studentServices = new StudentServices();

            this.students = studentServices.GetAll();
            this.classes = classServices.GetAll();
            this.teachers = teacherServices.GetAll();
            this.faculties = facultyServices.GetAll();

            this.searchType = "id";
            this.type_search.SelectedIndex = 0;

            fillToTable(this.curPage, this.pageSize, this.classes);
        }

        private void fillToTable(int page, int size, List<Class> classList)
        {
            this.classTable.Rows.Clear();

            // đoạn này cần chuyển sang double để không bị tự làm tròn xuống
            double userCount = classList.Count;
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

            List<Class> newClassList = new List<Class>();
            if (classList.Count > size)
            {
                int skipCount = (page - 1) * size;
                if ((skipCount + size) > classList.Count)
                {
                    for (int i = skipCount; i < classList.Count; i++)
                    {
                        newClassList.Add(classList[i]);
                    }
                }
                else
                    newClassList = classList.GetRange(skipCount, size);
            }
            else
            {
                newClassList = classList;
            }
            foreach (var classi in newClassList)
            {
                string leaderName = "", monitorName = "", facultyName = "";

                foreach (var teacher in teachers)
                {
                    if (teacher.ID.Equals(classi.LeaderID))
                    {
                        leaderName = teacher.Name;
                    }
                }

                foreach (var student in students)
                {
                    if (classi.MonitorID.Equals(student.ID))
                    {
                        monitorName = student.Name;
                    }
                }

                foreach (var faculty in faculties)
                {
                    if (faculty.ID.Equals(classi.FacultyID))
                    {
                        facultyName = faculty.Name;
                    }
                }

                this.classTable.Rows.Add(classi.ID, facultyName, leaderName, monitorName);
            }
        }

        #region NavControl

        private void nextPage(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage++;
                fillToTable(this.curPage, this.pageSize, this.classes);
            }
        }

        private void prevPage(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage--;
                fillToTable(this.curPage, this.pageSize, this.classes);
            }
        }

        private void toFirst(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage = 1;
                fillToTable(this.curPage, this.pageSize, this.classes);
            }
        }

        private void toLast(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage = this.totalPage;
                fillToTable(this.curPage, this.pageSize, this.classes);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            double currSize = this.classTable.Height - this.classTable.ColumnHeadersHeight;
            double size = currSize / this.classTable.RowTemplate.Height;
            this.pageSize = (int)Math.Floor(size);
            fillToTable(this.curPage, this.pageSize, this.classes);
        }

        #endregion NavControl

        #region UserControl

        private string[] getCurrentId()
        {
            int total = this.classTable.SelectedRows.Count;
            string[] res = new string[total];
            for (int i = 0; i < total; i++)
            {
                int index = this.classTable.SelectedRows[i].Index;
                res[i] = this.classTable.Rows[index].Cells[0].Value.ToString();
            }
            return res;
        }

        private void addUser(object sender, EventArgs e)
        {
            this.Tag = "add-class";
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
                this.classes = classServices.GetAll();
                fillToTable(curPage, this.pageSize, this.classes);
            }
        }

        private void updateUser(object sender, EventArgs e)
        {
            if (getCurrentId().Length < 2)
            {
                this.Tag = "update-class/" + getCurrentId()[0];
                this.Close();
            }
        }

        #endregion UserControl

        private void findAndDisplay(object sender, EventArgs e)
        {
            this.classes = classServices.GetAll();
            List<Class> res = new List<Class>();
            var searchValue = this.inpt_search.Text;
            if (this.searchType.Equals("id"))
            {
                foreach (var @class in classes)
                {
                    if (@class.ID.Contains(searchValue))
                    {
                        res.Add(@class);
                    }
                }
            }
            else if (this.searchType.Equals("leader"))
            {
                foreach (var @class in classes)
                {
                    foreach (var teacher in teachers)
                    {
                        if (teacher.ID.Equals(@class.LeaderID) && teacher.Name.Contains(searchValue))
                        {
                            res.Add(@class);
                        }
                    }
                }
            }
            else if (this.searchType.Equals("monitor"))
            {
                foreach (var @class in classes)
                {
                    foreach (var student in students)
                    {
                        if (@class.MonitorID.Equals(student.ID) && student.Name.Contains(searchValue))
                        {
                            res.Add(@class);
                        }
                    }
                }
            }
            this.classes.Clear();
            this.classes = res;
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
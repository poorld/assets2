using Assets.Common.Entity;
using Assets.Views.DepartmentManage.Add;
using Assets.Views.DepartmentManage.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.DepartmentManage
{
    public partial class DepartmentForm : Form
    {
        DepartmentDao dao = new DepartmentDao();
        public const string tag_insert = "insert";
        public const string tag_update = "update";

        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            dataGridView1.Rows.Clear();
            List<Department> list = dao.getDepartments();
            foreach (Department d in list)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Tag = d;
                dataGridView1.Rows[index].Cells[0].Value = d.DepartmentId;
                dataGridView1.Rows[index].Cells[1].Value = d.DepartmentCode;
                dataGridView1.Rows[index].Cells[2].Value = d.DepartmentName;
            }
        }

        private void departmentAddClick(object sender, EventArgs e)
        {
            DepartmentAddForm addForm = new DepartmentAddForm();
            this.Tag = tag_insert;
            addForm.FormClosed += childClose;
            addForm.Tag = false;
            addForm.Show();
        }


        private void childClose(object sender, EventArgs e)
        {
            DepartmentAddForm form = (DepartmentAddForm)sender;
            // 点击x关闭
            if (!(bool)form.Tag)
                return;
            Department d = form.department;
            string tag = (string)this.Tag;
            if (tag.Equals(tag_insert))
            {
                d.DepartmentId = dao.getLastId() + 1;
                dao.addDepartment(d);
            }
            else
            {
                dao.updateDepartment(d);
            }
            initData();
        }

        private void departmentUpdateClick(object sender, EventArgs e)
        {
            Department d = (Department)dataGridView1.CurrentRow.Tag;
            if(d == null)
                return;


            DepartmentAddForm addForm = new DepartmentAddForm();
            this.Tag = tag_update;
            addForm.Tag = false;
            addForm.FormClosed += childClose;
            addForm.setDepartment(d);
            addForm.Show();
        }

        private void departmentRemoveClick(object sender, EventArgs e)
        {
            Department d = (Department)dataGridView1.CurrentRow.Tag;
            if (d == null)
                return;

            dao.delDepartment(d.DepartmentId);
            initData();
        }

       
    }
}

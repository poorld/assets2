using Assets.Common.Constant;
using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Views.DepartmentManage.Add
{
    public partial class DepartmentAddForm : Form
    {
        public Department department;

        public DepartmentAddForm()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            tbDepartmentCode.Text = CodePrefixConstant.getDepartmentCode();
        }

        public void setDepartment(Department d)
        {
            department = d;
            tbDepartmentCode.Text = d.DepartmentCode;
            tbDepartmentName.Text = d.DepartmentName;
            this.Text = "修改部门";
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            if (department == null)
                department = new Department();

            department.DepartmentCode = tbDepartmentCode.Text;
            department.DepartmentName = tbDepartmentName.Text;

            this.Tag = true;
            this.Close();
        }


    }
}

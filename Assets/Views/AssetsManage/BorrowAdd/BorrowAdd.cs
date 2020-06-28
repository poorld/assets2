using Assets.Common.Entity;
using Assets.Views.AssetManage.Dao;
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

namespace Assets.Views.AssetsManage.BorrowAdd
{
    public partial class BorrowAdd : Form
    {

        AssetsDao assetsDao = new AssetsDao();
        DepartmentDao departmentDao = new DepartmentDao();

        public BorrowAdd()
        {
            InitializeComponent();
        }

        private void BorrowAdd_Load(object sender, EventArgs e)
        {
            //未使用的
            List<Property> list =  assetsDao.storageList();
            //已归还的
            List<Property> list1 = assetsDao.returnList();

            foreach (Property p in list1)
                list.Add(p);

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Property_name";
            comboBox1.ValueMember = "Property_id";

            comboBox2.DataSource = departmentDao.getDepartments();
            comboBox2.DisplayMember = "DepartmentName";
            comboBox2.ValueMember = "DepartmentId";


        }

        public void setData()
        {
            comboBox1.Items.Clear();
            //已归还的
            List<Property> list1 = assetsDao.returnList();
            comboBox1.DataSource = list1;
            comboBox1.DisplayMember = "Property_name";
            comboBox1.ValueMember = "Property_id";
        }

        private void btnOk(object sender, EventArgs e)
        {
            int propertyId = Convert.ToInt32(comboBox1.SelectedValue);
            int departmentId = Convert.ToInt32(comboBox2.SelectedValue);
            string desc = textBox1.Text.Trim();

            assetsDao.assetsBorrow(propertyId, departmentId, desc);

            this.Close();

        }
    }
}

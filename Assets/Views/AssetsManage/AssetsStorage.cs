using Assets.Common.Entity;
using Assets.Views.AssetManage.Add;
using Assets.Views.AssetManage.Dao;
using Assets.Views.AssetsManage;
using Assets.Views.AssetsManage.BorrowAdd;
using Assets.Views.AssetsManage.RetirementAdd;
using Assets.Views.AssetsManage.ReturnAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.AssetManage
{
    public partial class AssetsStorage : Form
    {
        //资产入库
        public const int Storage = 1;
        //资产借用
        public const int Borrow = 2;
        //资产报废
        public const int Retirement = 3;
        //资产归还
        public const int Return = 4;

        private int type = 1;

        AssetsDao dao = new AssetsDao();

        public AssetsStorage()
        {
            InitializeComponent();
        }

        public void setType(int type)
        {
            this.type = type;
            switch (type)
            {
                case Storage:
                    button2.Text = "修改";
                    break;
                case Borrow:
                    button2.Text = "归还";
                    break;
                case Retirement:
                    button2.Text = "删除";
                    break;
                case Return:
                    button2.Text = "借用";
                    break;
            }

            loadData();
        }

        public void loadData()
        {
            List<Property> list = null;
            switch (type)
            {
                case Storage:
                    List<Property> list1 = dao.returnList();
                    list = dao.storageList();
                    foreach (Property p in list1)
                        list.Add(p);

                    List<Property> list2 = dao.retirementList();
                    foreach (Property p in list2)
                        list.Add(p);

                    List<Property> list3 = dao.borrowList();
                    foreach (Property p in list3)
                        list.Add(p);
                    //list.Concat(list1);
                    break;
                case Borrow:
                    list = dao.borrowList();

                    break;
                case Retirement:
                    list = dao.retirementList();

                    break;
                case Return:
                    list = dao.returnList();

                    break;
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void AssetsStorage_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridView1.Rows[e.RowIndex].DataBoundItem != null) &&
                (dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                string[] names = dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Split('.');
                object obj = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                for (int i = 0; i < names.Count(); ++i)
                {
                    try
                    {
                        var result = obj.GetType().GetProperty(names[i]).GetValue(obj, null);
                        obj = result;
                        e.Value = result.ToString();
                    }
                    catch (Exception)
                    {
                        return;
                        throw;
                    }
                }
            }
        }

        private void formClose(object sender, EventArgs e)
        {
            loadData();
        }

        private void addClick(object sender, EventArgs e)
        {
            switch (type)
            {
                case Storage:
                    AssetsAdd form = new AssetsAdd();
                    form.FormClosed += formClose;
                    form.Tag = "insert";
                    form.Show();
                    break;
                case Borrow:
                    BorrowAdd borrowForm = new BorrowAdd();
                    borrowForm.FormClosed += formClose;
                    borrowForm.Show();
                    break;
                case Retirement:
                    RetirementAdd retirementForm = new RetirementAdd();
                    retirementForm.FormClosed += formClose;
                    retirementForm.Show();
                    break;
                case Return:
                    ReturnAdd ReturnForm = new ReturnAdd();
                    ReturnForm.FormClosed += formClose;
                    ReturnForm.Show();
                    break;
            }

        }

        private void AssetsInfo(object sender, EventArgs e)
        {
            Property property = (Property)dataGridView1.CurrentRow.DataBoundItem;
            if (property == null)
                return;

            AssetsInfo form = new AssetsInfo();
            form.setInfo(property);
            form.Show();
        }

        private void update(object sender, EventArgs e)
        {
            Property property = (Property)dataGridView1.CurrentRow.DataBoundItem;
            if (property == null)
                return;

            switch (type)
            {
                case Storage:
                    AssetsAdd form = new AssetsAdd();
                    form.FormClosed += formClose;
                    form.Tag = "update";
                    form.setData(property);
                    form.Show();
                    break;
                case Borrow:
                    dao.assetsReturn(property.Property_id);
                    loadData();
                    break;
                case Retirement:
                    //loadData();
                    dao.delete(property.Property_id);
                    loadData();
                    break;
                case Return:
                    BorrowAdd borrowForm = new BorrowAdd();
                    borrowForm.FormClosed += formClose;
                    borrowForm.setData();
                    borrowForm.Show();
                    break;
            }
        }
    }
}

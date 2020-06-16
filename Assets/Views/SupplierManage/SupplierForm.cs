using Assets.Common.Entity;
using Assets.Views.SupplierManage.Add;
using Assets.Views.SupplierManage.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.SupplierManage
{
    public partial class SupplierForm : Form
    {
        SupplierDao dao = new SupplierDao();
        public const string tag_insert = "insert";
        public const string tag_update = "update";

        public SupplierForm()
        {
            InitializeComponent();
            initData(dao.getSuppliers());
        }

        private void SupplierAdd_Click(object sender, System.EventArgs e)
        {
            SupplierAddForm form = new SupplierAddForm();
            form.FormClosed += childClose;
            this.Tag = tag_insert;
            form.Show();
        }

        private void childClose(object sender, EventArgs e)
        {
            SupplierAddForm form = (SupplierAddForm)sender;
            if (!(bool)form.Tag)
                return;

            Supplier supplier = form.supplier;
            string tag = (string)this.Tag;
            if (tag.Equals(tag_insert))
            {
                dao.addSupplier(supplier);
            }
            else
            {
                dao.update(supplier);
            }
            initData(dao.getSuppliers());
        }

        private void SupplierSearch_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SupplierDisable(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void UpdateSupplier(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
            Supplier su = (Supplier)dataGridView1.CurrentRow.Tag;
            SupplierAddForm form = new SupplierAddForm();
            form.FormClosed += childClose;
            this.Tag = tag_update;
            form.setSupplier(su);
            form.Show();
        }

        private void SupplierDelete(object sender, System.EventArgs e)
        {
            Supplier su = (Supplier)dataGridView1.CurrentRow.Tag;
            if (su == null)
                return;
            dao.deleteSupplier(su.SupplierId);
            initData(dao.getSuppliers());
        }

        private void cellClick(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}

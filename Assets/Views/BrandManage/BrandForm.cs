using Assets.Common.Entity;
using Assets.Views.BrandManage.Add;
using Assets.Views.BrandManage.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.BrandManage
{
    public partial class BrandForm : Form
    {

        BrandDao dao = new BrandDao();

        public BrandForm()
        {
            InitializeComponent();
            initData();
        }

        private void BrandSearch_Click(object sender, EventArgs e)
        {
            dao.test();
        }

        private void BrandAdd_Click(object sender, EventArgs e)
        {
            BrandAdd brandAddForm = new BrandAdd();
            brandAddForm.Show();
            brandAddForm.FormClosed += childClose;
        }

        private void childClose(object sender, EventArgs e)
        {
            BrandAdd ba = (BrandAdd)sender;
            Brand brand = ba.brand;
            dao.add(brand);

        }
    }
}

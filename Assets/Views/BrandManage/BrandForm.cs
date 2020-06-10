using Assets.Common.Entity;
using Assets.Common.Enums;
using Assets.Common.Tools;
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

        public const string tag_insert = "insert";
        public const string tag_update = "update";

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
            this.Tag = tag_insert;
        }

        private void childClose(object sender, EventArgs e)
        {
            BrandAdd ba = (BrandAdd)sender;
            Brand brand = ba.brand;

            string tag =(string) this.Tag;
            if (tag.Equals(tag_insert))
            {
                dao.add(brand);
            }
            else
            {
                dao.update(brand);
            }

            initData();

        }

        private void updateBrand(object sender, EventArgs e)
        {
            Brand brand = (Brand)dataGridView1.CurrentRow.Tag;
            if (brand == null)
            {
                Tool.show("请选择一行");
                return;
            }

            BrandAdd brandAddForm = new BrandAdd();
            brandAddForm.Tag = brand;
            brandAddForm.update(brand);
            brandAddForm.Show();
            brandAddForm.FormClosed += childClose;
            this.Tag = tag_update;    
        }

        private void brandDelete(object sender, EventArgs e)
        {
            Brand brand = (Brand)dataGridView1.CurrentRow.Tag;
            if (brand == null)
            {
                Tool.show("请选择一行");
                return;
            }

            dao.delete(brand);

            initData();
        }

        private void brandDisable(object sender, EventArgs e)
        {
            Brand brand = (Brand)dataGridView1.CurrentRow.Tag;
            if (brand == null)
            {
                Tool.show("请选择一行");
                return;
            }
            BrandState bs = (BrandState)Enum.Parse(typeof(BrandState), brand.BrandState);
            if (bs == BrandState.已启用)
                brand.BrandState = BrandState.已禁用.ToString();
            else
                brand.BrandState = BrandState.已启用.ToString();

            dao.update(brand);

            initData();

        }

        private void cellClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            Brand brand = (Brand)dataGridView1.CurrentRow.Tag;
            if (brand == null)
            {
                return;
            }
            BrandState bs = (BrandState)Enum.Parse(typeof(BrandState), brand.BrandState);
            if (bs == BrandState.已启用)
            {
                button3.Text = "禁用"; 
            }
            else
            {
                button3.Text = "启用";
            }
        }
    }
}

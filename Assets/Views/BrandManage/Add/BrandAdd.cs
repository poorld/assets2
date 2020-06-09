using Assets.Common.Entity;
using Assets.Common.Enums;
using Assets.Common.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Views.BrandManage.Add
{
    public partial class BrandAdd : Form
    {

        public Brand brand;

        public BrandAdd()
        {
            InitializeComponent();
            initData();
        }

        private void canel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(brandName.Text))
                throw new MyException("请输入品牌名称");

            brand = new Brand();

            brand.BrandCode = this.brandCode.Text;
            brand.BrandName = this.brandName.Text;

            if (radioButton1.Checked)
                brand.BrandState = BrandState.已启用.ToString();
            else
                brand.BrandState = BrandState.已禁用.ToString();

            this.Close();
        }
    }
}

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

namespace Assets.Views.AssetsManage
{
    public partial class AssetsInfo : Form
    {
        public AssetsInfo()
        {
            InitializeComponent();
        }

        private void AssetsInfo_Load(object sender, EventArgs e)
        {

        }

        public void setInfo(Property p)
        {
            label6.Text = p.Property_name;
            label7.Text = p.Locale.LocaleName;
            label8.Text = p.Department.DepartmentName;
            label9.Text = p.Brand.BrandName;

            //label5.Text = p.Scrap_way + "说明";

            label10.Text = p.Property_descr;
            label12.Text = p.Scrap_way;
            label13.Text = p.Pc.PcName;
            label14.Text = p.Supplier.SupplierName;
            label15.Text = p.Property_code;
        }
    }
}

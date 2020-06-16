using Assets.Common.Entity;
using Assets.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Views.SupplierManage.Add
{
    public partial class SupplierAddForm : Form
    {

        public Supplier supplier;

        public SupplierAddForm()
        {
            InitializeComponent();
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            //
            if (supplier == null)
                supplier = new Supplier();

            supplier.SupplierName = tbSupplierName.Text;
            supplier.SupplierState = rbEnable.Checked ? rbEnable.Text : rbDisable.Text;
            supplier.SupplierType = rbType1.Checked ? rbType1.Text : rbType2.Checked ? rbType2.Text : rbType3.Text;
            supplier.SupplierContacts = tbConstacts.Text;
            supplier.SupplierPhone = tbPhone.Text;
            supplier.SupplierAddress = tbAddress.Text;
            this.Tag = true;
            this.Close();
        }

        public void setSupplier(Supplier su)
        {
            this.supplier = su;
            tbSupplierName.Text = su.SupplierName;
            rbEnable.Checked = ((SupplierState)Enum.Parse(typeof(SupplierState), su.SupplierState)) == SupplierState.正常 ? true : false;

            rbType1.Checked = ((SupplierType)Enum.Parse(typeof(SupplierType), su.SupplierType)) == SupplierType.生产商 ? true : false;

            rbType2.Checked = ((SupplierType)Enum.Parse(typeof(SupplierType), su.SupplierType)) == SupplierType.代理商 ? true : false;
            //不是12就是3
            rbType3.Checked = rbType1.Checked ? false : rbType2.Checked ? false : true;
            tbConstacts.Text = supplier.SupplierContacts;
            tbPhone.Text = supplier.SupplierPhone;
            tbAddress.Text = supplier.SupplierAddress;
        }
    }
}

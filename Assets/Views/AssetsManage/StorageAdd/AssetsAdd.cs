using Assets.Common.Entity;
using Assets.Views.AssetManage.Dao;
using Assets.Views.AssetsClassManage.Dao;
using Assets.Views.BrandManage.Dao;
using Assets.Views.DepartmentManage.Dao;
using Assets.Views.LocaleManage.Dao;
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

namespace Assets.Views.AssetManage.Add
{
    public partial class AssetsAdd : Form
    {

        LocaleDao localeDao = new LocaleDao();
        SupplierDao supplierDao = new SupplierDao();
        DepartmentDao departmentDao = new DepartmentDao();
        BrandDao brandDao = new BrandDao();
        AssetsClassDao assetsClassDao = new AssetsClassDao();

        AssetsDao assetsDao = new AssetsDao();

        public AssetsAdd()
        {
            InitializeComponent();
        }

        public void AssetAdd_Load(object sender, EventArgs e)
        {
            List<Locale> list = localeDao.getLocales();
            LocaleCB.DataSource = list;
            LocaleCB.DisplayMember = "LocaleName";
            LocaleCB.ValueMember = "LocaleId";

            List<Supplier> list1 = supplierDao.getSuppliers();
            SupplierCB.DataSource = list1;
            SupplierCB.DisplayMember = "SupplierName";
            SupplierCB.ValueMember = "SupplierId";

            List<PropertyClass> list2 = assetsClassDao.getPCList();
            AssetsClassCB.DataSource = list2;
            AssetsClassCB.DisplayMember = "PcName";
            AssetsClassCB.ValueMember = "PcId";

            List<Brand> list3 = brandDao.getBrands();
            BrandCB.DataSource = list3;
            BrandCB.DisplayMember = "BrandName";
            BrandCB.ValueMember = "BrandId";


        }

        private void btnOk(object sender, EventArgs e)
        {
            string assetsName = AssetsName.Text;
            int localeId = Convert.ToInt32(LocaleCB.SelectedValue);
            int SupplierId = Convert.ToInt32(SupplierCB.SelectedValue);
            int AssetsClassId = Convert.ToInt32(AssetsClassCB.SelectedValue);
            int BrandId = Convert.ToInt32(BrandCB.SelectedValue);
            assetsDao.addAssets(assetsName, localeId, SupplierId, AssetsClassId, BrandId);

            this.Close();

        }
    }
}

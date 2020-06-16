using Assets.Common.Dao;
using Assets.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Common.Entity;
using Assets.Common.Tools;
using Assets.Common.Enums;
using Assets.Common.Constant;

namespace Assets.Views.BrandManage.Dao
{
    class BrandDao : CommonDao<Brand>
    {

       
        public List<Brand> getBrands()
        {
            List<Brand>  brands = base.findAllByDataTable();
            return base.findAll();
        }

        public void test()
        {
            //base.findById(100001);
            //base.findAllByDataTable();
            //base.buildInsertSql();
            Brand brand = new Brand();
            brand.BrandId = 111;
            brand.BrandName = "你好吗";
            brand.BrandState = BrandState.已启用.ToString();
            base.update(brand);
            base.delete(111);
        }

        public void addBrand(Brand brand)
        {
            base.insert(brand);
        }

        public void updateBrand(Brand brand)
        {
            base.update(brand);
        }

        public void deleteBrand(Brand brand)
        {
            base.delete(brand.BrandId);
        }

        protected override int initId()
        {
            return IdPrefixConstant.getBrandIdPrefix();
        }
    }
}

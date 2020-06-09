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

        public void add(Brand brand)
        {
            base.insert(brand);
        }
    }
}

using Assets.Common.Constant;
using Assets.Common.Entity;
using Assets.Common.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Views.AssetManage.Dao
{
    class AssetsDao : Common.Dao.CommonDao<Property>
    {

        string paramSql = @"SELECT
			                p.property_id,
			                p.property_code,
			                p.property_state,
			                p.property_name,
			                p.property_date,
			                p.create_date,
			                p.property_descr,
			                p.scrap_way,
			                l.*, s.*, d.*, pc.*, b.*
		                FROM
			                property p
		                LEFT JOIN locale l ON p.locale_id = l.locale_id
		                LEFT JOIN department d ON p.department_id = d.department_id
		                LEFT JOIN supplier s ON p.supplier_id = s.supplier_id
		                LEFT JOIN property_class pc ON p.pc_id = pc.pc_id
		                LEFT JOIN brand b ON p.brand_id = b.brand_id
                        WHERE
   			            p.property_state = ";

        public void addAssets(string assetsName, int localeId, int SupplierId, int AssetsClassId , int BrandId)
        {
            string code = CodePrefixConstant.getPropertyCode();
            int id = this.getLastId() + 1;
            string createDate = DateTime.Now.ToLocalTime().ToString();
            
            string sql = "insert into property(property_id,property_code,property_name,locale_id,supplier_id,pc_id,brand_id,property_state,create_date) values";
            sql += "(@property_id,@property_code,@property_name,@locale_id,@supplier_id,@pc_id,@brand_id,@property_state,@create_date)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@property_id", id));
            parameters.Add(new SqlParameter("@property_code", code));
            parameters.Add(new SqlParameter("@property_name", assetsName));
            parameters.Add(new SqlParameter("@locale_id", localeId));
            parameters.Add(new SqlParameter("@supplier_id", SupplierId));
            parameters.Add(new SqlParameter("@pc_id", AssetsClassId));
            parameters.Add(new SqlParameter("@brand_id", BrandId));
            parameters.Add(new SqlParameter("@property_state", (int)PropertyState.未使用));
            parameters.Add(new SqlParameter("@create_date", createDate));

            this.executeSql(sql, parameters);
        }

        

        public List<Property> getAssets(string sql)
        {
            //string sql = @"SELECT
			         //       p.property_id,
			         //       p.property_code,
			         //       p.property_state,
			         //       p.property_name,
			         //       p.property_date,
			         //       p.create_date,
			         //       p.property_descr,
			         //       p.scrap_way,
			         //       l.*, s.*, d.*, pc.*, b.*
		          //      FROM
			         //       property p
		          //      LEFT JOIN locale l ON p.locale_id = l.locale_id
		          //      LEFT JOIN department d ON p.department_id = d.department_id
		          //      LEFT JOIN supplier s ON p.supplier_id = s.supplier_id
		          //      LEFT JOIN property_class pc ON p.pc_id = pc.pc_id
		          //      LEFT JOIN brand b ON p.brand_id = b.brand_id";

            string tableName = "tb";
            DataSet ds = this.executeReaderSql(sql, tableName);
            DataTable dt = ds.Tables[tableName];

            List<Property> list = new List<Property>();
            // 行
            foreach (DataRow dataRow in dt.Rows)
            {
                Property p = new Property();
                p.Property_id = Convert.ToInt32(dataRow["property_id"]);
                p.Property_code = dataRow["property_code"].ToString();
                p.Property_state = Enum.Parse(typeof(PropertyState), dataRow["property_state"].ToString()).ToString();
                p.Property_name = dataRow["property_name"].ToString();
                p.Property_date = dataRow["property_date"].ToString(); 
                p.Create_date = dataRow["create_date"].ToString();
                p.Property_descr = dataRow["property_descr"].ToString();
                string val = dataRow["scrap_way"].ToString();
                p.Scrap_way = !string.IsNullOrEmpty(val) ? Enum.Parse(typeof(ScrapWay), val).ToString() : null;


                Locale l = new Locale();
                l.LocaleId = Convert.ToInt32(dataRow["locale_id"]);
                l.LocaleName = dataRow["property_name"].ToString();
                l.LocaleType = Enum.Parse(typeof(LocaleType), dataRow["locale_type"].ToString()).ToString();
                l.LocaleState = Enum.Parse(typeof(LocaleState), dataRow["locale_state"].ToString()).ToString();
                l.LocaleExplain = dataRow["locale_explain"].ToString();
                p.Locale = l;

                Supplier s = new Supplier();
                s.SupplierId = Convert.ToInt32(dataRow["supplier_id"]);
                s.SupplierName = dataRow["supplier_name"].ToString();
                s.SupplierContacts = dataRow["supplier_contacts"].ToString();
                s.SupplierState = Enum.Parse(typeof(SupplierState), dataRow["supplier_state"].ToString()).ToString();
                s.SupplierType = Enum.Parse(typeof(SupplierType), dataRow["supplier_type"].ToString()).ToString();
                s.SupplierPhone = dataRow["supplier_phone"].ToString();
                s.SupplierAddress = dataRow["supplier_address"].ToString();
                p.Supplier = s;

                Department d = new Department();
                string id = dataRow["department_id"].ToString();
                if (!string.IsNullOrEmpty(id))
                {
                    d.DepartmentId = Convert.ToInt32(dataRow["department_id"]);
                }
                d.DepartmentName = dataRow["department_name"].ToString();
                d.DepartmentCode = dataRow["department_code"].ToString();
                //d.DepartmentState = Enum.Parse(typeof(), dataRow["department_state"].ToString()).ToString();
                p.Department = d;

                PropertyClass pc = new PropertyClass();
                pc.PcId = Convert.ToInt32(dataRow["pc_id"]);
                pc.PcName = dataRow["pc_name"].ToString();
                pc.PcCode = dataRow["pc_code"].ToString();
                pc.PcState = Enum.Parse(typeof(PCState), dataRow["pc_state"].ToString()).ToString();
                p.Pc = pc;

                Brand b = new Brand();
                b.BrandId = Convert.ToInt32(dataRow["brand_id"]);
                b.BrandCode = dataRow["brand_code"].ToString();
                b.BrandName = dataRow["brand_name"].ToString();
                b.BrandState = Enum.Parse(typeof(BrandState), dataRow["brand_state"].ToString()).ToString();
                p.Brand = b;

                list.Add(p);
            }


            return list;
        }

        public void assetsBorrow(int property_id, int department_id, string property_descr)
        {
            string sql = @"update property
                            set
	                            department_id = @department_id,
	                            property_descr = @property_descr,
                                property_state = @property_state
                            where
	                            property_id = @property_id";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@department_id", department_id));
            parameters.Add(new SqlParameter("@property_descr", property_descr));
            parameters.Add(new SqlParameter("@property_id", property_id));
            parameters.Add(new SqlParameter("@property_state", (int)PropertyState.已借用));
            this.executeSql(sql, parameters);

        }

        public void assetsReturn(int property_id)
        {
            string sql = @"update property
                            set
                                property_state = @property_state
                            where
	                            property_id = @property_id";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@property_id", property_id));
            parameters.Add(new SqlParameter("@property_state", (int)PropertyState.已归还));
            this.executeSql(sql, parameters);

        }

        public void assetsRetirement(int property_id, ScrapWay sw, string desc)
        {
            string sql = @"update property
                            set
                                property_state = @property_state,
                                property_descr = @property_descr,
                                scrap_way = @scrap_way
                            where
	                            property_id = @property_id";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@property_id", property_id));
            parameters.Add(new SqlParameter("@property_state", (int)PropertyState.已报废));
            parameters.Add(new SqlParameter("@scrap_way", (int)sw));
            parameters.Add(new SqlParameter("@property_descr", desc));
            this.executeSql(sql, parameters);
        }


        public List<Property> storageList()
        {
            string sql = paramSql;
            sql += (int)PropertyState.未使用;
            return getAssets(sql);
        }

        public List<Property> borrowList()
        {
            string sql = paramSql;
            //sql = String.Format(sql, (int)PropertyState.已借用);
            sql += (int)PropertyState.已借用;
            return getAssets(sql);
        }

        public List<Property> retirementList()
        {
            string sql = paramSql;
            //sql = String.Format(sql, (int)PropertyState.已报废);
            sql += (int)PropertyState.已报废;
            return getAssets(sql);
        }

        public List<Property> returnList()
        {
            string sql = paramSql;
            //sql = String.Format(sql, (int)PropertyState.已归还);
            sql += (int)PropertyState.已归还;
            return getAssets(sql);
        }

        protected override int initId()
        {
            return IdPrefixConstant.getPropertyIdPrefix();
        }
    }
}

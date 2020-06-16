using Assets.Common.Constant;
using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Views.SupplierManage.Dao
{
    public class SupplierDao : Common.Dao.CommonDao<Supplier>
    {
        public List<Supplier> getSuppliers()
        {
            return base.findAll();
        }

        public void addSupplier(Supplier su)
        {
            base.insert(su);
        }

        public void deleteSupplier(int id)
        {
            base.delete(id);
        }

        public void updateSupplier(Supplier su)
        {
            base.update(su);
        }

        protected override int initId()
        {
            return IdPrefixConstant.getSupplierIdPrefix();
        }
    }
}

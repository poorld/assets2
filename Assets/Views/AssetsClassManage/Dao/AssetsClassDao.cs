using Assets.Common.Constant;
using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Views.AssetsClassManage.Dao
{
    class AssetsClassDao : Common.Dao.CommonDao<PropertyClass>
    {

        public void addPropertyClass(PropertyClass pc)
        {
            base.insert(pc);
        }

        public void deletePC(int id)
        {
            base.delete(id);
        }

        public void updatePC(PropertyClass pc)
        {
            base.update(pc);
        }

        public List<PropertyClass> getPCList()
        {
            return base.findAll();
        }

        protected override int initId()
        {
            return IdPrefixConstant.getPropertyClassIdPrefix();
        }
    }
}

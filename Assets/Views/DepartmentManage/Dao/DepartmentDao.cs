using Assets.Common.Constant;
using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Views.DepartmentManage.Dao
{
    class DepartmentDao : Common.Dao.CommonDao<Department>
    {

        public void addDepartment(Department d)
        {
            base.insert(d);
        }


        public void delDepartment(int id)
        {
            base.delete(id);
        }

        public void updateDepartment(Department d)
        {
            base.update(d);
        }

        public List<Department> getDepartments()
        {
            return base.findAll();
        }

        protected override int initId()
        {
            return IdPrefixConstant.getDepartmentIdPrefix();
        }
    }
}

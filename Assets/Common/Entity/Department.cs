using Assets.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    /// <summary>
    /// 部门
    /// </summary>
    public class Department : TableEntity
    {
        private int departmentId;
        [TableField("department_id", "int", true)]
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        private string departmentCode;
        [TableField("department_code", "nchar(10)")]
        public string DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }

        private string departmentState;
        //[TableField("department_state", "int")]
        public string DepartmentState
        {
            get { return departmentState; }
            set { departmentState = value; }
        }

        private string departmentName;
        [TableField("department_name", "nvarchar(50)")]
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

    }
}

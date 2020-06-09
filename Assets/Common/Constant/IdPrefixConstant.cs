using Assets.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Constant
{
    /// <summary>
    /// ID前缀
    /// </summary>
    class IdPrefixConstant
    {
        /// <summary>
        /// 资产编号前缀
        /// </summary>
        public const int propertyCodePrefix = 1;

        /// <summary>
        /// 品牌编号前缀
        /// </summary>
        public const int brandCodePrefix = 2;


        /// <summary>
        /// 部门编号前缀
        /// </summary>
        public const int departmentCodePrefix = 3;


        /// <summary>
        /// 资产类别编号前缀
        /// </summary>
        public const int propertyClassCodePrefix = 4;

        public static int getBrandIdPrefix()
        {
            return brandCodePrefix;
        }

        public static int getDepartmentIdPrefix()
        {
            return departmentCodePrefix;
        }

        public static int getPropertyIdPrefix()
        {
            return propertyCodePrefix;
        }

        public static int getPropertyClassIdPrefix()
        {
            return propertyClassCodePrefix;
        }
    }
}

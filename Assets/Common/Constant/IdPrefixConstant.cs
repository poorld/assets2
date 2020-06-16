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
        public const int propertyIdPrefix = 1;

        /// <summary>
        /// 品牌编号前缀
        /// </summary>
        public const int brandIdPrefix = 2;


        /// <summary>
        /// 部门编号前缀
        /// </summary>
        public const int departmentIdPrefix = 3;


        /// <summary>
        /// 资产类别编号前缀
        /// </summary>
        public const int propertyClassIdPrefix = 4;

        /// <summary>
        /// 存放地点
        /// </summary>
        public const int localeIdPrefix = 5;

        /// <summary>
        /// 供应商
        /// </summary>
        public const int supplierIdPrefix = 6;

        public static int getBrandIdPrefix()
        {
            return getInitId(brandIdPrefix);
        }

        public static int getDepartmentIdPrefix()
        {
            return getInitId(departmentIdPrefix);
        }

        public static int getPropertyIdPrefix()
        {
            return getInitId(propertyIdPrefix);
        }

        public static int getPropertyClassIdPrefix()
        {
            return getInitId(propertyClassIdPrefix);
        }

        public static int getLocaleIdPrefix()
        {
            return getInitId(localeIdPrefix);
        }

        public static int getSupplierIdPrefix()
        {
            return getInitId(supplierIdPrefix);
        }

        public static int getInitId(int prefix)
        {
            return Convert.ToInt32(prefix + "0000");
        }
    }
}

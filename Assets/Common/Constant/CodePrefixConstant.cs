using Assets.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Constant
{
    /// <summary>
    /// 编号前缀
    /// </summary>
    class CodePrefixConstant
    {
        /// <summary>
        /// 品牌编号前缀
        /// </summary>
        public const string brandCodePrefix = "bc";


        /// <summary>
        /// 部门编号前缀
        /// </summary>
        public const string departmentCodePrefix = "dc";

        /// <summary>
        /// 资产编号前缀
        /// </summary>
        public const string propertyCodePrefix = "pr";

        /// <summary>
        /// 资产类别编号前缀
        /// </summary>
        public const string propertyClassCodePrefix = "pc";

        /// <summary>
        /// 存放地点
        /// </summary>
        public const string localeCodePrefix = "lc";

        public static string getBrandCode()
        {
            return brandCodePrefix + Tool.randomNumber(8);
        }

        public static string getDepartmentCode()
        {
            return departmentCodePrefix + Tool.randomNumber(8);
        }

        public static string getPropertyCode()
        {
            return propertyCodePrefix + Tool.randomNumber(8);
        }

        public static string getPropertyClassCode()
        {
            return propertyClassCodePrefix + Tool.randomNumber(8);
        }

        public static string getLocaleCode()
        {
            return localeCodePrefix + Tool.randomNumber(8);
        }
    }
}

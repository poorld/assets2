using Assets.Common.Attributes;
using Assets.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    /// <summary>
    /// 存放地点
    /// </summary>
    public class Locale : TableEntity
    {
        private int localeId;
        [TableField("locale_id", "int", true)]
        public int LocaleId
        {
            get { return localeId; }
            set { localeId = value; }
        }
        private string localeName;
        [TableField("locale_name", "nvarchar(50)")]
        public string LocaleName
        {
            get { return localeName; }
            set { localeName = value; }
        }
        private string localeType;
        [TableField("locale_type", "int")]
        [EnumField(typeof(LocaleType))]
        public string LocaleType
        {
            get { return localeType; }
            set { localeType = value; }
        }
        private string localeState;
        [TableField("locale_state", "int")]
        [EnumField(typeof(LocaleState))]
        public string LocaleState
        {
            get { return localeState; }
            set { localeState = value; }
        }
        private string localeExplain;
        [TableField("locale_explain", "nvarchar(50)")]
        public string LocaleExplain
        {
            get { return localeExplain; }
            set { localeExplain = value; }
        }
    }
}

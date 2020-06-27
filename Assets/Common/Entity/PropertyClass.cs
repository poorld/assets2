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
    /// 资产类别
    /// </summary>
    [TableAlias("property_class")]
    public class PropertyClass : TableEntity
    {
        private int pcId;
        [TableField("pc_id", "int", true)]
        public int PcId
        {
            get { return pcId; }
            set { pcId = value; }
        }
        private string pcCode;
        [TableField("pc_code", "nchar(10)")]
        public string PcCode
        {
            get { return pcCode; }
            set { pcCode = value; }
        }
        private string pcName;
        [TableField("pc_name", "nvarchar(50)")]
        public string PcName { get; set; }

        private string pcState;
        [TableField("pc_state", "int", "正常")]
        [EnumField(typeof(PCState))]
        public string PcState
        {
            get { return pcState; }
            set { pcState = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Attributes
{
    /// <summary>
    /// 一个自定义特性：实体类属性与数据库表字段关联
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field |
                            System.AttributeTargets.Property
                            ,AllowMultiple = false)  // Multiuse attribute.  
    ]
    class TableFieldAttribute : Attribute
    {
        private string fieldName;
        private string fieldType;
        private bool primaryKey;
        private object defaultValue;

        public TableFieldAttribute(string fieldName, string fieldType) : this(fieldName, fieldType, false)
        {
        }

        public TableFieldAttribute(string fieldName, string fieldType, bool primaryKey) : this(fieldName, fieldType, primaryKey, null)
        {
        }

        public TableFieldAttribute(string fieldName, string fieldType, object defaultValue) : this(fieldName, fieldType, false, defaultValue)
        {
        }

        public TableFieldAttribute(string fieldName, string fieldType, bool primaryKey, object defaultValue)
        {
            this.FieldName = fieldName;
            this.FieldType = fieldType;
            this.primaryKey = primaryKey;
            this.defaultValue = defaultValue;
        }
        

        public string FieldName
        {
            get
            {
                return fieldName;
            }

            set
            {
                fieldName = value;
            }
        }

        public string FieldType
        {
            get
            {
                return fieldType;
            }

            set
            {
                fieldType = value;
            }
        }

        public bool PrimaryKey
        {
            get
            {
                return primaryKey;
            }

            set
            {
                primaryKey = value;
            }
        }

        public object DefaultValue
        {
            get
            {
                return defaultValue;
            }

            set
            {
                defaultValue = value;
            }
        }
    }
}

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
    /// 供应商
    /// </summary>
    public class Supplier : TableEntity
    {
        private int supplierId;

        [TableField("supplier_id", "int", true)]
        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        private string supplierContacts;
        [TableField("supplier_contacts", "nvarchar(50)")]
        public string SupplierContacts
        {
            get { return supplierContacts; }
            set { supplierContacts = value; }
        }
        private string supplierType;
        [TableField("supplier_type", "int")]
        [EnumField(typeof(SupplierType))]
        public string SupplierType
        {
            get { return supplierType; }
            set { supplierType = value; }
        }
        private string supplierState;
        [TableField("supplier_state", "int")]
        [EnumField(typeof(SupplierState))]
        public string SupplierState
        {
            get { return supplierState; }
            set { supplierState = value; }
        }
        private string supplierName;
        [TableField("supplier_name", "nvarchar(50)")]
        public string SupplierName { get; set; }

        private string supplierPhone;
        [TableField("supplier_phone", "char(11)")]
        public string SupplierPhone
        {
            get { return supplierPhone; }
            set { supplierPhone = value; }
        }
        private string supplierAddress;
        [TableField("supplier_address", "nvarchar(50)")]
        public string SupplierAddress
        {
            get { return supplierAddress; }
            set { supplierAddress = value; }
        }

    }
}

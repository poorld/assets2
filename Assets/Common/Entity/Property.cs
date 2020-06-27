using Assets.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    [TableAlias("property")]
    class Property : TableEntity
    {
        private int property_id;
        [TableField("property_id", "int", true)]
        public int Property_id
        {
            get { return property_id; }
            set { property_id = value; }
        }

        public string Property_code { get; set; }


        public string Property_name { get; set; }


        private string property_date;
        public string Property_date
        {
            get { return property_date; }
            set { property_date = value; }
        }

        private string create_date;
        public string Create_date
        {
            get { return create_date; }
            set { create_date = value; }
        }

        private string property_descr;
        public string Property_descr
        {
            get { return property_descr; }
            set { property_descr = value; }
        }

        private string property_state;
        public string Property_state
        {
            get { return property_state; }
            set { property_state = value; }
        }

        private string scrap_way;
        public string Scrap_way
        {
            get { return scrap_way; }
            set { scrap_way = value; }
        }


        public Locale Locale { get; set; }


        public Supplier Supplier { set; get; }


        public Department Department { set; get; }


        public PropertyClass Pc { set; get; }


        public Brand Brand { set; get; }



    }
}

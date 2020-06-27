using Assets.Common.Enums;
using Assets.Views.AssetManage.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Views.AssetsManage.RetirementAdd
{
    public partial class RetirementAdd : Form
    {
        AssetsDao dao = new AssetsDao();

        public RetirementAdd()
        {
            InitializeComponent();
        }

        private void RetirementAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dao.returnList();
            comboBox1.DisplayMember = "Property_name";
            comboBox1.ValueMember = "Property_id";
        }

        private void btnOk(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedValue.ToString();
            ScrapWay sw;
            string text = string.Empty;
            if (radioButton1.Checked)
            {
                text = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                text = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                text = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                text = radioButton4.Text;
            }
            sw = (ScrapWay)Enum.Parse(typeof(ScrapWay), text);

            string desc = textBox1.Text;
            dao.assetsRetirement(Convert.ToInt32(id), sw, desc);

            this.Close();
        }
    }
}

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

namespace Assets.Views.AssetsManage.ReturnAdd
{

    public partial class ReturnAdd : Form
    {
        AssetsDao dao = new AssetsDao();

        public ReturnAdd()
        {
            InitializeComponent();
        }

        private void ReturnAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dao.borrowList();
            comboBox1.DisplayMember = "Property_name";
            comboBox1.ValueMember = "Property_id";
        }

        private void btnOk(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedValue.ToString();
            dao.assetsReturn(Convert.ToInt32(id));
            this.Close();
        }
    }
}

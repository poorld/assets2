using Assets.Common.Entity;
using Assets.Views.AssetsClassManage.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Views.AssetsClassManage.RetirementAdd
{
    public partial class PCRetirement : Form
    {
        AssetsClassDao dao = new AssetsClassDao();

        public PCRetirement()
        {
            InitializeComponent();
        }

        private void PCRetirementLoad_Complete(object sender, EventArgs e)
        {
            List<PropertyClass> list = dao.normalPcList();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "PcName";//显示的文本
            comboBox1.ValueMember = "PcId";//对应的值
        }

        private void btnOk(object sender, EventArgs e)
        {
            //获取显示文本和值
            //MessageBox.Show("您选择的是" + comboBox1.GetItemText(comboBox1.Items[comboBox1.SelectedIndex]) + "|" + comboBox1.SelectedValue);
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            this.Tag = id;
            this.Close();
        }
    }
}

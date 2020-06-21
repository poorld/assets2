using Assets.Common.Entity;
using Assets.Views.AssetsClassManage.Add;
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

namespace Assets.AssetsClass
{
    public partial class AssetsClassForm : Form
    {
        AssetsClassDao dao = new AssetsClassDao();
        public const string tag_insert = "insert";
        public const string tag_update = "update";

        public AssetsClassForm()
        {
            InitializeComponent();
        }

        private void AssetsClassManager_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            List< PropertyClass> list =  dao.getPCList();
            dataGridView1.Rows.Clear();
            foreach (PropertyClass pc in list)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Tag = pc;
                dataGridView1.Rows[index].Cells[0].Value = pc.PcId;
                dataGridView1.Rows[index].Cells[1].Value = pc.PcCode;
                dataGridView1.Rows[index].Cells[2].Value = pc.PcName;
                dataGridView1.Rows[index].Cells[3].Value = pc.PcState;
            }
        }

        private void pcAddClick(object sender, EventArgs e)
        {
            AssetsClassAddForm form = new AssetsClassAddForm();
            form.FormClosed += pcAddClose;
            this.Tag = tag_insert;
            form.Show();
        }

        private void pcAddClose(object sender, EventArgs e)
        {
            AssetsClassAddForm form = (AssetsClassAddForm)sender;

        }
    }
}

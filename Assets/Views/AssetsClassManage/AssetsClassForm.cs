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
            form.Tag = false;
            form.Show();
        }

        private void pcAddClose(object sender, EventArgs e)
        {
            AssetsClassAddForm form = (AssetsClassAddForm)sender;
            if (!(bool)form.Tag)
            {
                return;
            }
            string tag = (string)this.Tag;
            if (tag.Equals(tag_insert))
            {
                PropertyClass pc = form.pc;
                pc.PcId = dao.getLastId() + 1;
                dao.addPropertyClass(pc);
            }
            else
            {
                dao.updatePC(form.pc);
            }

            initData();

        }

        private void pcUpdate(object sender, EventArgs e)
        {

             PropertyClass pc = (PropertyClass)dataGridView1.CurrentRow.Tag;
            if(pc == null)
                return;

            AssetsClassAddForm form = new AssetsClassAddForm();
            form.FormClosed += pcAddClose;
            this.Tag = tag_update;
            form.setPC(pc);
            form.Show();
        }
    }
}

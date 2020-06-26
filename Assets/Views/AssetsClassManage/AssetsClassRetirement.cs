using Assets.Common.Entity;
using Assets.Common.Enums;
using Assets.Views.AssetsClassManage.Dao;
using Assets.Views.AssetsClassManage.RetirementAdd;
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
    public partial class AssetsClassRetirement : Form
    {
        AssetsClassDao dao = new AssetsClassDao();
        public const string tag_insert = "insert";
        public const string tag_update = "update";

        public AssetsClassRetirement()
        {
            InitializeComponent();
        }

        private void AssetsClassManager_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            
            List<PropertyClass> list = dao.retirementPcList();
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

            PCRetirement form = new PCRetirement();
            form.Tag = null;
            form.Show();
            form.FormClosed += pcAddClose;


            //this.Tag = tag_insert;
            //form.Tag = false;
            //form.Show();
        }

        private void pcAddClose(object sender, EventArgs e)
        {
            PCRetirement form = (PCRetirement)sender;
            if(form.Tag != null)
            {
                dao.setRetirement((int)form.Tag);
            }

            initData();
            //AssetsClassAddForm form = (AssetsClassAddForm)sender;
            //if (!(bool)form.Tag)
            //{
            //    return;
            //}
            //string tag = (string)this.Tag;
            //if (tag.Equals(tag_insert))
            //{
            //    PropertyClass pc = form.pc;
            //    pc.PcId = dao.getLastId() + 1;
            //    dao.addPropertyClass(pc);
            //}
            //else
            //{
            //    dao.updatePC(form.pc);
            //}

            //initData();

        }

        private void pcDelete(object sender, EventArgs e)
        {

            PropertyClass pc = (PropertyClass)dataGridView1.CurrentRow.Tag;
            if (pc == null)
                return;

            dao.deletePC(pc.PcId);
            initData();
        }
    }
}

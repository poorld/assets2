using Assets.Common.Entity;
using Assets.Views.AssetManage.Add;
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

namespace Assets.AssetManage
{
    public partial class AssetsStorage : Form
    {
        //资产入库
        public const int Storage = 1;
        //资产借用
        public const int Borrow = 2;
        //资产报废
        public const int Retirement = 3;
        //资产归还
        public const int Return = 4;

        private int type;

        AssetsDao dao = new AssetsDao();

        public AssetsStorage()
        {
            InitializeComponent();
        }

        public void setType(int type)
        {
            this.type = type;
            switch (type)
            {
                case Storage:
                    button2.Text = "修改";
                    break;
                case Borrow:
                    button2.Text = "归还";
                    break;
                case Retirement:
                    button2.Text = "借用";
                    break;
                case Return:
                    button2.Text = "删除";
                    break;
            }

            loadData();
        }

        public void loadData()
        {
            List<Property> list = dao.getAssets();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void AssetsStorage_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridView1.Rows[e.RowIndex].DataBoundItem != null) &&
                (dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                string[] names = dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Split('.');
                object obj = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                for (int i = 0; i < names.Count(); ++i)
                {
                    try
                    {
                        var result = obj.GetType().GetProperty(names[i]).GetValue(obj, null);
                        obj = result;
                        e.Value = result.ToString();
                    }
                    catch (Exception)
                    {
                        return;
                        throw;
                    }
                }
            }
        }

        private void addClick(object sender, EventArgs e)
        {
            AssetsAdd form = new AssetsAdd();
            form.Show();
        }
    }
}

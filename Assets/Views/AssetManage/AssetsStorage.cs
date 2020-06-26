using Assets.Views.AssetManage.Add;
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
        public AssetsStorage()
        {
            InitializeComponent();
        }

        private void AssetsStorage_Load(object sender, EventArgs e)
        {

        }

        private void addClick(object sender, EventArgs e)
        {
            AssetsAdd form = new AssetsAdd();
            form.Show();
        }
    }
}

using Assets.Common.Constant;
using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Views.AssetsClassManage.Add
{
    public partial class AssetsClassAddForm : Form
    {

        public PropertyClass pc;

        public AssetsClassAddForm()
        {
            InitializeComponent();
        }


        private void AssetsClassAddManager_Load(object sender, EventArgs e)
        {
            this.tbPCCode.Text = CodePrefixConstant.getPropertyClassCode();
        }

        public void setPC(PropertyClass pc)
        {
            this.pc = pc;
            tbPCCode.Text = pc.PcCode;
            tbPCName.Text = pc.PcName;
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            if (pc == null)
                pc = new PropertyClass();

            pc.PcCode = tbPCCode.Text;
            pc.PcName = tbPCName.Text;
            this.Tag = true;
            this.Close();
        }

        
    }
}

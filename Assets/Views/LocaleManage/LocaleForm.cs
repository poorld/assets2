using Assets.Common.Entity;
using Assets.Common.Enums;
using Assets.Common.Tools;
using Assets.Views.LocaleManage.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assets.Views.LocaleManage;
using Assets.Views.LocaleManage.Dao;

namespace Assets.PlaceManage
{
    public partial class PlaceForm : Form
    {

        LocaleDao dao = new LocaleDao();
        public const string tag_insert = "insert";
        public const string tag_update = "update";

        public PlaceForm()
        {
            InitializeComponent();
            initData();
        }

        private void localeDelete(object sender, EventArgs e)
        {
            Locale locale = (Locale)dataGridView1.CurrentRow.Tag;
            if (locale == null)
            {
                return;
            }
            dao.deleteLocale(locale.LocaleId);
            initData();
        }

        private void cellClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            Locale locale = (Locale)dataGridView1.CurrentRow.Tag;
            if (locale == null)
            {
                return;
            }
            LocaleState ls = (LocaleState)Enum.Parse(typeof(LocaleState), locale.LocaleState);
            if (ls == LocaleState.正常)
            {
                button3.Text = "设为报废";
            }
            else
            {
                button3.Text = "设为正常";
            }
        }
        private void updateLocale(object sender, EventArgs e)
        {
            //if (dataGridView1.CurrentRow == null)
            //{
            //    Tool.show("请选择一行");
            //    return;
            //}

            Locale locale = (Locale)dataGridView1.CurrentRow.Tag;
            if (locale == null)
            {
                Tool.show("请选择一行");
                return;
            }

            LocaleAdd form = new LocaleAdd();
            form.setLocale(locale);
            //标记
            form.Tag = locale;
            form.FormClosed += childClose;
            this.Tag = tag_update;
            form.Show();
        }

        private void disableLocale(object sender, EventArgs e)
        {
            Locale locale = (Locale)dataGridView1.CurrentRow.Tag;
            if (locale == null)
            {
                Tool.show("请选择一行");
                return;
            }
            LocaleState bs = (LocaleState)Enum.Parse(typeof(LocaleState), locale.LocaleState);
            if (bs == LocaleState.正常)
                locale.LocaleState = LocaleState.报废.ToString();
            else
                locale.LocaleState = LocaleState.正常.ToString();

            dao.updateLocale(locale);

            initData();
        }
        private void Search_Click(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            LocaleAdd from = new LocaleAdd();
            from.FormClosed += childClose;
            from.Show();
            this.Tag = tag_insert;
        }
        private void childClose(object sender, EventArgs e)
        {
            LocaleAdd form = (LocaleAdd)sender;
            Locale lo = form.locale;
            string tag =(string) this.Tag;
            if (tag.Equals(tag_insert))
            {
                dao.addLocale(lo);
            }
            else
            {
                dao.updateLocale(lo);
            }
            initData();
        }
    }
}

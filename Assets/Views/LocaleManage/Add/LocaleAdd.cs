using Assets.Common.Entity;
using Assets.Common.Enums;
using Assets.Views.LocaleManage.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Views.LocaleManage.Add
{
    public partial class LocaleAdd : Form
    {
        //LocaleDao dao = new LocaleDao();

        public Locale locale;

        public LocaleAdd()
        {
            InitializeComponent();
            initRadioButton();

        }

        public void setLocale(Locale lo)
        {
            localeName.Text = lo.LocaleName;
            LocaleState state = (LocaleState)Enum.Parse(typeof(LocaleState), lo.LocaleState);
            if (state == LocaleState.正常)
            {
                rbEnable.Select();
            }
            else
            {
                rbDisable.Select();
            }

            LocaleType type = (LocaleType)Enum.Parse(typeof(LocaleType), lo.LocaleType);
            if (type == LocaleType.固定资产)
            {
                rbFixed.Select();
            }
            else
            {
                rbConsumables.Select();
            }

            tbExplain.Text = lo.LocaleExplain;
        }

        private void confirmClick(object sender, EventArgs e)
        {
            //从LocaleForm带过来的
            locale = (Locale)this.Tag;
            if (locale == null)
                locale = new Locale();

            //string code = localeCode.Text;
            string name = localeName.Text;
            string state = string.Empty;
            string type = string.Empty;
            string explain = tbExplain.Text;

            state = rbEnable.Checked ? rbEnable.Text : rbDisable.Text;

            type = rbFixed.Checked ? rbFixed.Text : rbConsumables.Text;

            if (string.IsNullOrEmpty(name))
                return;
            if (string.IsNullOrEmpty(explain))
                return;

            locale.LocaleName = name;
            locale.LocaleState = state;
            locale.LocaleType = type;
            locale.LocaleExplain = explain;

            //dao.addLocale(locale);

            this.Close();
        }
    }
}

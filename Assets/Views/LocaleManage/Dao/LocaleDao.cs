using Assets.Common.Constant;
using Assets.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Views.LocaleManage.Dao
{
    class LocaleDao : Common.Dao.CommonDao<Locale>
    {

        public List<Locale> getLocales()
        {
            return base.findAll();
        }

        public void addLocale(Locale locale)
        {
            base.insert(locale);
        }


        public void deleteLocale(int id)
        {
            base.delete(id);
        }

        public void updateLocale(Locale lo)
        {
            base.update(lo);
        }


        protected override int initId()
        {
            return IdPrefixConstant.getInitId(IdPrefixConstant.getLocaleIdPrefix());
        }
    }
}

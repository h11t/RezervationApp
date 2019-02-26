using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Bll.Abstract
{
  public  interface IKullaniciService
    {
        List<Kullanici> GetList(Expression<Func<Kullanici, bool>> filter = null);
        Kullanici Get(Expression<Func<Kullanici, bool>> filter);
        bool Add(Kullanici data);
        bool Update(Kullanici data);
        bool Inactivate(int id);
    }
}

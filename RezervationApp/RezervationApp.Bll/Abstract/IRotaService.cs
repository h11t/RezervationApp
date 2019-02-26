using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Bll.Abstract
{
  public  interface IRotaService
    {
        bool Add(Rota entity);
        bool Update(Rota entity);
        bool Delete(int id);
        List<Rota> GetList(Expression<Func<Rota, bool>> filter = null);
        Rota Get(Expression<Func<Rota, bool>> filter);
    }
}

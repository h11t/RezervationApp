using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Bll.Abstract
{
   public interface IUcusService
    {
        List<Ucus> GetList(Expression<Func<Ucus, bool>> filter = null);
        Ucus Get(Expression<Func<Ucus, bool>> filter);
        bool Add(Ucus data);
        bool Update(Ucus data);
    }
}

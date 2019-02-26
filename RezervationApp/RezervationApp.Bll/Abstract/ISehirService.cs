using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Bll.Abstract
{
   public interface ISehirService
    {
        List<Sehir> GetList(Expression<Func<Sehir,bool>> filter=null);
        Sehir Get(Expression<Func<Sehir, bool>> filter);
        bool Add(Sehir data);
        bool Update(Sehir data);
    }
}

using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Bll.Abstract
{
   public interface IBiletService
    {
        List<Bilet> GetList(Expression<Func<Bilet, bool>> filter = null);
        Bilet Get(Expression<Func<Bilet, bool>> filter);
        bool Add(Bilet data);
        List<Bilet> GetByDate(DateTime date);
    }
}

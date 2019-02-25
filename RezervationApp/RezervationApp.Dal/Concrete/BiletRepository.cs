using RezervationApp.Core.Data.EntityFramework;
using RezervationApp.Dal.Abstract;
using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RezervationApp.Dal.Concrete
{
    public class BiletRepository : EntityBaseRepository<Bilet, int, RezervationContext>, IBiletRepository
    {
        public List<Bilet> GetByDate(DateTime date)
        {
            List<Bilet> list;
            using (RezervationContext context=new RezervationContext())
            {
              list=  context.Bilet.Where(x => x.InsertDate == date).ToList();
            }
            return list;
        }
    }
}

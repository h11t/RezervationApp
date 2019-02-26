using RezervationApp.Bll.Abstract;
using RezervationApp.Dal.Abstract;
using RezervationApp.Dal.Concrete;
using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Bll.Concrete
{
    public class SehirManager :  ISehirService
    {
        ISehirRepository repository;
        public SehirManager(ISehirRepository _repository)
        {
            repository = _repository;
        }

        public bool Add(Sehir data)
        {
           return repository.Add(data);
        }

        public Sehir Get(Expression<Func<Sehir, bool>> filter)
        {
            return repository.Get(filter);
        }

        public List<Sehir> GetList(Expression<Func<Sehir, bool>> filter = null)
        {
            return repository.GetList(filter);
        }

        public bool Update(Sehir data)
        {
            return repository.Update(data);
        }
    }
}

using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Core.Data
{
    public interface IRepository<TEntity,TId> where TEntity:IEntity,new()
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TId id);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
    }
}

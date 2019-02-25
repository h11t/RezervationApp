using Microsoft.EntityFrameworkCore;
using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RezervationApp.Core.Data.EntityFramework
{
    public class EntityBaseRepository<TEntity, TId, TContext> : IRepository<TEntity, TId> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public bool Add(TEntity entity)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var addedData = context.Entry<TEntity>(entity);
                    addedData.State = EntityState.Added;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(TId id)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var data = context.Set<TEntity>().Find(id);
                    var deletedData = context.Entry<TEntity>(data);
                    deletedData.State = EntityState.Deleted;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            TEntity data;
            using (TContext context = new TContext())
            {
                data = context.Set<TEntity>().FirstOrDefault(filter);
            }
            return data;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {

            List<TEntity> list;
            using (TContext context = new TContext())
            {
                if (filter == null)
                {
                    list = context.Set<TEntity>().ToList();
                }
                else
                {
                    list = context.Set<TEntity>().Where(filter).ToList();
                }
            }
            return list;
        }

        public bool Update(TEntity entity)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var modifiedData = context.Entry<TEntity>(entity);
                    modifiedData.State = EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

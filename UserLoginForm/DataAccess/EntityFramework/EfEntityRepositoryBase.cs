using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserLoginForm.Entities;

namespace UserLoginForm.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new ()
    where TContext : DbContext, new ()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public IList<TEntity> GetListWithGroupBy(Expression<Func<TEntity, bool>> filter = null, string groupBy = null)
        {
            using (var context = new TContext())
            {
                var query = filter == null
                    ? context.Set<TEntity>()
                    : context.Set<TEntity>().Where(filter);

                if (!string.IsNullOrWhiteSpace(groupBy))
                {
                    var parameter = Expression.Parameter(typeof(TEntity));
                    var property = typeof(TEntity).GetProperty(groupBy);
                    var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                    var groupByExpression = Expression.Lambda<Func<TEntity, String>>(propertyAccess, parameter);

                    query = query.GroupBy(groupByExpression)
                        .Select(g => g.First());
                }

                return query.ToList();
            }
        }






        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}


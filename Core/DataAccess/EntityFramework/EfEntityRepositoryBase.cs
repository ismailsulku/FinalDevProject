using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#

            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //veri kaynağına ilişkilendirdim.. ben bunu ne yapayım ? //ref yakalandı
                addedEntity.State = EntityState.Added; //o aslında eklenecek bir nesne 
                context.SaveChanges(); //eklendi..
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //veri kaynağına ilişkilendirdim.. ben bunu ne yapayım ? //ref yakalandı
                deletedEntity.State = EntityState.Deleted; //o aslında silinecek bir nesne 
                context.SaveChanges(); //silindi..
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //veri kaynağına ilişkilendirdim.. ben bunu ne yapayım ? //ref yakalandı
                updatedEntity.State = EntityState.Modified; //o aslında güncellenecek bir nesne 
                context.SaveChanges(); //güncellendi..
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Article.DataAccess.Abstract;
using Article.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Article.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {

        public TEntity GetById(int id)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetArticles()
        {
           using TContext context=new TContext();
           return context.Set<TEntity>().ToList();
        }

        public void Add(TEntity entity)
        {
            using TContext context = new TContext(); 
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using TContext context = new TContext(); 
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new TContext();
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }
    }
}

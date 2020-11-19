using System.Collections.Generic;

namespace Article.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity>
    {
        TEntity GetById(int id);
        List<TEntity> GetArticles();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}

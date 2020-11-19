using System;
using System.Collections.Generic;
using System.Text;
using Article.Entities.Concrete;

namespace Article.DataAccess.Abstract
{
    public interface IArticleRepository:IEntityRepository<Entities.Concrete.Article>
    {
        //Article Entity için özel metotlar tanımlanabilir.
        List<ArticleCategory> GetArticleByCategory();
    }
}

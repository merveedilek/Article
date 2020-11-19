using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Article.DataAccess.Concrete.EntityFramework.Contexts
{
    public class ArticleContext:DbContext
    {
        public DbSet<Entities.Concrete.Article> Articles { get; set; }
    }
}

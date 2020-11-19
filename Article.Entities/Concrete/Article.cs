using System;
using System.Security.Principal;
using Article.Entities.Abstract;

namespace Article.Entities.Concrete
{
    public class Article:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

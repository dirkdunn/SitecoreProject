using SitecoreDev.Foundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Articles.Models
{
    public interface IArticle : ICmsEntity
    {
        Guid Id { get; }
        string Title { get; }
        string Body { get; }
    }

    public class ArticleModel : IArticle
    {
        public virtual Guid Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Body { get; set; }
    }
}
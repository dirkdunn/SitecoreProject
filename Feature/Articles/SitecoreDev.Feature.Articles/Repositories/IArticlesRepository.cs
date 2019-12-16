using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public interface IArticlesRepository
    {
        Item GetArticleContent(string contentGuid);
    }
}
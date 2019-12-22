using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using SitecoreDev.Feature.Articles.Models;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public class SitecoreArticlesRepository : IArticlesRepository
    {

        public IArticle GetArticleContent(string contentGuid)
        {
            Assert.ArgumentNotNullOrEmpty(contentGuid, "contentGuid");

            var mvcContext = new MvcContext();
            var item = mvcContext.GetContextItem<IArticle>();

            return item;
        }
    }
}
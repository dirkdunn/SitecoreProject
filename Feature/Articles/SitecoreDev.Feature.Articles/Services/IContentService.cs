using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Feature.Articles.Models;

namespace SitecoreDev.Feature.Articles.Services
{
    public interface IContentService
    {
        IArticle GetArticleContent(string contentGuid);
    }
}
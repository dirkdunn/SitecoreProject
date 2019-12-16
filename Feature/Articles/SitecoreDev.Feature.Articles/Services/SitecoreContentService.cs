﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Feature.Articles.Models;
using SitecoreDev.Feature.Articles.Repositories;

namespace SitecoreDev.Feature.Articles.Services
{
    public class SitecoreContentService : IContentService
    {
        private readonly IArticlesRepository _repository;

        public SitecoreContentService()
        {
            _repository = new SitecoreArticlesRepository();
        }

        public IArticle GetArticleContent(string contentGuid)
        {
            ArticleModel article = null;

            var item = _repository.GetArticleContent(contentGuid);

            if(item != null)
            {
                article = new ArticleModel();
                article.Id = item.ID.ToString();
                article.Title = item.Fields["Title"]?.Value;
                article.Body = item.Fields["Body"]?.Value;
            }

            return article;
        }
    }
}
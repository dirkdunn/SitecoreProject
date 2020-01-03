using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Foundation.Ioc.Pipelines.InitializeContainer;
using SitecoreDev.Feature.Articles.Repositories;
using SitecoreDev.Feature.Articles.Services;

namespace SitecoreDev.Feature.Articles.Pipelines.InitializeContainer
{
    public class RegisterDependencies
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<ICommentRepository, FakeBlogCommentRepository>();
            args.Container.Register<ICommentService, BlogCommentService>();
            args.Container.Register<IContentService, SitecoreContentService>();
        }
    }
}
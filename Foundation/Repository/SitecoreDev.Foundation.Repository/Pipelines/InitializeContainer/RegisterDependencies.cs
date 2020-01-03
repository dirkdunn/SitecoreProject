using SitecoreDev.Foundation.Ioc.Pipelines.InitializeContainer;
using SitecoreDev.Foundation.Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Foundation.Repository.Pipelines.InitializeContainer
{
    public class RegisterDependencies
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<IContentRepository, SitecoreContentRepository>();
        }
    }
}
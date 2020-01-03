using System;
using SimpleInjector;
using Sitecore.Pipelines;

namespace SitecoreDev.Foundation.Ioc.Pipelines.InitializeContainer
{
    public class InitializeDependencyInjectionArgs : PipelineArgs
    {
        public Container Container { get; set; }

        public InitializeDependencyInjectionArgs(Container container)
        {
            this.Container = container;
        }
    }
}
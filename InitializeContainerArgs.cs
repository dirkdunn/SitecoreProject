using System;
using SimpleInjector;
using Sitecore.Pipelines;

namespace SitecoreDev.Foundation.IoC.Pipelines.InitializeContainer
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
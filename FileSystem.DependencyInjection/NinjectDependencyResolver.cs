namespace FileSystem.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Ninject;
    using Ninject.Modules;

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver()
        {
            INinjectModule[] modules = 
            {
                new DataDependencyModule(),
                new ServiceDependencyModule()
            };
            _kernel = new StandardKernel(modules);
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}
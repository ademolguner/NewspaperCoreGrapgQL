using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Business.DependencyResolver.Ninject
{

    public class NinjectInstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new NinjectBusinessModule()); // , new NinjectAutoMapperModule()
            return kernel.Get<T>();
        }
    }
}

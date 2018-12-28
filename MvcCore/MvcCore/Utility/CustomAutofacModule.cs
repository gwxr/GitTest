using Autofac;
using Autofac.Extras.DynamicProxy;
using Core.Interface;
using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Utility
{
    public class CustomAutofacModule: Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            //注册AOP
            containerBuilder.Register(c => new CustomAutofacAop());
            //注册
            containerBuilder.RegisterType<TestServiceA>().As<ITestServiceA>().SingleInstance().PropertiesAutowired();//PropertiesAutowired是属性注入  未成功

            containerBuilder.RegisterType<TestServiceB>().As<ITestServiceB>();

            containerBuilder.RegisterType<A>().As<IA>().EnableInterfaceInterceptors();
            
        }
    }
}

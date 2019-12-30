using Prism.Unity;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ApplicationMainProject
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<ITestInterface, test>("test");
            var item = Container.Resolve<test2>();
            containerRegistry.RegisterInstance<ITestInterface>(item);
            containerRegistry.Register<ITestInterface, test2>();
            

            //var item = Container.Resolve<test>("test2");
            //containerRegistry.RegisterInstance<ITestInterface>(item);


            //var item2 = Container.Resolve<test2>("test3");
            //containerRegistry.RegisterInstance<ITestInterface>(item2);
            //containerRegistry.RegisterInstance<ITestInterface>()
            //containerRegistry.RegisterSingleton<ITestInterface>();
            //containerRegistry.RegisterSingleton<SingletonTest>();
            //var test = Container.Resolve<SingletonTest>();
            //containerRegistry.RegisterInstance<SingletonTest>(test);
        }
    }
}

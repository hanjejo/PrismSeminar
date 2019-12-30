using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _02_InstanceRegistration
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            var window = Container.Resolve<MainWindow>();
            return window;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //sample 01 - 일반적인 생성
            var user = new UserInfo();
            containerRegistry.RegisterInstance<UserInfo>(user);

            //sample 02 - 컨테이너에의한 생성 (생성자에서 의존성 주입 지원)
            //var user_02 = Container.Resolve<UserInfo_02>();
            //containerRegistry.RegisterInstance<UserInfo_02>(user_02);

            //smaple 03 - 싱글톤 등록
            //containerRegistry.RegisterSingleton<ISingleton, Singleton>();
            //Singleton.instance.GetUserInfo();
        }
    }
}

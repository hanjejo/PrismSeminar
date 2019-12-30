using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02_InstanceRegistration
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        //sample 01
        public MainWindow(IContainerExtension container, UserInfo user)
        {
            InitializeComponent();
        }

        //sample 02
        //public MainWindow(IContainerExtension container, UserInfo_02 user)
        //{
        //    InitializeComponent();
        //}

        //sample 03
        //public MainWindow(IContainerExtension container, ISingleton singleton)
        //{
        //    var user = singleton.GetUserInfo();
        //    InitializeComponent();
        //}
    }
}

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
using Unity;
using Prism.Ioc;
using Prism.Regions;

namespace ApplicationMainProject
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        IContainerExtension _container;
        IRegionManager _regionManager;
        IRegion _region;
        ViewA _viewA;
        ViewB _viewB;
        ITestInterface _test;

        public MainWindow(IContainerExtension container, IRegionManager regionManager, ITestInterface test)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;
            _test = test;

            //test.humen.Add(new Human());
            //List<Human> humen = test.GetHuman();

            this.Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _viewA = _container.Resolve<ViewA>();
            _viewB = _container.Resolve<ViewB>();

            _region = _regionManager.Regions["ContentRegion"];

            _region.Add(_viewA);
            _region.Add(_viewB);
            _test.GetHuman();
        }

        private void B_Deactive(object sender, RoutedEventArgs e)
        {
            _region.Deactivate(_viewB);
        }

        private void B_Active(object sender, RoutedEventArgs e)
        {
            _region.Activate(_viewB);
        }

        private void A_Deactive(object sender, RoutedEventArgs e)
        {
            _region.Deactivate(_viewA);
        }

        private void A_Active(object sender, RoutedEventArgs e)
        {
            _region.Activate(_viewA);
        }
    }
}

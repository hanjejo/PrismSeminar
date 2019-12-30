using Prism.Regions;
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
using System.Windows.Shapes;
using ShowDialogOnPrism.ViewModels;

namespace ShowDialogOnPrism.Views
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubWindow : Window
    {
        IRegionManager _regionManager;
        public SubWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            _regionManager = regionManager;
            RegionManager.SetRegionManager(this, regionManager);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _regionManager.Regions.Remove(SubWindowViewModel.regionA);
        }
    }
}

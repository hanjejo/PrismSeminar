using _04_Region.Views;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Region.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("ContentRegion_A", typeof(ViewA));
        }
    }
}

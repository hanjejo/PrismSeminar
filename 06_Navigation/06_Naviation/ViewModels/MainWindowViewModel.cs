using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Naviation.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand ViewAClick { get; private set; }

        public DelegateCommand ViewBClick { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            ViewAClick = new DelegateCommand(NavigateA);
            ViewBClick = new DelegateCommand(NavigateB);
        }

        private void NavigateA()
        {
            _regionManager.RequestNavigate("ContentRegion", "ViewA");
        }

        private void NavigateB()
        {
            _regionManager.RequestNavigate("ContentRegion", "ViewB");
        }
    }
}

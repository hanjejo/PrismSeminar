using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShowDialogOnPrism.Views;

namespace ShowDialogOnPrism.ViewModels
{
    public class SubWindowViewModel : BindableBase
    {
        IContainerExtension _container;
        IRegionManager _regionmanager;

        private static readonly string _regionA = "tesa";
        public static string regionA { get => _regionA; }

        public ICommand CommandA { get; }
        public ICommand CommandB { get; }

        public SubWindowViewModel(IContainerExtension container, IRegionManager regionmanager)
        {
            _container = container;
            _regionmanager = regionmanager;

            CommandA = new DelegateCommand(ClickA);
            CommandB = new DelegateCommand(ClickB);

            _container.RegisterForNavigation<ViewA>();
            _container.RegisterForNavigation<ViewB>();
        }

        public void ClickA()
        {
            _regionmanager.RequestNavigate(regionA, nameof(ViewA));
        }

        public void ClickB()
        {
            _regionmanager.RequestNavigate(regionA, nameof(ViewB));
        }
    }
}

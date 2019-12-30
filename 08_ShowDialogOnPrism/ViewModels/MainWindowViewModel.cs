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
    public class MainWindowViewModel : BindableBase
    {
        IContainerExtension _container;

        public ICommand button { get; }

        public MainWindowViewModel(IContainerExtension container)
        {
            _container = container;

            button = new DelegateCommand(ShowDialog);
        }

        public void ShowDialog()
        {
            SubWindow view = _container.Resolve<SubWindow>();
            view.ShowDialog();
        }
    }
}

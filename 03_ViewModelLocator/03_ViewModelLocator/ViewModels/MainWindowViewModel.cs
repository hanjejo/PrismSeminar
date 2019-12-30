using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _03_ViewModelLocator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _Title = "Prism Window!!";

        public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }

        public ICommand clickcommand { get; private set; }

        public MainWindowViewModel()
        {
            clickcommand = new DelegateCommand(Click);
        }

        public void Click()
        {
            MessageBox.Show("Clicked Button!!");
        }
    }
}

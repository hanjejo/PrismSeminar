using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _21_MVVMPattern
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _Title = "Test Window";

        public ICommand command { private set; get; }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; OnPropertyChanged(); }
        }

        public MainWindowViewModel()
        {
            command = new RelayCommand(Click);
        }

        public void Click()
        {
            Title = "Clicked!!";
        }
    }
}

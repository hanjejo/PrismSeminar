using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMPattern
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Human> human { set; get; }

        public ICommand Click { get; set; }

        public MainWindowViewModel()
        {
            human = new ObservableCollection<Human>();
            human.Add(new Human() { Name = "test", Age = 19 });
            human.Add(new Human() { Name = "test", Age = 19 });
            human.Add(new Human() { Name = "test", Age = 19 });

            Click = new RelayCommand(UpdateText);
        }

        public void UpdateText()
        {
            foreach(var item in human)
            {
                item.Name = "hanje";
                item.Age = 29;
            }
        }
    }
}

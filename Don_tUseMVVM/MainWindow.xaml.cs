using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NoUseMVVM
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Human> humen = new ObservableCollection<Human>();

        public MainWindow()
        {
            InitializeComponent();

            ListBox_1.ItemsSource = humen;
            humen.Add(new Human());
            humen.Add(new Human());
            humen.Add(new Human());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in ListBox_1.Items.Cast<Human>())
            {
                item.Name = "hanje";
                item.Age = 29;
            }

            CollectionViewSource.GetDefaultView(ListBox_1.ItemsSource).Refresh();
        }
    }
}

using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Region.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _Text = "Text";

        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }
    }
}

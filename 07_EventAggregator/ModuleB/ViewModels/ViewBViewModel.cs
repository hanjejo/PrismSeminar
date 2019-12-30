using EventAggregate.Core;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        IEventAggregator _ea;
        private string _Text = "ViewB";

        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }

        public ViewBViewModel(IEventAggregator ea)
        {
            _ea = ea;

            ea.GetEvent<MessageSentEvent>().Subscribe(UpdateText);
        }

        public void UpdateText(string Message)
        {
            Text = Message;
        }
    }
}

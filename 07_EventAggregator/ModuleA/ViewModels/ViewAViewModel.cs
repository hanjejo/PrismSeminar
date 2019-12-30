using EventAggregate.Core;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        IEventAggregator _ea;
        private string _Text = "ViewA";

        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }

        public ICommand SendMessage { private set; get; }

        public ViewAViewModel(IEventAggregator ea)
        {
            _ea = ea;

            SendMessage = new DelegateCommand<string>(UpdateMessage);
        }

        public void UpdateMessage(string Message)
        {
            _ea.GetEvent<MessageSentEvent>().Publish(Message);
        }
    }
}

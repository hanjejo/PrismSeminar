using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publish_SubscribePattern
{
    #region Not use parameter
    public class EventManager
    {
        public delegate void EventHandler();

        EventHandler _Event;

        public void Subscribe(EventHandler handler)
        {
            _Event += new EventHandler(handler);
        }

        public void UnSubscribe(EventHandler handler)
        {
            _Event -= new EventHandler(handler);
        }

        public void Publish()
        {
            if (_Event != null)
                _Event();
        }
    }
    #endregion

    #region Use parameter
    public class EventManager<T> where T : EventArgs
    {
        public delegate void EventHandler(T item);

        EventHandler _Event;

        public void Subscribe(EventHandler handler)
        {
            _Event += new EventHandler(handler);
        }

        public void UnSubscribe(EventHandler handler)
        {
            _Event -= new EventHandler(handler);
        }

        public void Publish(T item)
        {
            if (_Event != null)
                _Event(item);
        }
    }
    #endregion
}

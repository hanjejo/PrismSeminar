using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publish_SubscribePattern
{
    #region 모든 클래스에서 접근 가능한 이벤트 집합
    public static class EventAggregator
    {
        public static EventManager ProviderMachine = new EventManager();
        public static EventManager<Contents> Jugealum_Youtube = new EventManager<Contents>();
    }
    #endregion
}

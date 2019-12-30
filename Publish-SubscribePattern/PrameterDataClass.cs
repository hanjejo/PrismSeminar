using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publish_SubscribePattern
{
    public class Contents : EventArgs
    {
        public string Name;
        public string Text;
    }
}

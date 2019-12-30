using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern
{
    public class Desktop
    {
        public ICPU _cpu;
        public IRAM _ram;

        public Desktop(ICPU cpu, IRAM ram)
        {
            _cpu = cpu;
            _ram = ram;
        }
    }
}

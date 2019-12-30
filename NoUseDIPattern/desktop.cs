using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoUseDIPattern
{
    public class Desktop_Intel
    {
        ICPU _cpu;
        IRAM _ram;
        
        public Desktop_Intel()
        {
            _cpu = new Intel_CPU();
            _ram = new SAMSUNG_RAM();
        }
    }

    public class Desktop_AMD
    {
        ICPU _cpu;
        IRAM _ram;

        public Desktop_AMD()
        {
            _cpu = new AMD_CPU();
            _ram = new Hynix_RAM();
        }
    }
}

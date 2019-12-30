using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Desktop desktop1 = new Desktop(new AMD_CPU(), new SAMSUNG_RAM());
            Desktop desktop2 = new Desktop(new Intel_CPU(), new Hynix_RAM());
        }
    }
}

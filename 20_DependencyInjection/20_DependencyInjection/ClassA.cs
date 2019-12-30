using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_DependencyInjection
{
    public class ClassA
    {
        IServiceA _serviceA;
        public ClassA(IServiceA serivce)
        {
            _serviceA = serivce;
        }

        public void Run()
        {
            _serviceA.Run();
        }
    }
}

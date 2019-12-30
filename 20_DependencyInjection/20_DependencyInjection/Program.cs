using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // IService 구성요소 외부에서 생성
            ServiceA serviceA = new ServiceA();

            // 외부에서 IService 구성요소 주입
            ClassA A = new ClassA(serviceA);

            // A는 ServiceA를 알 필요없음
            A.Run();
        }
    }
}

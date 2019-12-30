using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIBasicSample
{
    public class Hanje : ICreate
    {
        public void Create(string contents)
        {
            Console.WriteLine("한제는 " + contents + "를 업로드하였습니다.");
        }
    }

    public class Seoksoo : ICreate
    {
        public void Create(string contents)
        {
            Console.WriteLine("석수는 " + contents + "를 업로드하였습니다.");
        }
    }
}

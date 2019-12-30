using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIBasicSample
{
    class Program
    {
        static Hanje hanje = new Hanje();
        static Seoksoo seoksoo = new Seoksoo();
        static Youtube youtube;

        static void Main(string[] args)
        {
            youtube = new Youtube(hanje);
            youtube.create("주식으로 100만원 버는방법");

            youtube = new Youtube(seoksoo);
            youtube.create("게임 매크로 만드는 방법");
        }
    }
}

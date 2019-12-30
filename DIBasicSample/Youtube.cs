using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIBasicSample
{
    public class Youtube
    {
        ICreate _creator;

        public Youtube(ICreate creator)
        {
            _creator = creator;
        }

        public void create(string contets)
        {
            _creator.Create(contets);
        }
    }
}

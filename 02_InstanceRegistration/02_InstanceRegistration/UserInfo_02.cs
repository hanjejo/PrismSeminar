using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InstanceRegistration
{
    public class UserInfo_02
    {
        public UserInfo_02(IContainerExtension container)
        {

        }

        public string ID = "UserName";
        public string PW = "password1";
    }
}

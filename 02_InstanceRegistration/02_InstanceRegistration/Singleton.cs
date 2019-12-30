using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InstanceRegistration
{
    public interface ISingleton
    {
        UserInfo GetUserInfo();
    }

    public class Singleton : ISingleton
    {
        public static Singleton instance = new Singleton();

        public UserInfo GetUserInfo()
        {
            return new UserInfo();
        }
    }
}

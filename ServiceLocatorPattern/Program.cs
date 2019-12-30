using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class ServiceA 
    {
        public void Execute()
        {
            Console.WriteLine("A service called.");
        }
    }

    public class ServiceB 
    {
        public void Execute()
        {
            Console.WriteLine("B service called.");
        }
    }

    public static class ServiceLocator
    {
        public static Dictionary<Type, object> servicecontainer = null;
        static ServiceLocator()
        {
            servicecontainer = new Dictionary<Type, object>();
        }

        public static T GetService<T>()
        {
            try
            {
                return (T)servicecontainer[typeof(T)];
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("Service not available.");
            }
        }

        public static void Add<T>(T obj)
        {
            servicecontainer.Add(typeof(T), obj);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.Add<ServiceA>(new ServiceA());
            ServiceLocator.Add<ServiceB>(new ServiceB());

            ServiceA Aservice = ServiceLocator.GetService<ServiceA>();
            Aservice.Execute();

            ServiceB Bservice = ServiceLocator.GetService<ServiceB>();
            Bservice.Execute();

            Console.ReadLine();
        }
    }
}

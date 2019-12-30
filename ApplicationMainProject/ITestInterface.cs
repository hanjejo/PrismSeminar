using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationMainProject
{
    public interface ITestInterface
    {
        Human GetHuman();
        Animal GetAnimal();
    }

    public class Human
    {
        string Name;
    }

    public class Animal
    {
        string Name;
    }

    public class test : ITestInterface
    {
        public List<Human> humen = new List<Human>();
        public List<Animal> animals = new List<Animal>();

        public Animal GetAnimal()
        {
            return new Animal();
        }

        public Human GetHuman()
        {
            return new Human();
        }
    }

    public class test2 : ITestInterface
    {
        public ObservableCollection<Human> humen = new ObservableCollection<Human>();
        public ObservableCollection<Animal> animals = new ObservableCollection<Animal>();

        public Animal GetAnimal()
        {
            return new Animal();
        }

        public Human GetHuman()
        {
            return new Human();
        }
    }

    public class SingletonTest 
    {
        static SingletonTest Instance = new SingletonTest();

        public List<Human> humen = new List<Human>();
        public List<Animal> animals = new List<Animal>();

        public List<Animal> GetAnimal()
        {
            return animals;
        }

        public List<Human> GetHuman()
        {
            return humen;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();


        private  SingletonDataContainer()
        {

            Console.WriteLine("Init singleton object");

            var elements = File.ReadAllLines(@"C:\projects\DesignPatterns\DesignPatterns\Singleton\capitals.txt");

            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));

                Console.WriteLine(elements[i]);
            }
        }


        public string GetPopulation(string name)
        {
            return  $"{name} population is {_capitals[name]}";
        }

        public int PopulationGrowth(string name, int growth)
        {
            return _capitals[name] * growth;
        }

        private static Lazy<SingletonDataContainer> instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
 
        public static SingletonDataContainer Instance => instance.Value;
    }
}

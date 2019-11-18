using System;
using System.Diagnostics;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var db1 = SingletonDataContainer.Instance;

            Console.WriteLine(db1.GetPopulation("London"));
            Console.WriteLine(db1.PopulationGrowth("London", 2));

            var db2 = SingletonDataContainer.Instance;

            Console.WriteLine(db1.GetPopulation("Beijing"));
            var db3 = SingletonDataContainer.Instance;

            Console.WriteLine(db1.GetPopulation("New Delhi"));
            var db4 = SingletonDataContainer.Instance;
            Console.Read();
        }
    }
}

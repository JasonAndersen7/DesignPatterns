using Decorator.FarmDecorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
 
            FarmDecorator();



            Console.Read();
        }


        static void FarmDecorator()
        {
            //Step 1: Define some dishes, and how many of each we can make
            FreshSaladDish caesarSalad = new FreshSaladDish("Crisp romaine lettuce", "Freshly-grated Parmesan cheese", "House-made Caesar dressing");
            caesarSalad.Display();

            PastaDish fettuccineAlfredo = new PastaDish("Fresh-made daily pasta", "Creamy garlic alfredo sauce");
            fettuccineAlfredo.Display();

            MeatDish MeatLoverPizza = new MeatDish(true, "Pepperoni", "American");
            MeatLoverPizza.Display();

            Console.WriteLine("\nMaking these dishes available.");
            
            //Step 2: Decorate the dishes; now if we attempt to order them once we're out of ingredients, we can notify the customer

            Available fettuciniAvailable = new Available(fettuccineAlfredo , 3);
            Available caeserAvailable = new Available(caesarSalad, 4);
            Available meatAvailable = new Available(MeatLoverPizza, 3);


            fettuciniAvailable = new Available(fettuccineAlfredo, 2);

            //Step 3: Order a bunch of dishes
            fettuciniAvailable.OrderItem("John");
            fettuciniAvailable.OrderItem("Sally");
            fettuciniAvailable.OrderItem("Manush");


            //fettuciniAvailable.OrderItem("Sally");
            //fettuciniAvailable.OrderItem("Lisa");
            //fettuciniAvailable.OrderItem("Hope");

            //meatAvailable.OrderItem("John");
            //meatAvailable.OrderItem("Bob");
            //meatAvailable.OrderItem("Larry");
            //meatAvailable.OrderItem("Trevor");


            caeserAvailable.Display();
            fettuciniAvailable.Display();
            meatAvailable.Display();


        }

        static void ProjectDecorator()
        {
            BasicProject newWebSite = new MarketingProject();

            Console.WriteLine($"New Web Site for {newWebSite.Description} at an overhead of {newWebSite.ProjectOverhead()}");

            BasicProject expensiveContract = new TechnologyProject();

            expensiveContract = new Contractor(expensiveContract);
            expensiveContract = new Contractor(expensiveContract);
            expensiveContract = new Accountant(expensiveContract);

            Console.WriteLine($" The project has the following resources {expensiveContract.Description} and has the following overhead ${expensiveContract.ProjectOverhead()} ");

            BasicProject cheapProject = new MarketingProject();

            cheapProject = new Scrub(cheapProject);
            cheapProject = new Scrub(cheapProject);
            cheapProject = new Scrub(cheapProject);
            cheapProject = new Scrub(cheapProject);


            Console.WriteLine($" The project has the following resources {cheapProject.Description} and has the following overhead ${cheapProject.ProjectOverhead()} ");

            BasicProject normalProject = new SupplyChainProject();
            normalProject = new ProjectManager(normalProject);
            normalProject = new Accountant(normalProject);
            normalProject = new Contractor(normalProject);
            normalProject = new Scrub(normalProject);
            normalProject = new Scrub(normalProject);

            Console.WriteLine($" The project has the following resources {normalProject.Description} and has the following overhead ${normalProject.ProjectOverhead()} ");

        }
    }
}

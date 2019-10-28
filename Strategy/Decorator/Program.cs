using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
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


            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.FarmDecorator
{
    /// <summary>
    /// A ConcreteDecorator. This class will impart "responsibilities" onto the dishes 
    /// (e.g. whether or not those dishes have enough ingredients left to order them)
    /// </summary>
    class Available : Decorator
    {
        public int NumAvailable { get; set; } //How many can we make?
        protected List<string> customers = new List<string>();
        public Available(RestaurantDish dish, int numAvailable) : base(dish)
        {
            NumAvailable = numAvailable;
        }

        public void OrderItem(string name)
        {
            if (NumAvailable > 0)
            {
                customers.Add(name);
                NumAvailable--;

                Console.WriteLine($"Ordered meal {dish} for {name}");
            }
            else
            {
                Console.WriteLine("\nNot enough ingredients for " + name + "'s order!");
            }
        }

        public override void Display()
        {
            base.Display();
            _dish.Display();

            foreach(var customer in customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.FarmDecorator
{

    /// <summary>
    /// A ConcreteComponent class
    /// </summary>

   public class MeatDish : RestaurantDish
   {

       public bool HasSausage;
       public string Meat;
       public string Cheese;


        public MeatDish(bool hasSausage, string meat, string cheese)
        {
            HasSausage = hasSausage;
            Meat = meat;
            Cheese = cheese;
        }

        public override void Display()
        {
            Console.WriteLine($"Does it have Sausage? {HasSausage} ");
            Console.WriteLine($"Meat is {Meat}");
            Console.WriteLine($"Cheese is {Cheese}");

        }
    }
}

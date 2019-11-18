using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.FarmDecorator
{
    /// <summary>
    /// A ConcreteComponent class
    /// These classes only implement their properties, not the number of dishes available (which is the responsibility of the Decorator).
    /// </summary>
    class FreshSaladDish : RestaurantDish
    {
        private string _greens;
        private string _cheese; //I am going to use this pun everywhere I can
        private string _dressing;

        public FreshSaladDish(string greens, string cheese, string dressing)
        {
            _greens = greens;
            _cheese = cheese;
            _dressing = dressing;
        }

        public override void Display()
        {
            Console.WriteLine("\nFresh Salad:");
            Console.WriteLine(" Greens: {0}", _greens);
            Console.WriteLine(" Cheese: {0}", _cheese);
            Console.WriteLine(" Dressing: {0}", _dressing);
        }
    }
}

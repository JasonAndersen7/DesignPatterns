using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.FarmDecorator
{
    /// <summary>
    /// A ConcreteComponent class
    /// These classes only implement their properties, not the number of dishes available (which is the responsibility of the Decorator).
    /// </summary>
    class PastaDish : RestaurantDish
    {
        private string _pastaType;
        private string _sauce;

        public PastaDish(string pastaType, string sauce)
        {
            _pastaType = pastaType;
            _sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("\nClassic Pasta:");
            Console.WriteLine(" Pasta: {0}", _pastaType);
            Console.WriteLine(" Sauce: {0}", _sauce);
        }
    }
}

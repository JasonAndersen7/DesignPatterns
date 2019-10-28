using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Observer
{
    public class Restaurant : IRestaurant
    {

        private string name;
        private Veggies veggie;
        private double purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold, Veggies veggie)
        {
            this.name = name;
            this.purchaseThreshold = purchaseThreshold;
            this.veggie = veggie;
        }


        public void Update(Veggies veggies)
        {
            Console.WriteLine("Notified {0} of {1}'s " + " price change to {2:C} per pound.", name, veggie.GetType().Name, veggie.PricePerPound);
            if(veggie.PricePerPound < purchaseThreshold)
            {
                Console.WriteLine(name + " wants to buy some " + veggie.GetType().Name + "!");
            }

        }


        }
}

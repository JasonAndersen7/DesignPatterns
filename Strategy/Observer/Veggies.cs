using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// The Subject abstract class
    /// </summary>
    public abstract class Veggies
    {
        private double pricePerPound;
        private List<IRestaurant> restaurants = new List<IRestaurant>();


        public Veggies(double pricePerPound)
        {
            this.pricePerPound = pricePerPound;
        }

        public void AddObserver(IRestaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

        public void RemoveObserver(IRestaurant restaurant)
        {
            restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in restaurants)
            {

                restaurant.Update(this);
            }

        }

        public double PricePerPound
        {
            get { return pricePerPound; }

            set
            {
                if (pricePerPound != value)
                {
                    pricePerPound = value;
                    Notify();//Automatically notify our observers of price changes
                }
            }
        }

    }
}

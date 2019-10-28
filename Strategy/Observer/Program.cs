using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
           


            // Create price watch for Carrots and attach restaurants that buy carrots from suppliers.
            Carrots carrots = new Carrots(0.82);
            carrots.AddObserver(new Restaurant("Bubbles", 0.99, carrots));
            carrots.AddObserver(new Restaurant("Johns", 0.75, carrots));
            carrots.AddObserver(new Restaurant("Steve's'", 0.77, carrots));

            Broccoli broccoli = new Broccoli(.75);
            IRestaurant bubbles = new Restaurant("Bubbles", .99, broccoli);
            
            broccoli.AddObserver(bubbles);
            broccoli.PricePerPound = .45;


            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = .77;
            carrots.PricePerPound = .50;
            carrots.PricePerPound = 10;
            carrots.PricePerPound = .84;

            Console.ReadLine();
        }
    }
}

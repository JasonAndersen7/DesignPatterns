using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Duck : Bird
    {
        public Duck()
        {
            FlyBehavior = new FlyWithWings();
            VocalizeBehavior = new Chirp();
        }

        public void Display()
        {
            Console.WriteLine("I'm a real Duck");
        }
    }
}

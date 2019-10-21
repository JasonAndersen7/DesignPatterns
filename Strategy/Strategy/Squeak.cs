using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Squeak : IVocalizeBehavior
    {
        public void Vocalize()
        {
            Console.WriteLine("Squeak, Squeak");
        }
    }
}

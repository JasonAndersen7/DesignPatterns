using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Bark : IVocalizeBehavior
    {
        public void Vocalize()
        {
            Console.WriteLine("Bark, Bark");
        }
    }
}

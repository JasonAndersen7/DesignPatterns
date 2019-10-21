using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
   public class Gurgle : IVocalizeBehavior
    {
        public void Vocalize()
        {
           Console.WriteLine("Gurgle, Gurgle");
        }
    }
}

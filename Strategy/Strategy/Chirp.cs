using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Chirp : IVocalizeBehavior
    {
        public void Vocalize()
        {
           Console.WriteLine("Chirp, Chirp, Cheep");
        }
    }
}

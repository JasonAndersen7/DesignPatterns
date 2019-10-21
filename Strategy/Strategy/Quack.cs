using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Quack: IVocalizeBehavior
    {
        public void Vocalize()
        {
            Console.WriteLine("Quack, Quack, Quack");
        }
    }
}

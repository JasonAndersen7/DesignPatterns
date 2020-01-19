using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
    public class Tuner
    {
        private Amplifier amplifier;

        public Tuner(Amplifier amp)
        {
            this.amplifier = amp;
        }

        public string On()
        {
            return "The amplifier is on";
        }
        public string Off()
        {
            return "The amplifier is off";
        }

        public string setAm()
        {
            return "Tuner set to AM";
        }
        public string setFM()
        {
            return "Tuner set to FM";
        }

        public string setFrequency()
        {
            return "Tuner set frequency";
        }

        public override string ToString()
        {
            return base.ToString() + " Tuner set ";

        }
    }
}

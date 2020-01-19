using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
   public class TheaterLights
    {

        
        public string On()
        {
            return "The theater lights are on";
        }
        public string Off()
        {
            return "The theater lights are off";
        }

        public string Dim()
        {
            return "The theater lights are dimmed";
        }

        public override string ToString()
        {
            return base.ToString() + " Theater lights ";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
    public class Popper
    {
        public string On()
        {
            return "The popper is on";
        }
        public string Off()
        {
            return "The popper is off";
        }

        public string Pop()
        {
            return "The popper is popping";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
    public class Screen
    {

        public string Up()
        {
            return "The screen is up";
        }
        public string Down()
        {
            return "The screen is down";
        }

        public override string ToString()
        {
            return base.ToString() + " the screen is active ";

        }
    }
}

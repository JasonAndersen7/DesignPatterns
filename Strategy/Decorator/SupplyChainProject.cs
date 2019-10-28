using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SupplyChainProject : BasicProject
    {
        public SupplyChainProject()
        {
            description = " Supply Chain Project ";
        }

        public override double ProjectOverhead()
        {
            return 1.5;
        }
    }
}

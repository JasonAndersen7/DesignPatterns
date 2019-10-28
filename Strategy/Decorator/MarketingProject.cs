using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class MarketingProject : BasicProject
    {
        public MarketingProject()
        {
            description = "Marketing";
        }

        public override double ProjectOverhead()
        {
            return 1.0;
        }
    }
}

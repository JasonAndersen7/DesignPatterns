using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class FinanceProject : BasicProject
    {
        public FinanceProject()
        {
            description = "Finance";
        }

        public override double ProjectOverhead()
        {
            return 2.00;
        }
    }
}

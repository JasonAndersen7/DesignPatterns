using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class TechnologyProject : BasicProject
    {
        public TechnologyProject()
        {
            description = "Technology Project ";
        }

        public override double ProjectOverhead()
        {
            return 4.5;
        }
    }
}

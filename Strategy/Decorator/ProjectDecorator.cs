using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class ProjectDecorator : BasicProject
    {
        public override string Description { get; }
        
        public override double ProjectOverhead()
        {
            return 0;
        }

        
    }
}

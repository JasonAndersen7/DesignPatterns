using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
   public class Scrub : BasicProject
   {
       private BasicProject basicProject;

        public Scrub(BasicProject basicProject)
        {
            this.basicProject = basicProject;
        }

        public override string Description
        {
            get { return basicProject.Description + ", Cheap Scrub "; }
        }

        public override double ProjectOverhead()
        {
            return basicProject.ProjectOverhead() + .01;
        }
    }
}

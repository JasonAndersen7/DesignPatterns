using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
  public class Accountant : ProjectDecorator
  {
      public BasicProject basicProject;

      public Accountant(BasicProject basicProject)
      {
          this.basicProject = basicProject;
      }
        public override string Description
        {
            get { return basicProject.Description + ", Accountant Resource "; }
        }

        public override double ProjectOverhead()
        {
            return basicProject.ProjectOverhead() + 1.0;
        }
    }
}

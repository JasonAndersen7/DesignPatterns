using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{

    /// <summary>
    /// Extends the Decorator functionality
    /// </summary>
   public class Contractor : ProjectDecorator
   {
       private BasicProject basicProject;

       public Contractor(BasicProject basicProject)
       {
           this.basicProject = basicProject;
       }

       public override string Description
        {
           get { return basicProject.Description + ", Contractor Resource "; }
       }

        public override double ProjectOverhead()
        {
            return basicProject.ProjectOverhead() + 1.0;
        }
   }
}

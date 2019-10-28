using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ProjectManager: BasicProject
    {
        internal BasicProject basicProject;

        public ProjectManager(BasicProject basicProject)
        {
            this.basicProject = basicProject;
        }


        public override double ProjectOverhead()
        {
            return basicProject.ProjectOverhead() + 1.25;
        }

        public override string Description
        {
            get { return basicProject.Description + ", Project Manager "; }
        }
    }
}

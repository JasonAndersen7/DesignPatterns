using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{

    /// <summary>
    /// In the decorator pattern the Component class that all other Decorators will inherit from 
    /// </summary>
   public abstract class BasicProject
    {
        public string description = "Basic Project";

        public virtual string Description
        {
            get { return description; }
        }

        public abstract double ProjectOverhead();

    }
}

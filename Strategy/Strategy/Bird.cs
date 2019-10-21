using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// Template class that concrete instances will implement
    /// </summary>
  public abstract class Bird
  {
      public IFlyBehavior FlyBehavior;
      public IVocalizeBehavior VocalizeBehavior;

      public void Swim()
      {

      }

      public void Display()
      {

      }

      public void PerformVocalize()
      {
          VocalizeBehavior.Vocalize();
      }

      public void PerformFly()
      {
          FlyBehavior.Fly();
      }

      public void setFlyBehavior(IFlyBehavior fb)
      {
          FlyBehavior = fb;
      }

      public void setVocalizeBehavior(IVocalizeBehavior vb)
      {
          VocalizeBehavior = vb;
      }
  }
}

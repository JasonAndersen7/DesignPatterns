using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
  public class TestHarness
    {


        public void Test()
        {
            Console.WriteLine("Hello World!");

            Duck mallardDuck = new Duck();

            mallardDuck.PerformFly();
            mallardDuck.PerformVocalize();

            Duck gotShotDuck = new Duck();

            gotShotDuck.PerformFly();
            Console.WriteLine("I got shot");

            gotShotDuck.setFlyBehavior(new FlyNoWay());
            gotShotDuck.setVocalizeBehavior(new Gurgle());


            
            gotShotDuck.PerformFly();
            gotShotDuck.PerformVocalize();



            Console.Read();
        }
    }
}

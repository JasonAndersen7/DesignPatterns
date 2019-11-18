using System;
using System.Data;
using DesignPatterns.Command;

namespace Default
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            Alarm houseAlarm = new Alarm(" HOME ");

            Remote remoteControl = new Remote();

            remoteControl.SetCommand(0, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));

            Console.WriteLine(remoteControl.OnButtonWasPushed(0));


            Console.Read();
        }
    }
}

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
           
          

            CallCommand();


            Console.Read();
        }

        private static void CallCommand()
        {
            string house = " house ";

            Remote remoteControl = new Remote();

            //clients 
            Alarm houseAlarm = new Alarm(house);
            CeilingFan ceilingFan = new CeilingFan(house);
            GarageDoor garageDoor = new GarageDoor(house);
            Hottub hottub = new Hottub();
            Light light = new Light(house);
            Stereo stereo = new Stereo(house);

            remoteControl.SetCommand(0, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));
            remoteControl.SetCommand(1, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));
            remoteControl.SetCommand(2, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));
            remoteControl.SetCommand(3, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));
            remoteControl.SetCommand(4, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));
            remoteControl.SetCommand(5, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));
            remoteControl.SetCommand(6, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));



            Console.WriteLine(remoteControl.OnButtonWasPushed(0));
        }
    }
}

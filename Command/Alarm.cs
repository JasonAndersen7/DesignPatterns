using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
   public class Alarm
    {
        private  string AlarmType { get; set; }

        public Alarm(string alarmType)
        {
            AlarmType = alarmType;
        }

        public string On()
        {
            return $" Alarm {AlarmType} is on";
        }

        public string Off()
        {
            return $" Alarm {AlarmType} is off";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class AlarmOffCommand : Command
    {
        private Alarm Alarm;

        public AlarmOffCommand(Alarm alarm)
        {
            this.Alarm = alarm;
        }

        public object Execute()
        {
           return  Alarm.Off();
        }
    }
}

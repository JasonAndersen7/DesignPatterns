using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
   public class AlarmOnCommand : Command
    {
        private Alarm Alarm;

        public AlarmOnCommand(Alarm alarm)
        {
            this.Alarm = alarm;
        }

        public object Execute()
        {
            return  Alarm.On();
        }

    }
}

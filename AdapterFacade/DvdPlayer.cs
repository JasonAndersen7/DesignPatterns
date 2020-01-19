using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
   public class DvdPlayer
   {
       private Amplifier amp;

        public DvdPlayer (Amplifier ampliferAmp)
        {
            this.amp = ampliferAmp;
        }
        public string On()
        {
            return "The DvD Player is on";
        }
        public string Off()
        {
            return "The DvD Player is off";
        }

        public string Eject()
        {
            return $"The DVD is ejected";
        }

        public string Pause()
        {
            return "The DvD Player is paused";
        }
        public string Play()
        {
            return "The DvD Player is playing";
        }

        public string SetSurroundAudio()
        {
            return $"The DvD Player is setting surround Audio";
        }

        public string SetTwoChannelAudio()
        {
            return "setting channel Audio";
        }

        public string Stop()
        {
            return "Stopping";
        }

        public override string ToString()
        {
            return base.ToString() + " DvD Player ";

        }
    }
}

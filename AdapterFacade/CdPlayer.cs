using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
   public  class CdPlayer
   {
       private Amplifier amplifier;

        public CdPlayer(Amplifier amp)
        {
            this.amplifier = amp;
        }

        public string On()
        {
            return "The CD Player is on";
        }
        public string Off()
        {
            return "The CD Player is off";
        }

        public string Eject()
        {
            return $"The DVD is ejected";
        }

        public string Pause()
        {
            return "The CD Player is paused";
        }
        public string Play()
        {
            return "The CD Player is playing";
        }

        public string Stop()
        {
            return "The CD Player is playing";
        }

        public override string ToString()
        {
            return base.ToString() + " CD Player set ";

        }

    }
}

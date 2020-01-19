using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
   public class Projector
   {
       private DvdPlayer dvd;

        public Projector(DvdPlayer dvdPlayer)
        {
            this.dvd = dvdPlayer;
        }

        public string On()
        {
            return "The Projector is on";
        }
        public string Off()
        {
            return "The Projector is off";
        }

        public string Eject()
        {
            return $"The DVD {this.dvd.ToString()} is ejected";
        }

        public string Pause()
        {
            return "The Projector is paused";
        }
        public string Play()
        {
            return "The Projector is playing";
        }

        public string SetSurroundAudio()
        {
            return $"The projector is setting surround Audio";
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
            return base.ToString() + " Projector ";

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterFacade
{
   public class Amplifier
   {

       private Tuner tuner;
       private DvdPlayer dvdPlayer;
       private CdPlayer cdPlayer;

       public Amplifier()
       {

       }

       public Amplifier(Tuner tuner, DvdPlayer dvd, CdPlayer cd)
       {
           this.tuner = tuner;
           this.dvdPlayer = dvd;
           this.cdPlayer = cd;

       }
       public string On()
       {
           return "The CD Player is on";
       }
       public string Off()
       {
           return "The CD Player is off";
       }

       public string SetCd()
       {
           return $"Setting CD {this.cdPlayer}";
       }

       public string SetDvd()
       {
           return $"Setting the DvD Player {this.dvdPlayer}";
       }

       public string SetStereo()
       {
           return $"Setting the Stereo Sound";
       }

       public string SetSurround()
       {
           return $"Setting the Surround Sound";
       }

       public string setTuner()
       {
           return $"Setting the {tuner.ToString()} Tuner";
       }

       public string SetVolume()
       {
           return $"Setting the Volume";
       }

       public override string ToString()
       {
           return base.ToString() + " Amplifier set";

       }
   }
}

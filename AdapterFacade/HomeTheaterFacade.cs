using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO.Pipes;
using System.Text;

namespace AdapterFacade
{
   public class HomeTheaterFacade
   {
       private Amplifier amp;
       private Tuner tuner;
       private DvdPlayer dvd;
       private CdPlayer cdPlayer;
       private Projector projector;
       private TheaterLights lights;
       private Screen screen;
       private Popper popper;

       public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer,
           Projector projector, Screen screen, TheaterLights theaterLights, Popper popcornPopper)
       {
           this.amp = amplifier;
           this.tuner = tuner;
           this.dvd = dvdPlayer;
           this.projector = projector;
           this.screen = screen;
           this.lights = theaterLights;
           this.popper = popcornPopper;
       }


       public string WatchMovie(string movie)
       {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("Getting ready to watch a movie");
           sb.AppendLine(popper.On());
           sb.AppendLine(popper.Pop());
           sb.AppendLine(lights.Dim());
           sb.AppendLine(screen.Down());
           sb.AppendLine(projector.On());
           sb.AppendLine(amp.On());
           sb.AppendLine(amp.SetDvd());
           sb.AppendLine(dvd.SetSurroundAudio());
           sb.AppendLine(amp.SetVolume());
           sb.AppendLine(dvd.On());
           sb.AppendLine(dvd.Play());

           return sb.ToString();

       }

       public string EndMovie()
       {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("Shutting down movie theater");
           sb.AppendLine(popper.Off());
        
           sb.AppendLine(lights.On());
           sb.AppendLine(screen.Up());
           sb.AppendLine(projector.Off());
           sb.AppendLine(amp.Off());
  
           sb.AppendLine(dvd.Stop());
  
           sb.AppendLine(dvd.Eject());
           sb.AppendLine(dvd.Off());

           return sb.ToString();

       }
   }
}

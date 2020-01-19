using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdapterFacade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacadeController : ControllerBase
    {
        // GET: api/Facade
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Facade/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
           // return "value";
           Amplifier baseAmplifier = new Amplifier();

          Tuner tuner = new Tuner(baseAmplifier);
          DvdPlayer dvd = new DvdPlayer(baseAmplifier);
          CdPlayer cdPlayer = new CdPlayer(baseAmplifier);

           Amplifier amp = new Amplifier(tuner, dvd, cdPlayer);
           HomeTheaterFacade facade = new HomeTheaterFacade(amp, tuner, dvd, cdPlayer, new Projector(dvd), new Screen(),
               new TheaterLights(), new Popper());

           if (id % 2 == 0)
           {
               return facade.WatchMovie("Raiders");
           }
           else
           {
              return facade.EndMovie();
           }
        }

        // POST: api/Facade
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Facade/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

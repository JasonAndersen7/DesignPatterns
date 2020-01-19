using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesignPatterns.Command;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {

        static List<string> actionsTaken = new List<string>();

        Remote remoteControl = new Remote();

        public CommandController()
        {
                      
            string house = " house ";

            //clients 
            Alarm houseAlarm = new Alarm(house);
            CeilingFan ceilingFan = new CeilingFan(house);
            GarageDoor garageDoor = new GarageDoor(house);
            Hottub hottub = new Hottub();
            Light light = new Light(house);
            Stereo stereo = new Stereo(house);

            //set up Remote Control
            remoteControl.SetCommand(0, new AlarmOnCommand(houseAlarm), new AlarmOffCommand(houseAlarm));
            remoteControl.SetCommand(1, new CeilingFanOnCommand(ceilingFan), new CeilingFanOffCommand(ceilingFan));
            remoteControl.SetCommand(2, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));
            remoteControl.SetCommand(3, new HottubOnCommand(hottub), new HottubOffCommand(hottub));
            remoteControl.SetCommand(4, new StereoOnWithCDCommand(stereo), new StereoOffCommand(stereo));

        }


        // GET: api/Command
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };

            return actionsTaken;
        }

        // GET: api/Command/5
        [HttpGet("{id}", Name = "GetCommand")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Command
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Command/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            actionsTaken.Add(remoteControl.OnButtonWasPushed(id).ToString());
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            actionsTaken.RemoveAt(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRTest.Controllers
{

    [Route("api/[controller]")]
    public class DemoController : Controller
    {
        public IHubContext<ChatHub> Myhub { get; }
        public DemoController(IHubContext<ChatHub> myhub)
        {
            Myhub = myhub;
        }

       

        [Route("getlist")]
        [HttpGet]
        public async Task<IActionResult>  Getlist()
        {
        
          
            Dictionary<string, string> Listname = new Dictionary<string, string>()
            {
                ["toto"] = "my mom",        
                ["nono"] = "my friend",
                ["titi"] = "my uncle",
                ["lolo"] = "my nephew",
            };

            foreach(var i in Listname)
            {

                 await Myhub.Clients.All.SendAsync("ReceiveMessage", i.Key, i.Value);     
                 
            }
            return Ok("done");
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
    



        public EventoController(ILogger<EventoController> logger)
        {
           
        }

        [HttpGet]
        public string Get()
        {
            return "Value";
        }
        
        [HttpPost]
        public string Post()
        {
            return "cuzao do caramba";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"agora tem o metodo put id= {id}";
        }

        [HttpPut("{id}")]
        public string Delete(int id)
        {
            return $"agora tem o Delete put id= {id}";
        }
    }
}

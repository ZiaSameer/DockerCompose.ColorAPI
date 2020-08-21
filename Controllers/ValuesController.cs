using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ColorAPI.Models;

namespace DockerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ColorContext _context;

        public ValuesController(ColorContext context)
        {
            _context = context;
        }



        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Color>> GetColorItems()
        {
            return _context.ColorItems;
        }
        /*
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[]{"value1","value2"};
        }
        */
       
    }
}

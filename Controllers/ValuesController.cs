using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DockerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[]{"value1","value2"};
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Qamar Zia";
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        //PUT api/values/1
        [HttpPut("{id}")]
        public void Put([FromBody] string value)
        {

        }
    }
}

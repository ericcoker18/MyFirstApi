using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private string[] values = new string[] { "value1", "value2", "value3" };

        [HttpGet]
        private IEnumerable<string> Get()
        {
            return values;
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            id--;
            if (id > 2)
            {
                return NotFound();
            }

            return Ok(values[id]);



        }
    }
}


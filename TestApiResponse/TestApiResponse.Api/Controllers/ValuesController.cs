using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestApiResponse.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : BaseController
    {
        [HttpGet]
        public IActionResult Ok()
        {
            return BaseResponse<string>(HttpStatusCode.OK, "ok result");
        }

        [HttpGet]
        public IActionResult Error()
        {
            return BaseResponse<string>(HttpStatusCode.InternalServerError, "InternalServerError result");
        }

        [HttpGet]
        public IActionResult NotFound()
        {
            return BaseResponse<string>(HttpStatusCode.NotFound, "NotFound result");
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

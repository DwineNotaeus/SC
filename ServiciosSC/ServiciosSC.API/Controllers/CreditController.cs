using Microsoft.AspNetCore.Mvc;
using ServiciosSC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiciosSC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditController : ControllerBase
    {
        private readonly ICredit _credit;
        public CreditController(ICredit credit)
        {
            _credit = credit;
        }


        // GET: api/<CreditController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        [HttpGet]
        public IActionResult Get()
        {
            var post = _credit.GetListOfAllCredits();
            return Ok(post);
        }

        // GET api/<CreditController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CreditController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CreditController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CreditController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

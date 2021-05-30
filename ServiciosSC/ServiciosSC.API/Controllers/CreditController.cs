using Microsoft.AspNetCore.Mvc;
using ServiciosSC.Core.DTOs;
using ServiciosSC.Core.Entities;
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
        private readonly ICreditService _credit;
        public CreditController(ICreditService credit)
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


        [HttpGet("getTypeDocument")]
        public async Task<IEnumerable<IdentificationTypeDTO>> GetListTypeContact()
        {
             return await _credit.GetListTypeDocument();
            
        }

        // POST api/<CreditController>
        [HttpPost("createCredits")]
        public async Task<IActionResult> createCredits([FromBody] CreditByClientDTO model)
        {
            await _credit.CreateCredit(model);
            return Ok(model);
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

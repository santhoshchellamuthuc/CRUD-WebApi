using CRUDAPILibrary;
using DapperData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        HospitalRepostory refer;
        public HospitalController()
        {
            refer = new HospitalRepostory();
        }
        // GET: api/<HospitalController>
        [HttpGet]
        public IEnumerable<HospitalDetails> Get()
        {
            return refer.Hospitalshow();
        }

        // GET api/<HospitalController>/5
        [HttpGet("{Serching}")]
        public string Get(  string set)
        {
            return refer.HospitalSearch(set);
        }

        // POST api/<HospitalController>
        [HttpPost]
        public void Post([FromBody] HospitalDetails value)
        {
            refer.HospitalLogin(value);
        }

        // PUT api/<HospitalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HospitalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

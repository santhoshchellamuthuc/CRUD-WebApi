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
        public IEnumerable<HospitalDetails> Get( string name)
        {
            return refer.Hospitalsearch(name);
        }

        // POST api/<HospitalController>
        [HttpPost]
        public void Post([FromBody] HospitalDetails value)
        {
            refer.HospitalLogin(value);
        }

        // PUT api/<HospitalController>/5
        [HttpPut("{Edit}")]
        public void Put(long Id,string name, [FromBody] HospitalDetails value)
        {
            refer.HospitalEdit(Id, name);
        }

        // DELETE api/<HospitalController>/5
        [HttpDelete("{Id}")]
        public void Delete(int id)
        {
            refer.HospitalRemove(id);
        }
    }
}

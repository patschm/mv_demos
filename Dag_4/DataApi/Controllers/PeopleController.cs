using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private PeopleRepository _people;

        public PeopleController(PeopleRepository people)
        {
            _people = people;
        }

        [HttpGet]
        public List<Person> Get()
        {
            return _people.GetAll();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person p)
        {
            var pins = _people.Insert(p);
            return Created($"api/people", p.Id);
        }
    }
}

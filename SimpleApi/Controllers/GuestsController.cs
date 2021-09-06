using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<GuestsModel> guests = new()
        {
            new GuestsModel { Id = 1, FirstName = "van", LastName = "Nguyen" },
            new GuestsModel { Id = 2, FirstName = "lynda", LastName = "Carter" },
            new GuestsModel { Id = 3, FirstName = "shrek", LastName = "Swamp" }
        };
        
        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<GuestsModel> Get()
        {
            return guests;
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public GuestsModel Get(int id)
        {
            return guests.Where(g => g.Id == id).FirstOrDefault();
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] GuestsModel value)
        {
            guests.Add(value);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GuestsModel value)
        {
            guests.Remove(guests.Where(g => g.Id == id).FirstOrDefault());
            guests.Add(value);
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")] 
        public void Delete(int id)
        {
          guests.Remove(guests.Where(g => g.Id == id).FirstOrDefault());

        }
    }
}

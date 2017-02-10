using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : ApiController
    {
        static List<Person> _persons;

        public PersonController()
        {

        }

        static PersonController()
        {
            _persons = new List<Person>();
            _persons.Add(new Person() { Id = 1, Age = 20, Name = "Nikhil" });
            _persons.Add(new Person() { Id = 2, Age = 30, Name = "Neha" });
            _persons.Add(new Person() { Id = 3, Age = 40, Name = "Renu" });
        }
        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            return _persons;
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}

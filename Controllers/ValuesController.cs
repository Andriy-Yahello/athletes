using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.api.Models;

namespace Test.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Athlete>> Get()
        {
            var list = new List<Athlete>();
            using (var db = new AthleteContext())
            {
                //db.Athletes.Remove(db.Athletes.Where(_ => _.Name == "a").FirstOrDefault());
                
                if (db.Athletes == null || !db.Athletes.Where(_ => _.Name == "a").Any())
                    db.Athletes.Add(new Athlete { Name = "a", Country = "b", Time = new DateTime(1979, 07, 28,08,06,30)});
                
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Athletes)
                {
                    Console.WriteLine("blog.Time - {0}", blog.Time);
                }

               list = db.Athletes.ToList();
            }

            return list;
            
            // return new Athlete[] 
            // { 
            //    new Athlete { Name = "a", Country = "b", Time = new DateTime(1979, 07, 28,08,06,30)}
            // };
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

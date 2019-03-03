using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace yogablogapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<BlogItem>> Get()
        {
            return new BlogItem[] {
                new BlogItem
                {
                    Title = "title 1", 
                    Text = "text text text texttext texttext texttext texttext texttext texttext texttext texttext texttext texttext texttext texttext text",
                    PictureURL = "https://i0.wp.com/dailycupofyoga.com/wp-content/uploads/2016/02/affirmation-silvia.png?resize=300%2C296"
                }
            };
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

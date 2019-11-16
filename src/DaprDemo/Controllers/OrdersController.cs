using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaprDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaprDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/Orders
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public Order Get(string id)
        {
            return new Order()
            {
                ID = id
            };
        }

        // POST: api/Orders
        [HttpPost]
        public void Post([FromBody] Order value)
        {
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Order value)
        {
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}

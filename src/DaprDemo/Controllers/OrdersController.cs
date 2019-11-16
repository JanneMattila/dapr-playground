using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapr;
using DaprDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaprDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly StateClient _stateClient;

        public OrdersController(StateClient stateClient)
        {
            _stateClient = stateClient;
        }

        // GET: api/Orders
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Order> Get(string id)
        {
            var order = await _stateClient.GetStateAsync<Order>(id);
            return order;
        }

        // POST: api/Orders
        [HttpPost]
        public async Task Post([FromBody] Order value)
        {
            await _stateClient.SaveStateAsync(value.ID, value);
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] Order value)
        {
            await _stateClient.SaveStateAsync(id, value);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _stateClient.SaveStateAsync<Order>(id, null);
        }
    }
}

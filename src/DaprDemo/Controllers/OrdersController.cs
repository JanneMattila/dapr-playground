namespace DaprDemo.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dapr;
    using DaprDemo.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly StateClient _stateClient;

        public OrdersController(ILogger<OrdersController> logger, StateClient stateClient)
        {
            _logger = logger;
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

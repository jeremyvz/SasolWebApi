using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SasolWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SasolWebApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class StoreLocatorController : ControllerBase
    {
        private readonly ILogger<StoreLocatorController> _logger;
        private readonly IStoreLocatorService _storeLocatorService;

        public StoreLocatorController(ILogger<StoreLocatorController> logger, IStoreLocatorService storeLocatorService)
        {
            _logger = logger;
            _storeLocatorService = storeLocatorService;
        }

        // GET: api/<StoreLocatorController>
        [HttpGet]
        public IEnumerable<string> GetStores()
        {
            return _storeLocatorService.GetStores();
        }

        // GET api/<StoreLocatorController>/5
        [HttpGet("{id}")]
        public string Get(long id)
        {
            return _storeLocatorService.GetStore(id);
        }

        // POST api/<StoreLocatorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}

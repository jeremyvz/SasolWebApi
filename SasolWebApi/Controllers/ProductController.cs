using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SasolWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SasolWebApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        [Route("getproducts")]
        public List<string> Get()
        {
            return _productService.GetProducts();
        }

        [HttpGet]
        [Route("getproductsbystore")]
        public List<string> Get(long storeId)
        {
            return _productService.GetProductsByStore(storeId);
        }
    }
}

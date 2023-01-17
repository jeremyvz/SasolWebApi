using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SasolWebApi.Services
{
    public interface IProductService
    {
        List<string> GetProducts();
        List<string> GetProductsByStore(long storeId);

    }

    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public List<string> GetProducts()
        {
            return new List<string>();
        }

        public List<string> GetProductsByStore(long storeId)
        {
            return new List<string>();
        }
    }
}

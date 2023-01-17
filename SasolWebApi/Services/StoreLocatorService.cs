using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SasolWebApi.Services
{
    public interface IStoreLocatorService
    {
        List<string> GetStores();
        string GetStore(long storeId);
    }

    public class StoreLocatorService : IStoreLocatorService
    {
        private readonly ILogger<StoreLocatorService> _logger;

        public StoreLocatorService(ILogger<StoreLocatorService> logger)
        {
            _logger = logger;
        }

        public List<string> GetStores()
        {
            return new List<string> { "Sasol 1", "Sasol 2" };
        }

        public string GetStore(long storeId)
        {
            return "";
        }
    }
}

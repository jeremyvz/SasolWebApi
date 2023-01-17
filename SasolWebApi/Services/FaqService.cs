using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SasolWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SasolWebApi.Services
{
    public interface IFaqService
    {
        List<Faq> GetFaqs();
    }

    public class FaqService : IFaqService
    {
        private readonly ILogger<FaqService> _logger;

        public FaqService(ILogger<FaqService> logger)
        {
            _logger = logger;
        }

        public List<Faq> GetFaqs()
        {
            return new List<Faq>();
        }
    }
}

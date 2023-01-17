using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SasolWebApi.Models;
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
    public class FaqController : ControllerBase
    {
        private readonly ILogger<FaqController> _logger;
        private readonly IFaqService _faqService;

        public FaqController(ILogger<FaqController> logger, IFaqService faqService)
        {
            _logger = logger;
            _faqService = faqService;
        }

        // GET: api/<FaqController>
        [HttpGet]
        [Route("getfaqs")]

        public List<Faq> Get()
        {
            return _faqService.GetFaqs();
        }
    }
}

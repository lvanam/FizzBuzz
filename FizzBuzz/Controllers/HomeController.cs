using FizzBuzz.Processor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<FizzBuzzModel> Post([FromBody] Payload payload)
        {
            var numbers = payload.Data.Split(",");
            
            var result =  numbers.Select(number => new FizzBuzzModel
            {
                Number = !string.IsNullOrWhiteSpace(number) && !string.IsNullOrEmpty(number) ? number : "<Empty>",
                Result = GetResult(number)
            }).ToArray();

            return result;
        }

        private IEnumerable<string> GetResult(string number)
        {
            using (Calculate cal = new Calculate())
            {
                var list = new List<string> { cal.CalcualteNumber(new BuzzProcess(number)), cal.CalcualteNumber(new FizzProcess(number)) };
                return list.Distinct();
            }
        }
        
    }

    public class Payload
    {
        public string Data { get; set; }
    }
}

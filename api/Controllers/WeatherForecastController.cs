using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Data;
namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context)
        {
            _context = context;
        }
    


        [HttpGet]
        public IActionResult GetValues()
        { 
            var values = _context.Values.ToList();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public ActionResult<string> Get(int id)
        {
           return $"asd{id}";
        }
    }
}

using Catalog.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {

        private readonly ILogger<StockController> _logger;

        public StockController(ILogger<StockController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var file = FileExtensions.Zip(@"D:\Templates");
            return Ok();
        }
    }
}
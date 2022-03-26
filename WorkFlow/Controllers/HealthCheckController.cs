using Microsoft.AspNetCore.Mvc;

namespace WorkFlow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {

        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogError("DAINT Test LogError");
            _logger.LogInformation("DAINT Test LogInformation");
            _logger.LogCritical("DAINT Test LogCritical");
            _logger.LogTrace("DAINT Test LogTrace");
            _logger.LogWarning("DAINT Test LogWarning");
            return Ok();
        }
    }
}
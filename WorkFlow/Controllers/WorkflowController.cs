using Microsoft.AspNetCore.Mvc;

namespace WorkFlow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkflowController : ControllerBase
    {

        private readonly ILogger<WorkflowController> _logger;

        public WorkflowController(ILogger<WorkflowController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
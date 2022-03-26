using EasyNetQ;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.Models.Messages;
using WorkFlow.Extensions.RabbitMQ;

namespace WorkFlow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkflowController : ControllerBase
    {

        private readonly ILogger<WorkflowController> _logger;
        private readonly IBus _bus;

        public WorkflowController(
            ILogger<WorkflowController> logger,
            IBus bus
            )
        {
            _logger = logger;
            _bus = bus;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            WorkflowModel message = new WorkflowModel()
            {
                Name = "Test"
            };
            await _bus.Publish(message);
            return Ok();
        }
    }
}
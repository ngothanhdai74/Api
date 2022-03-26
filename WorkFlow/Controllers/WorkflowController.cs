using EasyNetQ;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.Models.Messages;

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
            Message<WorkflowModel> message = new Message<WorkflowModel>(new WorkflowModel());
            await _bus.PubSub.PublishAsync(message);
            return Ok();
        }
    }
}
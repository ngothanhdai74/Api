using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.Helpers;

namespace WorkFlow.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            try
            {
                
                using (var ms = new MemoryStream())
                {

                    file.CopyTo(ms);

                    var ress = ms.WordToFullText();

                }
            }
            catch (Exception ex)
            {
            }
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
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
                
                using (var memory = new MemoryStream())
                {
                    file.CopyTo(memory);

                    var document = new Aspose.Words.Document(memory);

                    var res = document.Save(@"C:\Users\User\source\repos\Api\WorkFlow\Logs\dai.pdf", Aspose.Words.SaveFormat.Pdf);

                }
            }
            catch (Exception ex)
            {
            }
            return Ok();
        }
    }
}

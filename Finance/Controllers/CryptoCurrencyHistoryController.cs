using Microsoft.AspNetCore.Mvc;
namespace Finance.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CryptoCurrencyHistoryController : ControllerBase
    {
        private readonly AppServices.CryptoCurrencyHistoryAppService.IAppService _appService;
        public CryptoCurrencyHistoryController(
            AppServices.CryptoCurrencyHistoryAppService.IAppService appService
            )
        {
            _appService = appService;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

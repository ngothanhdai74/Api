using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Finance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ETFController : ControllerBase
    {
        private readonly AppServices.ETFAppService.IAppService _appService;
        public ETFController(
            AppServices.ETFAppService.IAppService appService
            )
        {
            _appService = appService;
        }
        // GET: api/<ETFController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ETFController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ETFController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ETFController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ETFController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

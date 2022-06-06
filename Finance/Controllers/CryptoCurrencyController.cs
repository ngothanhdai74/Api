﻿using Microsoft.AspNetCore.Mvc;
namespace Finance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoCurrencyController : ControllerBase
    {
        private readonly AppServices.CryptoCurrencyAppService.IAppService _appService;
        public CryptoCurrencyController(
            AppServices.CryptoCurrencyAppService.IAppService appService
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

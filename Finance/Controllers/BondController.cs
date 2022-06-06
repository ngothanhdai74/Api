﻿using Microsoft.AspNetCore.Mvc;
namespace Finance.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BondController : ControllerBase
    {
        private readonly AppServices.BondAppService.IAppService _appService;
        public BondController(
            AppServices.BondAppService.IAppService appService
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

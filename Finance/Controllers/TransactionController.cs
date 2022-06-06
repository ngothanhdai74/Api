﻿using Microsoft.AspNetCore.Mvc;
using Finance.Models.BizModels.Transaction;

namespace Finance.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly AppServices.TransactionAppService.IAppService _appService;
        public TransactionController(
            AppServices.TransactionAppService.IAppService appService
            )
        {
            _appService = appService;
        }
        [HttpGet]
        public async Task<IActionResult> Filter([FromBody] Filter model)
        {
            try
            {
                var response = await _appService.Filter(model);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            try
            {
                var response = await _appService.Get(code);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] New model)
        {
            try
            {
                var response = await _appService.Post(model);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Edit model)
        {
            try
            {
                var response = await _appService.Put(model);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            try
            {
                var response = await _appService.Delete(code);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

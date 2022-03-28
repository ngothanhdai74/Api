using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.Models.User;

namespace WorkFlow.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AutoMapperTestController : ControllerBase
    {
        public readonly IMapper _mapper;
        public AutoMapperTestController(
        IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Upload(UserDto user)
        {
            try
            {
                var _mappedUser = _mapper.Map<User>(user);
                return Ok(_mappedUser);
            }
            catch (Exception ex)
            {
            }
            return Ok();

        }
    }
}

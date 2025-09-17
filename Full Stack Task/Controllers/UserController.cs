using Business.Interfaces;
using Full_Stack_Task.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Full_Stack_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            try
            {
                var user = userService.Register(dto);
                return Ok("Registered Successfully");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            try
            {
                var token = userService.Login(loginDto);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

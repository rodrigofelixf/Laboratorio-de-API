using Lab.Business.Security;
using Lab.Domain.Model;
using Lab.Domain.Model.EmployeeAggregate;
using Microsoft.AspNetCore.Mvc;


namespace Lab.Api.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {

        [HttpPost]
        public IActionResult Auth(String username, string password)
        {
            if (username == "felipe" && password == "123456") 
            {
                var token = TokenService.GenerateToken(new Employee());
                return Ok(token);
            }

            return BadRequest("Username or password invalid");
        }
    }
}

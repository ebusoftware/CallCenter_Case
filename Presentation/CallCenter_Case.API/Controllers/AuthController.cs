using Application.CallCenter_Case.Dtos.RefreshToken;
using Application.CallCenter_Case.Dtos.User;
using Application.CallCenter_Case.Features.Commands.RefreshTokenLogin;
using Application.CallCenter_Case.Features.Commands.User.LoginUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommand loginUserCommand)
        {
            TokenUserDTO response = await Mediator.Send(loginUserCommand);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshTokenLogin([FromBody] RefreshTokenLoginCommand refreshTokenLoginCommand)
        {
            RefreshTokenDTO response = await Mediator.Send(refreshTokenLoginCommand);
            return Ok(response);
        }
    }
}

using Application.CallCenter_Case.Dtos.User;
using Application.CallCenter_Case.Features.Commands.User.AssignRoleToUser;
using Application.CallCenter_Case.Features.Commands.User.CreateUser;
using Application.CallCenter_Case.Features.Commands.User.DeleteUser;
using Application.CallCenter_Case.Features.Queries.User.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        //Commands

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand createUserCommand)
        {
            CreateUserDTO response = await Mediator.Send(createUserCommand);
            return Ok(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(DeleteUserCommand deleteUserCommand)
        {
            DeleteUserDTO response = await Mediator.Send(deleteUserCommand);
            return Ok(response);
        }

        [HttpPost("assign-role-to-user")]
        public async Task<IActionResult> AssignRoleToUser(AssignRoleToUserCommand assignRoleToUserCommand)
        {
            AssignRoleToUserDTO response = await Mediator.Send(assignRoleToUserCommand);
            return Ok(response);
        }

        //Queries

        [HttpGet]
        public async Task<IActionResult> GetAllUsers([FromQuery] GetAllUserQuery getAllUserQuery)
        {
            GetAllUserDTO response = await Mediator.Send(getAllUserQuery);
            return Ok(response);
        }
    }
}

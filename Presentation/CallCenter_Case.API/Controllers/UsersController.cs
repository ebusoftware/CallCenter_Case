﻿using Application.CallCenter_Case.Dtos.User;
using Application.CallCenter_Case.Features.Commands.User.AssignRoleToUser;
using Application.CallCenter_Case.Features.Commands.User.CreateUser;
using Application.CallCenter_Case.Features.Commands.User.DeleteUser;
using Application.CallCenter_Case.Features.Queries.User.GetAllUser;
using Application.CallCenter_Case.Features.Queries.User.GetByUserId;
using Application.CallCenter_Case.Features.Queries.User.GetRoleFilterByUserName;
using Application.CallCenter_Case.Features.Queries.User.GetRolesToUser;
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
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci,Müşteri")]

        public async Task<IActionResult> DeleteUser(DeleteUserCommand deleteUserCommand)
        {
            DeleteUserDTO response = await Mediator.Send(deleteUserCommand);
            return Ok(response);
        }

        [HttpPost("assign-role-to-user")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin")]

        public async Task<IActionResult> AssignRoleToUser(AssignRoleToUserCommand assignRoleToUserCommand)
        {
            AssignRoleToUserDTO response = await Mediator.Send(assignRoleToUserCommand);
            return Ok(response);
        }

        //Queries

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> GetAllUsers([FromQuery] GetAllUserQuery getAllUserQuery)
        {
            GetAllUserDTO response = await Mediator.Send(getAllUserQuery);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> GetByUserId([FromRoute] GetByUserIdQuery getByUserIdQuery)
        {
            GetByUserIdDTO response = await Mediator.Send(getByUserIdQuery);
            return Ok(response);
        }


        [HttpGet("get-roles-to-user/{UserId}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]
        public async Task<IActionResult> GetRolesToUser([FromRoute] GetRolesToUserQuery getRolesToUserQuery)
        {
            GetRolesToUserQueryDTO response = await Mediator.Send(getRolesToUserQuery);
            return Ok(response);
        }

        [HttpGet("get-users-filter-role-name")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]
        public async Task<IActionResult> GetUsersFilterByRoleName([FromQuery] GetRoleFilterByUserNameQuery getRoleFilterByUserNameQuery)
        {
            GetRoleFilterByUserNameDTO response = await Mediator.Send(getRoleFilterByUserNameQuery);
            return Ok(response);
        }

    }
}

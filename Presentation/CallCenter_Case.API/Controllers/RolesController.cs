using Application.CallCenter_Case.Dtos.Role;
using Application.CallCenter_Case.Features.Commands.Role.CreateRole;
using Application.CallCenter_Case.Features.Commands.Role.DeleteRole;
using Application.CallCenter_Case.Features.Commands.Role.UpdateRole;
using Application.CallCenter_Case.Features.Queries.Role.GetAllRole;
using Application.CallCenter_Case.Features.Queries.Role.GetByIdRole;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]
    public class RolesController : BaseController
    {
        //Coomands
        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleCommand createRoleCommand)
        {
            CreateRolDTO response = await Mediator.Send(createRoleCommand);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteRole([FromRoute] DeleteRolCommand deleteRolCommand)
        {
            DeleteRolDTO response = await Mediator.Send(deleteRolCommand);
            return Ok(response);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateRole([FromBody, FromRoute] UpdateRoleCommand updateRoleCommand)
        {
            UpdateRoleDTO response = await Mediator.Send(updateRoleCommand);
            return Ok(response);
        }

        //Queries
        [HttpGet]
        public async Task<IActionResult> GetAllRoles([FromQuery] GetAllRoleQuery getAllRoleQuery)
        {
            GetAllRoleDTO response = await Mediator.Send(getAllRoleQuery);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdRole ([FromRoute] GetByIdRoleQuery getByIdRoleQuery)
        {
            GetByIdRoleDTO response = await Mediator.Send(getByIdRoleQuery);
            return Ok(response);
        }
    }
}

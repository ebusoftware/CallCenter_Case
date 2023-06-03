using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Features.Commands;
using Application.CallCenter_Case.Features.Queries.Request.GetAllRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : BaseController
    {
        //Commands
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Admin")]

        public async Task<IActionResult> CreateRequest([FromBody] CreateRequestCommand createRequestCommand)
        {
            CreateRequestDTO requestDTO = await Mediator.Send(createRequestCommand);
            return Ok(requestDTO);
        }
        [HttpDelete("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> DeleteRequest([FromRoute] DeleteRequestCommand deleteRequestCommand)
        {
            DeleteRequestDTO requestDTO = await Mediator.Send(deleteRequestCommand);
            return Ok(requestDTO);
        }
        [HttpPut("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> CreateResponseTime([FromRoute] CreateRequestResponseTimeCommand createResponseTimeCommand)
        {
            CreateRequestResponseTimeDTO requestDTO = await Mediator.Send(createResponseTimeCommand);
            return Ok(requestDTO);
        }

        [HttpPut("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> UpdateRequestStatus([FromRoute] UpdateRequestStatusCommand updateRequestStatusCommand)
        {
            UpdateRequestStatusDTO requestDTO = await Mediator.Send(updateRequestStatusCommand);
            return Ok(requestDTO);
        }
        //Queries
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]
        [HttpGet]
        public async Task<IActionResult> GetAllRequest([FromRoute] GetAllRequestQuery getAllRequestQuery)
        {
            GetAllRequestDTO requestDTO = await Mediator.Send(getAllRequestQuery);
            return Ok(requestDTO);
        }
    }
}

using Application.CallCenter_Case.Dtos.CallRecord;
using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Features;
using Application.CallCenter_Case.Features.Commands;
using Application.CallCenter_Case.Features.Queries.CallRecord.GetAllCallRecord;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallRecordsController : BaseController
    {
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Admin")]

        public async Task<IActionResult> CreateCallRecord([FromBody] CreateCallRecordCommand createCallRecordCommand)
        {
            CreateCallRecordDTO callRecordDTO = await Mediator.Send(createCallRecordCommand);
            return Ok(callRecordDTO);
        }

        [HttpDelete("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci,")]

        public async Task<IActionResult> DeleteCallRecord([FromRoute] DeleteCallRecordCommand deleteCallRecordCommand)
        {
            DeleteCallRecordDTO requestDTO = await Mediator.Send(deleteCallRecordCommand);
            return Ok(requestDTO);
        }

        [HttpPost("[action]/{id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> CreateReply([FromRoute] int id, [FromQuery] string reply)
        {
            
            var createReplyCommand = new CreateReplyCommand 
            { 
                Id = id,
                Reply = reply,
                RepresentativeId = User.Claims.Where(e => e.Type == ClaimTypes.NameIdentifier).Select(e => e.Value).FirstOrDefault()
            };
            CreateReplyDTO requestDTO = await Mediator.Send(createReplyCommand);
            return Ok(requestDTO);
        }

        //Queries


        [HttpGet]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> GetAllCallRecord([FromQuery] GetAllCallRecordQuery getAllCallRecordQuery)
        {
            GetAllCallRecordDTO callRecordDTO = await Mediator.Send(getAllCallRecordQuery);
            return Ok(callRecordDTO);
        }

        [HttpGet("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Temsilci")]

        public async Task<IActionResult> FilterByRepresentative([FromRoute] FilterByRepresentativeQuery filterByRepresentativeQuery)
        {
            FilterByRepresentativeDTO filterByRepresentativeDTO = await Mediator.Send(filterByRepresentativeQuery);
            return Ok(filterByRepresentativeDTO);
        }
    }
}

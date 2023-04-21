using Application.CallCenter_Case.Dtos.CallRecord;
using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Features.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallRecordsController : BaseController
    {
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Yönetici,Müşteri")]

        public async Task<IActionResult> CreateCallRecord([FromBody]CreateCallRecordCommand createCallRecordCommand)
        {
            CreateCallRecordDTO callRecordDTO = await Mediator.Send(createCallRecordCommand);
            return Ok(callRecordDTO);
        }

        [HttpDelete("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Yönetici,Müşteri")]

        public async Task<IActionResult> DeleteCallRecord([FromRoute] DeleteCallRecordCommand deleteCallRecordCommand)
        {
            DeleteCallRecordDTO requestDTO = await Mediator.Send(deleteCallRecordCommand);
            return Ok(requestDTO);
        }
        [HttpPut("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin", Roles = "Admin,Yönetici")]

        public async Task<IActionResult> CreateResponseTime([FromRoute] CreateCallRecordResponseTimeCommand createCallRecordResponseTimeCommand)
        {
            CreateCallRecordResponseTimeDTO requestDTO = await Mediator.Send(createCallRecordResponseTimeCommand);
            return Ok(requestDTO);
        }
    }
}

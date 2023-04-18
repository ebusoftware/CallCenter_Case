using Application.CallCenter_Case.Dtos.CallRecord;
using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Features.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallRecordsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> CreateCallRecord([FromBody]CreateCallRecordCommand createCallRecordCommand)
        {
            CreateCallRecordDTO callRecordDTO = await Mediator.Send(createCallRecordCommand);
            return Ok(callRecordDTO);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteCallRecord([FromRoute] DeleteCallRecordCommand deleteCallRecordCommand)
        {
            DeleteCallRecordDTO requestDTO = await Mediator.Send(deleteCallRecordCommand);
            return Ok(requestDTO);
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> CreateResponseTime([FromRoute] CreateCallRecordResponseTimeCommand createCallRecordResponseTimeCommand)
        {
            CreateCallRecordResponseTimeDTO requestDTO = await Mediator.Send(createCallRecordResponseTimeCommand);
            return Ok(requestDTO);
        }
    }
}

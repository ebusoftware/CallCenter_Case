﻿using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Features.Commands;
using Application.CallCenter_Case.Features.Queries.Request.GetAllRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallCenter_Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : BaseController
    {
        //Commands
        [HttpPost]
        public async Task<IActionResult> CreateRequest([FromBody] CreateRequestCommand createRequestCommand)
        {
            CreateRequestDTO requestDTO = await Mediator.Send(createRequestCommand);
            return Ok(requestDTO);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteRequest([FromRoute] DeleteRequestCommand deleteRequestCommand)
        {
            DeleteRequestDTO requestDTO = await Mediator.Send(deleteRequestCommand);
            return Ok(requestDTO);
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> CreateResponseTime([FromRoute] CreateResponseTimeCommand createResponseTimeCommand)
        {
            CreateResponseTimeDTO requestDTO = await Mediator.Send(createResponseTimeCommand);
            return Ok(requestDTO);
        }

        //Queries
        [HttpGet]
        public async Task<IActionResult> GetAllRequest([FromRoute] GetAllRequestQuery getAllRequestQuery)
        {
            GetAllRequestDTO requestDTO = await Mediator.Send(getAllRequestQuery);
            return Ok(requestDTO);
        }
    }
}

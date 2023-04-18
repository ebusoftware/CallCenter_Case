using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Queries.Request.GetAllRequest
{
    public class GetAllRequestQuery:IRequest<GetAllRequestDTO>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;

        public class GetAllRequestQueryHandler : IRequestHandler<GetAllRequestQuery, GetAllRequestDTO>
        {
            private readonly IRequestReadRepository _requestReadRepository;

            public GetAllRequestQueryHandler(IRequestReadRepository requestReadRepository)
            {
                _requestReadRepository = requestReadRepository;
            }

            public async Task<GetAllRequestDTO> Handle(GetAllRequestQuery request, CancellationToken cancellationToken)
            {
                var totalRequestCount = _requestReadRepository.GetAll(false).Count();

                var datas = _requestReadRepository.GetAll(false)
                    .Skip(request.Page * request.Size).Take(request.Size)
                    .Include(e => e.AppUser)
                    .Select(e => new
                    {
                        e.Id,
                        e.Status,
                        e.AppUser.NameSurname,
                        e.CreatedDate,
                        e.RequestType,
                        e.ResponseTime
                    }).ToList();
                return new()
                {
                    Requests = datas,
                    TotalCount=totalRequestCount
                };
            }
        }
    }
}

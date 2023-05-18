using Application.CallCenter_Case.Dtos.CallRecord;
using Application.CallCenter_Case.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features
{
    public class FilterByRepresentativeQuery:IRequest<FilterByRepresentativeDTO>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
        public string Id { get; set; }

        public class FilterByRepresentativeQueryHandler : IRequestHandler<FilterByRepresentativeQuery, FilterByRepresentativeDTO>
        {
            private readonly ICallRecordReadRepository _callRecordReadRepository;

            public FilterByRepresentativeQueryHandler(ICallRecordReadRepository callRecordReadRepository)
            {
                _callRecordReadRepository = callRecordReadRepository;
            }

            public async Task<FilterByRepresentativeDTO> Handle(FilterByRepresentativeQuery request, CancellationToken cancellationToken)
            {
                var totalCallRecordCount = _callRecordReadRepository.GetAll(false)
                    .Where(e => e.RepresentativeId == request.Id).Count();
                var callRecords = new List<dynamic>();


                var datas = _callRecordReadRepository.GetAll(false)
                    .Include(e => e.AppUser)
                    .Where(e=>e.RepresentativeId==request.Id)
                    .Skip(request.Page * request.Size).Take(request.Size)
                    .Select(e => new 
                    {
                        e.Id,
                        e.AppUser.NameSurname,
                        e.CreatedDate,
                        e.RequestType,
                        e.ResponseTime,
                        e.Reply,
                        e.Notes,
                        e.RepresentativeId
                    }).ToList();


                foreach (var data in datas)
                {
                    var representative = await _callRecordReadRepository.GetRepresentativeById(data.RepresentativeId);
                    var callRecord = new
                    {
                        data.Id,
                        data.NameSurname,
                        data.CreatedDate,
                        data.RequestType,
                        data.ResponseTime,
                        data.Reply,
                        data.Notes,
                        data.RepresentativeId,
                        RepresentativeName = representative != null ? representative.NameSurname : ""
                    };

                    callRecords.Add(callRecord);
                }

                return new FilterByRepresentativeDTO
                {
                    CallRecords = callRecords,
                    TotalCount = totalCallRecordCount
                };
            }
        }
    }
}

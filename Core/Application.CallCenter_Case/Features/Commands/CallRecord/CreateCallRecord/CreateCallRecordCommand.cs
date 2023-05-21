using Application.CallCenter_Case.Abstractions.Hubs;
using Application.CallCenter_Case.Dtos.CallRecord;
using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Repositories;
using Domain.CallCenter_Case.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands
{
    public class CreateCallRecordCommand:IRequest<CreateCallRecordDTO>
    {
        public string UserId { get; set; }
        public string RequestType { get; set; }
        public string Notes { get; set; }
        public class CreateCallRecordCommandHandler : IRequestHandler<CreateCallRecordCommand, CreateCallRecordDTO>
        {
            private readonly ICallRecordWriteRepository _callRecordWriteRepository;
            private readonly ICallRecordReadRepository _callRecordReadRepository;
            private readonly ICallRecordHubService _callRecordHubService;

            public CreateCallRecordCommandHandler(ICallRecordWriteRepository callRecordWriteRepository, ICallRecordReadRepository callRecordReadRepository, ICallRecordHubService callRecordHubService)
            {
                _callRecordWriteRepository = callRecordWriteRepository;
                _callRecordReadRepository = callRecordReadRepository;
                _callRecordHubService = callRecordHubService;
            }

            public async Task<CreateCallRecordDTO> Handle(CreateCallRecordCommand request, CancellationToken cancellationToken)
            {
                if (request!=null)
                {
                    await _callRecordWriteRepository.AddAsync(new CallRecord()
                    {
                        UserId = request.UserId,
                        Notes = request.Notes,
                        RequestType = request.RequestType,

                });
                await _callRecordHubService.CallRecordAddedMessageAsync($"'{request.RequestType}' Adında Yeni Talep!");

                   
                    return new CreateCallRecordDTO { Message = $"Görüşme Talebi Oluşturuldu." };

                }
                return new CreateCallRecordDTO { Message = $"Talep oluşamadı! ." };

                //await _callRecordWriteRepository.SaveAsync();
            }
        }
    }
}

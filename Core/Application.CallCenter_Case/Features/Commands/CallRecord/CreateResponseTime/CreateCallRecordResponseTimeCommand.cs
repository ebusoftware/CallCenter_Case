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
    public class CreateCallRecordResponseTimeCommand:IRequest<CreateCallRecordResponseTimeDTO>
    {
        public int Id { get; set; }
        public class CreateCallRecordResponseTimeCommandHandler : IRequestHandler<CreateCallRecordResponseTimeCommand, CreateCallRecordResponseTimeDTO>
        {
            private readonly ICallRecordReadRepository _callRecordReadRepository;
            private readonly ICallRecordWriteRepository _callRecordWriteRepository;

            public CreateCallRecordResponseTimeCommandHandler(ICallRecordReadRepository callRecordReadRepository, ICallRecordWriteRepository callRecordWriteRepository)
            {
                _callRecordReadRepository = callRecordReadRepository;
                _callRecordWriteRepository = callRecordWriteRepository;
            }

            public async Task<CreateCallRecordResponseTimeDTO> Handle(CreateCallRecordResponseTimeCommand request, CancellationToken cancellationToken)
            {
                if (request != null)
                {
                    var data = await _callRecordReadRepository.GetByIdAsync(request.Id);
                    if (data != null)
                    {
                        data.ResponseTime = DateTime.UtcNow;
                        await _callRecordWriteRepository.UpdateAsync(data);
                        return new CreateCallRecordResponseTimeDTO() { Message = $"Talebe Dönüş Yapıldı." };
                    }
                    else
                        return new CreateCallRecordResponseTimeDTO() { Message = $"Böyle Bir Talep Mevcut Değil" };
                }
                return new CreateCallRecordResponseTimeDTO() { Message = $"Hatalı İşlem Yapıldı" };
            }
        }
    }
}

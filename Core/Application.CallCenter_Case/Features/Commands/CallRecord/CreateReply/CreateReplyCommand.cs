using Application.CallCenter_Case.Dtos.CallRecord;
using Application.CallCenter_Case.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands
{
    public class CreateReplyCommand:IRequest<CreateReplyDTO>
    {
        public int Id { get; set; }
        public string RepresentativeId { get; set; }
        public string? Reply { get; set; }

        public class CreateReplyCommandHandler : IRequestHandler<CreateReplyCommand, CreateReplyDTO>
        {
            private readonly ICallRecordReadRepository _callRecordReadRepository;
            private readonly ICallRecordWriteRepository _callRecordWriteRepository;

            

            public CreateReplyCommandHandler(ICallRecordReadRepository callRecordReadRepository, ICallRecordWriteRepository callRecordWriteRepository)
            {
                _callRecordReadRepository = callRecordReadRepository;
                _callRecordWriteRepository = callRecordWriteRepository;
            }

            public async Task<CreateReplyDTO> Handle(CreateReplyCommand request, CancellationToken cancellationToken)
            {
                if (request != null)
                {
                    var data = await _callRecordReadRepository.GetByIdAsync(request.Id);
                    if (data != null)
                    {
                        data.Reply = request.Reply;
                        data.RepresentativeId = request.RepresentativeId;
                        data.ResponseTime = DateTime.UtcNow;
                        await _callRecordWriteRepository.UpdateAsync(data);
                        return new CreateReplyDTO() { Message = $"Talebe Cevap Verildi." };
                    }
                    else
                        return new CreateReplyDTO() { Message = $"Böyle Bir Talep Mevcut Değil" };
                }
                return new CreateReplyDTO() { Message = $"Hatalı İşlem Yapıldı" };
            }
        }

    }
}

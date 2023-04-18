using Application.CallCenter_Case.Dtos.CallRecord;
using Application.CallCenter_Case.Dtos.Request;
using Application.CallCenter_Case.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands
{
    public class DeleteCallRecordCommand:IRequest<DeleteCallRecordDTO>
    {
        public int Id { get; set; }
        public class DeleteCallRecordCommandHandler : IRequestHandler<DeleteCallRecordCommand, DeleteCallRecordDTO>
        {
            private readonly ICallRecordReadRepository _callRecordReadRepository;
            private readonly ICallRecordWriteRepository _callRecordWriteRepository;

            public DeleteCallRecordCommandHandler(ICallRecordReadRepository callRecordReadRepository, ICallRecordWriteRepository callRecordWriteRepository)
            {
                _callRecordReadRepository = callRecordReadRepository;
                _callRecordWriteRepository = callRecordWriteRepository;
            }

            public async Task<DeleteCallRecordDTO> Handle(DeleteCallRecordCommand request, CancellationToken cancellationToken)
            {
                if (request != null)
                {
                    var data = await _callRecordReadRepository.GetByIdAsync(request.Id);
                    if (data != null)
                    {
                        await _callRecordWriteRepository.RemoveAsync(data);
                        return new DeleteCallRecordDTO() { Message = $"Görüşme Başarıyla Silindi." };
                    }
                    else
                        return new DeleteCallRecordDTO() { Message = $"Görüşme Bulunamadı!" };
                }
                else
                    return new DeleteCallRecordDTO() { Message = $"İstek Hatası!" };
            }
        }
    }
}

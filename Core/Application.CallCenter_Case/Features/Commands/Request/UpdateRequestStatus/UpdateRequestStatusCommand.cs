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
    public class UpdateRequestStatusCommand:IRequest<UpdateRequestStatusDTO>
    {
        public int Id { get; set; }

        public class UpdateRequestStatusCommandHandler : IRequestHandler<UpdateRequestStatusCommand, UpdateRequestStatusDTO>
        {
            private readonly IRequestWriteRepository _writeRepository;
            private readonly IRequestReadRepository _readRepository;

            public UpdateRequestStatusCommandHandler(IRequestWriteRepository writeRepository, IRequestReadRepository readRepository)
            {
                _writeRepository = writeRepository;
                _readRepository = readRepository;
            }

            public async Task<UpdateRequestStatusDTO> Handle(UpdateRequestStatusCommand request, CancellationToken cancellationToken)
            {

                if (request != null)
                {
                    var data = await _readRepository.GetByIdAsync(request.Id);
                    if (data != null)
                    {
                        switch (data.Status)
                        {
                            case false:
                                data.Status = true;
                                break;
                            case true:
                                data.Status = false;
                                break;
                        }
                        await _writeRepository.UpdateAsync(data);
                        return new UpdateRequestStatusDTO() { Message = $"Talep Durumu Değiştirildi." };
                    }
                    else
                        return new UpdateRequestStatusDTO() { Message = $"Böyle Bir Talep Mevcut Değil" };
                }
                return new UpdateRequestStatusDTO() { Message = $"Hatalı İşlem Yapıldı" };
            }
        }
    }
}

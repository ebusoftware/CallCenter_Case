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
    public class CreateRequestResponseTimeCommand:IRequest<CreateRequestResponseTimeDTO>
    {
        public int Id { get; set; }

        public class CreateResponseTimeCommandHandler : IRequestHandler<CreateRequestResponseTimeCommand, CreateRequestResponseTimeDTO>
        {
            private readonly IRequestWriteRepository _writeRepository;
            private readonly IRequestReadRepository _readRepository;

            public CreateResponseTimeCommandHandler(IRequestWriteRepository writeRepository, IRequestReadRepository readRepository)
            {
                _writeRepository = writeRepository;
                _readRepository = readRepository;
            }

            public async Task<CreateRequestResponseTimeDTO> Handle(CreateRequestResponseTimeCommand request, CancellationToken cancellationToken)
            {
                if (request!=null)
                {
                    var data = await _readRepository.GetByIdAsync(request.Id);
                    if (data!=null)
                    {
                        data.Status = false;
                        data.ResponseTime = DateTime.UtcNow;
                        await _writeRepository.UpdateAsync(data);
                        return new CreateRequestResponseTimeDTO() { Message = $"Talebe Dönüş Yapıldı."};
                    }
                    else
                        return new CreateRequestResponseTimeDTO() { Message = $"Böyle Bir Talep Mevcut Değil" };
                }
                return new CreateRequestResponseTimeDTO() { Message = $"Hatalı İşlem Yapıldı" };
            }
        }
    }
}

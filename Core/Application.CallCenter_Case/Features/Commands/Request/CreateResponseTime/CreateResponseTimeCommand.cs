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
    public class CreateResponseTimeCommand:IRequest<CreateResponseTimeDTO>
    {
        public int Id { get; set; }

        public class CreateResponseTimeCommandHandler : IRequestHandler<CreateResponseTimeCommand, CreateResponseTimeDTO>
        {
            private readonly IRequestWriteRepository _writeRepository;
            private readonly IRequestReadRepository _readRepository;

            public CreateResponseTimeCommandHandler(IRequestWriteRepository writeRepository, IRequestReadRepository readRepository)
            {
                _writeRepository = writeRepository;
                _readRepository = readRepository;
            }

            public async Task<CreateResponseTimeDTO> Handle(CreateResponseTimeCommand request, CancellationToken cancellationToken)
            {
                if (request!=null)
                {
                    var data = await _readRepository.GetByIdAsync(request.Id);
                    if (data!=null)
                    {
                        data.Status = false;
                        data.ResponseTime = DateTime.UtcNow;
                        await _writeRepository.UpdateAsync(data);
                        return new CreateResponseTimeDTO() { Message = $"Talebe Dönüş Yapıldı."};
                    }
                    else
                        return new CreateResponseTimeDTO() { Message = $"Böyle Bir Talep Mevcut Değil" };
                }
                return new CreateResponseTimeDTO() { Message = $"Hatalı İşlem Yapıldı" };
            }
        }
    }
}

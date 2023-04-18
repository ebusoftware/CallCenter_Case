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
    public class DeleteRequestCommand:IRequest<DeleteRequestDTO>
    {
        public int Id { get; set; }

        public class DeleteRequestCommandHandler : IRequestHandler<DeleteRequestCommand, DeleteRequestDTO>
        {
            private readonly IRequestWriteRepository _writeRepository;
            private readonly IRequestReadRepository _readRepository;

            public DeleteRequestCommandHandler(IRequestWriteRepository writeRepository, IRequestReadRepository readRepository)
            {
                _writeRepository = writeRepository;
                _readRepository = readRepository;
            }

            public async Task<DeleteRequestDTO> Handle(DeleteRequestCommand request, CancellationToken cancellationToken)
            {
                if (request != null) 
                {
                   var data = await _readRepository.GetByIdAsync(request.Id);
                    if (data != null)
                    { 
                       await _writeRepository.RemoveAsync(data);
                        return new DeleteRequestDTO() { Message=$"Talep Başarıyla Silindi."};
                    }
                    else
                        return new DeleteRequestDTO() { Message = $"Kayıt Bulunamadı!" };
                }
                else
                return new DeleteRequestDTO() { Message=$"İstek Hatası!"};
            }
        }
    }
}

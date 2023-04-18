using Application.CallCenter_Case.Dtos.Request;
using Domain.CallCenter_Case.Entities.Identity;
using Domain.CallCenter_Case.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CallCenter_Case.Repositories;

namespace Application.CallCenter_Case.Features.Commands
{
    public class CreateRequestCommand:IRequest<CreateRequestDTO>
    {
        public string UserId { get; set; }
        public string RequestType { get; set; }//talep türü
        public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, CreateRequestDTO>
        {
            private readonly IRequestWriteRepository _requestWriteRepository;

            public CreateRequestCommandHandler(IRequestWriteRepository requestWriteRepository)
            {
                _requestWriteRepository = requestWriteRepository;
            }

            public async Task<CreateRequestDTO> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
            {
                await _requestWriteRepository.AddAsync(new Request()
                {
                    UserId = request.UserId,
                    RequestType = request.RequestType
                });
                await _requestWriteRepository.SaveAsync();
                return new CreateRequestDTO { Message=$"Talebiniz Alınmıştır." };
            }
        }
    }
}

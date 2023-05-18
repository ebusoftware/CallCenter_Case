using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features
{
    public class GetAllRepresentativeQuery:IRequest<GetAllRepresentativeDTO>
    {

        public class GetRepresentativeQueryHandler : IRequestHandler<GetAllRepresentativeQuery, GetAllRepresentativeDTO>
        {
            private readonly IUserService _userService;

            public GetRepresentativeQueryHandler(IUserService userService)
            {
                _userService = userService;
            }

            public Task<GetAllRepresentativeDTO> Handle(GetAllRepresentativeQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}

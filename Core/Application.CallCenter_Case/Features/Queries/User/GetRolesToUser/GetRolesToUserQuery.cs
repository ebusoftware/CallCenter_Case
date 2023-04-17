using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Queries.User.GetRolesToUser
{
    public class GetRolesToUserQuery : IRequest<GetRolesToUserQueryDTO>
    {
        public string UserId { get; set; }

        public class GetRolesToUserQueryHandler : IRequestHandler<GetRolesToUserQuery, GetRolesToUserQueryDTO>
        {
            private readonly IUserService _userService;

            public GetRolesToUserQueryHandler(IUserService userService)
            {
                _userService = userService;
            }

            public async Task<GetRolesToUserQueryDTO> Handle(GetRolesToUserQuery request, CancellationToken cancellationToken)
            {
                var userRoles = await _userService.GetRolesToUserAsync(request.UserId);
                return new()
                {
                    UserRoles = userRoles
                };
            }
        }
    }

}

using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.User;
using Domain.CallCenter_Case.Entities.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Queries.User.GetByUserId
{
    public class GetByUserIdQuery:IRequest<GetByUserIdDTO>
    {
        public string Id { get; set; }
        public class GetByUserIdCommandHandler : IRequestHandler<GetByUserIdQuery, GetByUserIdDTO>
        {
            private readonly IUserService _userService;

            public GetByUserIdCommandHandler(IUserService userService)
            {
                _userService = userService;
            }

            public async Task<GetByUserIdDTO> Handle(GetByUserIdQuery request, CancellationToken cancellationToken)
            {

                AppUser user = await _userService.GetByUserIdAsync(request.Id);
                if(user!=null)
                { 
                return new GetByUserIdDTO()
                {
                    Email = user.Email,
                    UserName = user.UserName,
                    Id = request.Id,
                    NameSurname = user.NameSurname,
                    TwoFactorEnabled = user.TwoFactorEnabled
                };
                }
                return new();
            }
        }
    }
}

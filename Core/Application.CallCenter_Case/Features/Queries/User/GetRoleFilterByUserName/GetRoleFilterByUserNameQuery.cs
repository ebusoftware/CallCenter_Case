using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Queries.User.GetRoleFilterByUserName
{
    public class GetRoleFilterByUserNameQuery:IRequest<GetRoleFilterByUserNameDTO>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
        public string RoleName { get; set; }
        public class GetRoleFilterByUserNameQueryHandler : IRequestHandler<GetRoleFilterByUserNameQuery, GetRoleFilterByUserNameDTO>
        {
            private readonly IUserService _userService;

            public GetRoleFilterByUserNameQueryHandler(IUserService userService)
            {
                _userService = userService;
            }

            public async Task<GetRoleFilterByUserNameDTO> Handle(GetRoleFilterByUserNameQuery request, CancellationToken cancellationToken)
            {
              var (datas,totalCount) = await _userService.FilterByRoleNameAsync(request.Page,request.Size,request.RoleName);
               return new GetRoleFilterByUserNameDTO
               {
                   Datas =datas,
                   TotalCount = totalCount
               };
            }
        }
    }
}

using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.Role;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Queries.Role.GetByIdRole
{
    public class GetByIdRoleQuery : IRequest<GetByIdRoleDTO>
    {
        public string Id { get; set; }

        public class GetByIdRoleQueryHandler : IRequestHandler<GetByIdRoleQuery, GetByIdRoleDTO>
        {
            private readonly IRoleService _roleService;

            public GetByIdRoleQueryHandler(IRoleService roleService)
            {
                _roleService = roleService;
            }

            public async Task<GetByIdRoleDTO> Handle(GetByIdRoleQuery request, CancellationToken cancellationToken)
            {
                var data = await _roleService.GetRoleById(request.Id);
                return new GetByIdRoleDTO()
                {
                    Id = data.id,
                    Name = data.name
                };
            }
        }
    }

}

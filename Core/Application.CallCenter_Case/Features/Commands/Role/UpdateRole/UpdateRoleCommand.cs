using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.Role;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands.Role.UpdateRole
{
    public class UpdateRoleCommand : IRequest<UpdateRoleDTO>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, UpdateRoleDTO>
        {
            private readonly IRoleService _roleService;

            public UpdateRoleCommandHandler(IRoleService roleService)
            {
                _roleService = roleService;
            }

            public async Task<UpdateRoleDTO> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
            {
                var result = await _roleService.UpdateRole(request.Id, request.Name);
                return new()
                {
                    Succeeded = result
                };
            }
        }
    }

}

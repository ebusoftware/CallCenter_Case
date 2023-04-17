using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.Role;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands.Role.DeleteRole
{
    public class DeleteRolCommand : IRequest<DeleteRolDTO>
    {
        public string Id { get; set; }

        public class DeleteRolCommandHandler : IRequestHandler<DeleteRolCommand, DeleteRolDTO>
        {
            private readonly IRoleService _roleService;

            public DeleteRolCommandHandler(IRoleService roleService)
            {
                _roleService = roleService;
            }

            public async Task<DeleteRolDTO> Handle(DeleteRolCommand request, CancellationToken cancellationToken)
            {
                var result = await _roleService.DeleteRole(request.Id);
                return new()
                {
                    Succeeded = result
                };
            }
        }
    }

}

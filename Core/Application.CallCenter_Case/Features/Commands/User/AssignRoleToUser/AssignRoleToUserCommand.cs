﻿using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands.User.AssignRoleToUser
{
    public class AssignRoleToUserCommand : IRequest<AssignRoleToUserDTO>
    {
        public string UserId { get; set; }
        public string[] Roles { get; set; }

        public class AssignRoleToUserCommandHandler : IRequestHandler<AssignRoleToUserCommand, AssignRoleToUserDTO>
        {
            private readonly IUserService _userService;

            public AssignRoleToUserCommandHandler(IUserService userService)
            {
                _userService = userService;
            }

            public async Task<AssignRoleToUserDTO> Handle(AssignRoleToUserCommand request, CancellationToken cancellationToken)
            {
                await _userService.AssignRoleToUserAsnyc(request.UserId, request.Roles);
                return new();
            }
        }
    }

}

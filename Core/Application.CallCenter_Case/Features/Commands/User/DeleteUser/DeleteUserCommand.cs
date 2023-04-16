using Application.CallCenter_Case.Dtos.User;
using Application.CallCenter_Case.Exceptions;
using Domain.CallCenter_Case.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands.User.DeleteUser
{
    public class DeleteUserCommand:IRequest<DeleteUserDTO>
    {
        public string Id { get; set; }


        public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserDTO>
        {
            private readonly UserManager<AppUser> _userManager;

            public DeleteUserCommandHandler(UserManager<AppUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<DeleteUserDTO> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                
                    AppUser user = await _userManager.FindByIdAsync(request.Id);
                    if (user!=null)
                    {
                        await _userManager.DeleteAsync(user);
                        return new DeleteUserDTO()
                        {
                            Id = user.Id,
                            Message = $"{user.UserName} adlı kullanıcı silindi."
                        };
                    }
                    return new DeleteUserDTO()
                    {
                        Message = "Hata! Kullanıcı Bulunamadı"
                    };

            }
        }
    }
}

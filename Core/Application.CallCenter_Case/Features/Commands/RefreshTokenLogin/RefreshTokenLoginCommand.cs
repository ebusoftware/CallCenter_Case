using Application.CallCenter_Case.Abstractions.Services;
using Application.CallCenter_Case.Dtos.RefreshToken;
using Application.CallCenter_Case.Dtos.Token;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Features.Commands.RefreshTokenLogin
{
    public class RefreshTokenLoginCommand : IRequest<RefreshTokenDTO>
    {
        public string RefreshToken { get; set; }

        public class RefreshTokenLoginCommandHandler : IRequestHandler<RefreshTokenLoginCommand, RefreshTokenDTO>
        {
            private readonly IAuthService _authService;
            public RefreshTokenLoginCommandHandler(IAuthService authService)
            {
                _authService = authService;
            }
            public async Task<RefreshTokenDTO> Handle(RefreshTokenLoginCommand request, CancellationToken cancellationToken)
            {
                TokenDTO token = await _authService.RefreshTokenLoginAsync(request.RefreshToken);
                return new()
                {
                    Token = token
                };
            }
        }
    }

}

using Application.CallCenter_Case.Dtos.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Abstractions.Services.Authentications
{
    public interface IInternalAuthentication
    {
        Task<TokenDTO> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
        Task<TokenDTO> RefreshTokenLoginAsync(string refreshToken);
    }
}

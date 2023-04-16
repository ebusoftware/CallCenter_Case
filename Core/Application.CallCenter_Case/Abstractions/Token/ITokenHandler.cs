using Application.CallCenter_Case.Dtos.Token;
using Domain.CallCenter_Case.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Abstractions.Token
{
    public interface ITokenHandler
    {
        TokenDTO CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}

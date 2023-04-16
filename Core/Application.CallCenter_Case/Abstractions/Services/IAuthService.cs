using Application.CallCenter_Case.Abstractions.Services.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Abstractions.Services
{
    public interface IAuthService: IInternalAuthentication,IExternalAuthentication
    {
    }
}

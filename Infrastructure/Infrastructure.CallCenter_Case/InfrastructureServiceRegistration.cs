using Application.CallCenter_Case.Abstractions.Token;
using Infrastructure.CallCenter_Case.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CallCenter_Case
{
    public static class InfrastructureServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }


    }
}

using Application.CallCenter_Case.Abstractions.Hubs;
using Microsoft.Extensions.DependencyInjection;
using SignalR.CallCenter_Case.HubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.CallCenter_Case
{
    public static class SignalRServiceRegistration
    {
        public static void AddSignalRServices(this IServiceCollection collection)
        {
            collection.AddTransient<ICallRecordHubService, CallRecordHubService>();
            collection.AddSignalR();
        }
    }
}

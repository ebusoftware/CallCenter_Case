
using Microsoft.AspNetCore.Builder;
using SignalR.CallCenter_Case.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.CallCenter_Case
{
    public static class HubRegistration
    {
        public static void MapHubs(this WebApplication endpoints)
        {
            endpoints.MapHub<CallRecordHub>("/CallRecords-hub");
        }
    }
}

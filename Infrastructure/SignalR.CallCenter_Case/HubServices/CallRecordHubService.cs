using Application.CallCenter_Case.Abstractions.Hubs;
using Microsoft.AspNetCore.SignalR;
using SignalR.CallCenter_Case.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.CallCenter_Case.HubServices
{
    public class CallRecordHubService : ICallRecordHubService
    {
        readonly IHubContext<CallRecordHub> _hubContext;

        public CallRecordHubService(IHubContext<CallRecordHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task CallRecordAddedMessageAsync(string message)
        {
            await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.CallRecordAddedMessage, message);
        }
    }
}

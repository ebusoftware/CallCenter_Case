﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Abstractions.Hubs
{
    public interface ICallRecordHubService
    {
       
        Task CallRecordAddedMessageAsync(string message);
        
    }
}

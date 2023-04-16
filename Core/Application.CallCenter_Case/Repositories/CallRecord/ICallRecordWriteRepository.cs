using Domain.CallCenter_Case.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Repositories
{
    public interface ICallRecordWriteRepository:IWriteRepository<CallRecord>
    {
    }
}

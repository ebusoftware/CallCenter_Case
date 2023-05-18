using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Dtos.CallRecord
{
    public class GetAllCallRecordDTO
    {
        public object CallRecords { get; set; }
        public int TotalCount { get; set; }
    }
}

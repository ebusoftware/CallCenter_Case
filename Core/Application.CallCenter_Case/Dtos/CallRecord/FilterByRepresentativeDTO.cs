using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Dtos.CallRecord
{
    public class FilterByRepresentativeDTO
    {
        public object? CallRecords { get; set; }
        public int TotalCount { get; set; }
    }
}

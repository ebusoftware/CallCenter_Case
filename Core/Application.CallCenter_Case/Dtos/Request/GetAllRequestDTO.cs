using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Dtos.Request
{
    public class GetAllRequestDTO
    {
        public object Requests { get; set; }
        public int TotalCount { get; set; }
    }
}

using Domain.CallCenter_Case.Entities.Common;
using Domain.CallCenter_Case.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CallCenter_Case.Entities
{
    public class CallRecord:BaseEntity
    {
        public string UserId{ get; set; }
        public string RequestType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public string Notes { get; set; }

        public AppUser AppUser { get; set; }
    }
}

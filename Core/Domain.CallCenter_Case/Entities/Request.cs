using Domain.CallCenter_Case.Entities.Common;
using Domain.CallCenter_Case.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CallCenter_Case.Entities
{
    public class Request:BaseEntity
    {
        public string UserId { get; set; }
        public string RequestType { get; set; }//talep türü
        public DateTime? ResponseTime { get; set; }
        public bool status { get; set; }

        public AppUser AppUser { get; set; }
        public Report? Report { get; set; }
    }
}

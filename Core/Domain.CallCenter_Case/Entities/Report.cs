using Domain.CallCenter_Case.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CallCenter_Case.Entities
{
    public class Report:BaseEntity
    {
        public int? CallRecordId { get; set; }
        public int? RequestId { get; set; }
        public float? SolutionRate { get; set; }//cozum oranı

        public CallRecord? CallRecord { get; set; }
        public Request? Request { get; set; }
    }
}

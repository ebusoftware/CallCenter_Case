using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Dtos.User
{
    public class GetAllRepresentativeDTO
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string NameSurname { get; set; }
        public string TwoFactorEnabled { get; set; }
    }
}

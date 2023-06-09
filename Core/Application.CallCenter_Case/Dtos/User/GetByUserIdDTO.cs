﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Dtos.User
{
    public class GetByUserIdDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string NameSurname { get; set; }
        public string UserName { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Dtos.User
{
    public class GetAllUserDTO
    {
        public object Users { get; set; }
        public int TotalUsersCount { get; set; }
    }
}

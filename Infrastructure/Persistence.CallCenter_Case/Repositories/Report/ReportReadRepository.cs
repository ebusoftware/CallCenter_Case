﻿using Application.CallCenter_Case.Repositories;
using Domain.CallCenter_Case.Entities;
using Persistence.CallCenter_Case.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.CallCenter_Case.Repositories
{
    public class ReportReadRepository : ReadRepository<Report>, IReportReadRepository
    {
        public ReportReadRepository(CallCenterDbContext context) : base(context)
        {
        }
    }
}

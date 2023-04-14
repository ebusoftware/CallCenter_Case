using Domain.CallCenter_Case.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.CallCenter_Case.Contexts
{
    public class CallCenterDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public CallCenterDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}

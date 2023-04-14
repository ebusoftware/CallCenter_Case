using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistence.CallCenter_Case.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.CallCenter_Case
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CallCenterDbContext>
    {
        public CallCenterDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CallCenterDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}

using Application.CallCenter_Case.Repositories;
using Domain.CallCenter_Case.Entities;
using Domain.CallCenter_Case.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence.CallCenter_Case.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.CallCenter_Case.Repositories
{
    public class CallRecordReadRepository : ReadRepository<CallRecord>, ICallRecordReadRepository
    {
        private readonly CallCenterDbContext _context;
        public CallRecordReadRepository(CallCenterDbContext context) : base(context)
        {
           _context = context;
        }

        public async Task<AppUser> GetRepresentativeById(string representativeId)
        {
            // RepresentativeId'ye göre ilgili kullanıcıyı sorgula
            var representative = await _context.Users.FirstOrDefaultAsync(u => u.Id == representativeId);
            return representative;
        }
    }
}

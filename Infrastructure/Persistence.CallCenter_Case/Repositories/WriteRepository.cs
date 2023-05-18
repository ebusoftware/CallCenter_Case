using Application.CallCenter_Case.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CallCenter_Case.Entities.Common;
using Persistence.CallCenter_Case.Contexts;

namespace Persistence.CallCenter_Case.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity

    {
        private readonly CallCenterDbContext _context;

        public WriteRepository(CallCenterDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                // Hata mesajını ve ayrıntılarını loglayabilir veya başka bir şekilde ele alabilirsiniz.
                throw ex; // veya isteğe bağlı olarak daha özel bir hata fırlatma işlemi yapabilirsiniz.
            }
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<T> RemoveAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return entity;
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}

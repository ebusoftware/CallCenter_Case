using Domain.CallCenter_Case.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CallCenter_Case.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T model);
        Task<T> RemoveAsync(T entity);
        bool RemoveRange(List<T> datas);
        bool Update(T model);
        Task<T> UpdateAsync(T entity);
        Task<int> SaveAsync();
    }
}

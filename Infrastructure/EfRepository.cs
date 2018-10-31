using Microsoft.EntityFrameworkCore;
using Sf.ContractApi.ApplicationCore.Entities;
using Sf.ContractApi.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.ContractApi.Infrastructure
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly ContractContext _contractContext;

        public EfRepository(ContractContext contractContext)
        {
            _contractContext = contractContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _contractContext.Set<T>().Add(entity);

            await _contractContext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _contractContext.Set<T>().Remove(entity);
            await _contractContext.SaveChangesAsync();

        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await _contractContext.Set<T>().FindAsync(Id);
        }

        public async Task<List<T>> ListAllAsync()
        {
            return await _contractContext.Set<T>().ToListAsync();
        }

        public async Task<List<T>> ListAsync(Func<T, bool> filter)
        {
            var query = _contractContext.Set<T>()
                .Where(filter).AsQueryable();

            return await query.ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _contractContext.Entry<T>(entity).State = EntityState.Modified;

            await _contractContext.SaveChangesAsync();
        }
    }
}

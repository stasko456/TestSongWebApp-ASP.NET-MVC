using Microsoft.EntityFrameworkCore;
using SongsWebApp.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsWebApp.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SongsWebAppContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(SongsWebAppContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid? id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}

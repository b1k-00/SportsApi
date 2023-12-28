using Microsoft.EntityFrameworkCore;
using SportAPI.Application.Persistence;

namespace SportAPI.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly SportsDbContext _dbContext;
        public GenericRepository(SportsDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {

            var found = _dbContext.Find<T>(id);
            if (found != null)
            {
                _dbContext.Remove(found);
                await _dbContext.SaveChangesAsync();
            }


        }

        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}

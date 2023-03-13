using Mediador.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Mediador.Infrastructure.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public Repository(DbContext context)
        {
            this.Context = context;
            this.Query = Context.Set<T>();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await this.Query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.Query.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await this.UpdateAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            this.Query.Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await this.Query.Where(expression).ToListAsync();
        }

        IQueryable<T> IRepository<T>.Query(Expression<Func<T, bool>> expression)
        {
            return this.Context.Set<T>().Where(expression);
        }
    }
}

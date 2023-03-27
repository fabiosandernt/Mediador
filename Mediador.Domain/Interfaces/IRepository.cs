
using System.Linq.Expressions;

namespace Mediador.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(object id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression);
        Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression);
    }
}

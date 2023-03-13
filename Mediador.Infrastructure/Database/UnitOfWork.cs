using Mediador.Domain.Interfaces;
using Mediador.Infrastructure.Context;

namespace Mediador.Infrastructure.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext Context;

        public UnitOfWork(DataContext context)
        {
            Context = context;
        }

        public async Task Commit()
        {
            await Context.SaveChangesAsync();
        }
    }
}

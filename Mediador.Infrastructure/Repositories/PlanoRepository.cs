

using Mediador.Domain.Planos;
using Mediador.Domain.Planos.Repository;
using Mediador.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Mediador.Infrastructure.Repositories
{
    public class PlanoRepository : Repository<Plano>, IPlanoRepository
    {
        public PlanoRepository(DbContext context) : base(context)
        {
        }
    }
}

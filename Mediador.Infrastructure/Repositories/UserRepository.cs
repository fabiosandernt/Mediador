using Mediador.Domain.Usuario;
using Mediador.Domain.Usuario.Repository;
using Mediador.Infrastructure.Context;
using Mediador.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }
        public async Task<IEnumerable<User>> ObterTodosUsuarios()
        {
            return await this.Query.ToListAsync(); ;
        }

        public async Task<IEnumerable<User>> ObterUsuarioPorId(Guid id)
        {
            return await this.Query.Where(x => x.Id == id).ToListAsync();
        }
    }
}

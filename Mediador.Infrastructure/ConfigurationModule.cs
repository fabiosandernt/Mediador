using Mediador.Domain.Clientes.Repository;
using Mediador.Domain.Planos.Repository;
using Mediador.Domain.Usuarios.Repository;
using Mediador.Infrastructure.Context;
using Mediador.Infrastructure.Database;
using Mediador.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mediador.Infrastructure
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPlanoRepository, PlanoRepository>();

            return services;
        }
    }
}

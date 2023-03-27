using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Infrastructure.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<DataContext>()
                .AddEnvironmentVariables()
                .Build();

            var builder = new DbContextOptionsBuilder<DataContext>();
            var connectionString =
                config.GetConnectionString("MediadorApi");
            builder.UseSqlServer(connectionString);
            Console.WriteLine(connectionString);
            return new DataContext(builder.Options);
        }
    }
}



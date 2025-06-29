using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QtecLabTask.Core.Data;
using QtecLabTask.Core.Repositories;
using QtecLabTask.Core.Services;

namespace QtecLabTask.Core
{
    public static class DependancyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SQLServerConnectionString");
            services.AddDbContext<QtecLabDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IJournalEntryService, JournalEntryService>();
            services.AddScoped<IJournalEntryRepository, JournalEntryRepository>();
            return services;
        }
    }
}

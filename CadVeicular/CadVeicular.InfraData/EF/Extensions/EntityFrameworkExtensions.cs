using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CadVeicular.Infra.Data.EF.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static IServiceCollection AddEFConfiguration(this IServiceCollection services,
            string connectionString)
        {
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<CadastroVeicularContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                },
                ServiceLifetime.Scoped);

            return services;
        }
    }
}

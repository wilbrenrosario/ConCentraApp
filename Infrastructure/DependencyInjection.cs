using Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Data;
using Domain.Primitives;
using Domain.Placas;
using Infrastructure.Persistence.Repositories;
using Domain.Usuario;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistence(configuration);
            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration) 
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DataBase")));
            services.AddScoped<IApplicationDbContext>( sp => sp.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());


            services.AddScoped<IPlacasRepository, PlacasRepository>();
            services.AddScoped<IUsuarioRepository, UsuariosRepository>();

            return services; 
        
        }
    }
}

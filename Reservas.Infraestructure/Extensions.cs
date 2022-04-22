using Microsoft.Extensions.DependencyInjection;
using Reservas.Domain.Repositories;
using Reservas.Infraestructure.EF;
using Reservas.Infraestructure.MemoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //TODO: Eliminar despues. Solo para proposito de pruebas
            services.AddSingleton<MemoryDatabase>();

            services.AddScoped<ReservaRepositories, MemoryReservaRepository>();
            services.AddScoped<IUnitOfWorks, UnitOfWork>();


            return services;
        }
    }
}

using Reservas.Domain.Model.Reservas;
using Reservas.Domain.Repositories;
using System;
using ShareKernel.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructure.EF.Repository
{
    public class ReservaRepository : ReservaRepositories
    {
        public Task CreateAsync(Reserva obj)
        {
            Console.WriteLine($"Insertando la Reserva { obj.IdReserva }");

            return Task.CompletedTask;
        }

        public Task FindByIdAsync(Guid id)
        {
            Console.WriteLine($"Retornando la Reserva { id }");

            return null;
        }

        public Task UpdateAsync(Reserva obj)
        {
            Console.WriteLine($"Actualizando la Reserva { obj.IdReserva }");

            return Task.CompletedTask;
        }

        Task<Reserva> IRepository<Reserva, Guid>.FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

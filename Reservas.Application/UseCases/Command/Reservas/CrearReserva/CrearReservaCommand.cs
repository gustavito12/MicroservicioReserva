using MediatR;
using Reservas.Domain.Model.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.UseCases.Command.Reservas.CrearReserva
{
    public class CrearReservaCommand : IRequest<Guid>
    {
        private CrearReservaCommand() { }

        public CrearReservaCommand(DetalleReserva detalle)
        {
            Detalle = detalle;
        }

        public DetalleReserva Detalle { get; set; }

    }
}

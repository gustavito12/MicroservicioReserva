using MediatR;
using Reservas.Application.Dto.Reserva;
using Reservas.Application.UseCases.Queries.Reservas.SearchReserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reservas.Infraestructure.EF.UseCases.Queries
{
    public class SearchReservasHandler : IRequestHandler<SearchReservaQuery, ICollection<ReservaDto>>
    {
        public Task<ICollection<ReservaDto>> Handle(SearchReservaQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

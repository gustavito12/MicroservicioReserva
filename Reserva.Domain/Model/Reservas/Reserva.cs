using Reservas.Domain.Event.Reservas;
using Reservas.Domain.Model.Pagos;
using Reservas.Domain.Model.Reservas.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Model.Reservas
{
    public class Reserva : AggregateRoot<Guid>
    {
        public Guid VueloId { get; private set; }
        public Guid IDPasajero { get; private set; }
        public Guid IDPago     { get; private set; }
        public int IdReserva { get; private set; }        
        public DetalleReserva Detalle { get; private set; }
        public Pago DetallePago { get; private set; }

        public Reserva(int idReserva)
        {
            Id = Guid.NewGuid();
            IdReserva = idReserva;
        }

        public Reserva()
        {
            Id = Guid.NewGuid();
        }

        public void CargaReservaDetalle(DateTime fechaReserva, decimal importe, bool estado,int numTicket)
        {        
            Detalle = new DetalleReserva(fechaReserva, importe, estado, numTicket);
        }

        public void CargaReservaPago(int tipoCombrobante, DateTime fechaPago, int tipoPago, string numFactura, decimal numRecibo, decimal totalPagado)
        {
            DetallePago = new Pago(tipoCombrobante, fechaPago, tipoPago, numFactura, totalPagado);
        }

        public void RegistrarReserva()
        {
            var evento = new ReservaRealizada(Id, IdReserva, Detalle, DetallePago);
            AddDomainEvent(evento);
        }
    }
}

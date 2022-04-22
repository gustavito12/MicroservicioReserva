using Reservas.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructure.EF
{
    public class UnitOfWork : IUnitOfWorks
    {
        public Task Commit()
        {
            return Task.CompletedTask;
        }
    }
}

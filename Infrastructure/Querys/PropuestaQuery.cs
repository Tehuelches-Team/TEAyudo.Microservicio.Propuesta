using Application.Interface;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class PropuestaQuery : IPropuestaQuery
    {
        public Task<Propuesta> GetPropuesta(int PropuestaID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Propuesta>> GetPropuestas()
        {
            throw new NotImplementedException();
        }

        public Task<List<Propuesta>> GetPropuestasByEstado(int EstadoPropuestaID)
        {
            throw new NotImplementedException();
        }
    }
}

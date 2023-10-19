using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IEstadoPropuestaQuery
    {
        List<EstadoPropuesta> GetListEstados();

        Task<EstadoPropuesta?> GetEstadoPropuesta(int Id);
    }
}

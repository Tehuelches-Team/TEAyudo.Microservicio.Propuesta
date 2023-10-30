using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Propuestas
{
    public interface IPropuestaQuery
    {
        Task<Propuesta?> GetPropuestaById(int PropuestaID);

        Task<List<Propuesta>> GetAllPropuestas(int? IdAcompanante, int? IdTutor);

        //Task<List<Propuesta>> GetPropuestasByEstado(int EstadoPropuestaID);
    }
}

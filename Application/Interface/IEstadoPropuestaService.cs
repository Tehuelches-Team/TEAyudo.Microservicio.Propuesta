using Application.DTO;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IEstadoPropuestaService
    {
        Task<EstadoPropuesta> CreateEstadoPropuesta(EstadoPropuestaDTO estadoPropuestaDTO);

        Task<EstadoPropuesta> DeleteEstadoPropuesta();

        Task<List<EstadoPropuesta>> GetAll();

        Task<EstadoPropuesta> GetEstadopropuestaById(int EstadoPropuestaId);


    }
}

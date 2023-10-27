using Application.DTO;
using Application.Interface;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class EstadoPropuestaService : IEstadoPropuestaService
    {
        private readonly IEstadoPropuestaCommand _estadoPropuestaCommand;

        private readonly IEstadoPropuestaQuery _estadoPropuestaQuery;

        public EstadoPropuestaService(IEstadoPropuestaCommand estadoPropuestaCommand, IEstadoPropuestaQuery estadoPropuestaQuery)
        {
            _estadoPropuestaCommand = estadoPropuestaCommand;
            _estadoPropuestaQuery = estadoPropuestaQuery;
        }

        public async Task<EstadoPropuesta> CreateEstadoPropuesta(EstadoPropuestaDTO estadoPropuestaDTO)
        {
            var EstadoPropuesta = new EstadoPropuesta
            {
                EstadoPropuestaId = estadoPropuestaDTO.EstadoPropuestaId,
                Descripcion = estadoPropuestaDTO.Descripcion,
            };
            await   _estadoPropuestaCommand.InsertEstadoPropuesta(EstadoPropuesta);

            return EstadoPropuesta;
        }

        public Task<EstadoPropuesta> DeleteEstadoPropuesta()
        {
            throw new NotImplementedException();
        }

        public async Task<List<EstadoPropuesta>> GetAll()
        {
            return _estadoPropuestaQuery.GetListEstados();
        }

        public async Task<EstadoPropuesta> GetEstadopropuestaById(int EstadoPropuestaId)
        {
            return await _estadoPropuestaQuery.GetEstadoPropuesta(EstadoPropuestaId);
        }
    }
}
s
using Application.Interface;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class EstadoPropuestaQuery : IEstadoPropuestaQuery
    {
        private readonly TEAyudoContext _context;

        public EstadoPropuestaQuery(TEAyudoContext context)
        {
            _context = context;
        }

        public async Task<EstadoPropuesta?> GetEstadoPropuesta(int Id)
        {
            return await _context.EstadoPropuesta.FindAsync(Id);
        }

        public List<EstadoPropuesta> GetListEstados()
        {
            return _context.EstadoPropuesta.ToList();
        }
    }
}

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
        private readonly TEAyudoContext _context;

        public PropuestaQuery(TEAyudoContext context)
        {
            _context = context;
        }

        public Task<Propuesta> GetPropuesta(int PropuestaID)
        {
            return _context.Propuesta.FindAsync(PropuestaID);
        }

        public Task<List<Propuesta>> GetAllPropuestas()
        {
          return  _context.Propuestas.ToListAsync();
        }

        public Task<List<Propuesta>> GetPropuestasByEstado(int EstadoPropuestaID)
        {
            return _context.Propuestas.Where(x => x.EstadoPropuestaId == EstadoPropuestaID).ToListAsync();  
        }
    }
}

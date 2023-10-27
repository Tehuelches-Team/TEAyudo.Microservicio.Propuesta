using Application.Interface;
using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Propuesta> GetPropuesta(int PropuestaID)
        {
            return await _context.Propuesta.FindAsync(PropuestaID);
        }

        public async Task<List<Propuesta>> GetAllPropuestas()
        {
          return   _context.Propuesta.ToList();
        }

        public async Task<List<Propuesta>> GetPropuestasByEstado(int EstadoPropuestaID)
        {
            return await _context.Propuesta.Where(x => x.EstadoPropuestaId == EstadoPropuestaID).ToListAsync();  
        }
    }
}

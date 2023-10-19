using Application.Interface;
using Domain.Entitites;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class EstadoPropuestaCommand : IEstadoPropuestaCommand
    {
        private readonly TEAyudoContext _context;

        public EstadoPropuestaCommand(TEAyudoContext context)
        {
            _context = context;
        }

        public async Task InsertEstadoPropuesta(EstadoPropuesta EstadoPropuesta)
        {            
             _context.Add(EstadoPropuesta);
            await _context.SaveChangesAsync();
        }

        public Task RemoveEstadoPropuesta(int EstadoPropuestaID)
        {
            throw new NotImplementedException();
        }
    }

      
}

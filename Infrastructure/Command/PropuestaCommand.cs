using Application.Interface;
using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class PropuestaCommand : IPropuestaCommand
    {
        private readonly TEAyudoContext _context;

        public PropuestaCommand(TEAyudoContext context)
        {
            _context = context;
        }

        public Task InsertPropuesta(Propuesta Propuesta)
        {
           _context.Add(Propuesta);
            return _context.SaveChangesAsync();
        }

        public async Task RemovePropuesta(int PropuestaID)
        {
            var propuesta = _context.Propuesta.Find(PropuestaID);
            if (propuesta != null)
            {
                _context.Propuesta.Remove(propuesta);
                await _context.SaveChangesAsync();
            }
        }    

        public async Task UpdatePropuesta(Propuesta Propuesta)
        {
            Propuesta propuesta = _context.Propuesta.Include(Propuesta => Propuesta.EstadoPropuestaId)
                .Include(Propuesta => Propuesta.TutorId)
                .Include(Propuesta => Propuesta.AcompananteId)
                .FirstOrDefault(Propuesta => Propuesta.PropuestaId == Propuesta.PropuestaId);       

            propuesta.EstadoPropuestaId = Propuesta.EstadoPropuestaId;
            propuesta.TutorId = Propuesta.TutorId;
            propuesta.AcompananteId = Propuesta.AcompananteId;
            propuesta.InfoAdicional = Propuesta.InfoAdicional;
            propuesta.Monto = Propuesta.Monto;

             _context.SaveChanges();

            
        }
    }
}

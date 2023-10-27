using Application.Interface;
using Application.Model.DTO;
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
        private readonly TEAyudoContext Context;

        public PropuestaCommand(TEAyudoContext Context)
        {
            this.Context = Context;
        }

        public async Task<Propuesta> AddPropuesta(Propuesta Propuesta)
        {
            Context.Add(Propuesta);
            await Context.SaveChangesAsync();
            return Propuesta; //Verificar que retorne el id de propuesta.
        }

        public async Task<Propuesta?> UpdatePropuesta(int Id, PropuestaDTO PropuestaDTO) 
        {
            Propuesta? Propuesta = await Context.Propuesta.FirstOrDefaultAsync(s => s.PropuestaId == Id);
            if (Propuesta == null)
            {
                return null;
            }
            Propuesta.EstadoPropuesta = PropuestaDTO.EstadoPropuesta;
            Propuesta.Descripcion = PropuestaDTO.Descripcion;
            Propuesta.InfoAdicional = PropuestaDTO.InfoAdicional;
            Propuesta.Monto = PropuestaDTO.Monto;
            await Context.SaveChangesAsync();
            return Propuesta; //Acá si se cambian las cosas
        }

        public async Task<Propuesta?> RemovePropuesta(int PropuestaID)
        {
            Propuesta? propuesta = await Context.Propuesta.FindAsync(PropuestaID);
            if (propuesta != null)
            {
                Context.Propuesta.Remove(propuesta);
                await Context.SaveChangesAsync();
            }

            return propuesta;
        }    
    }
}

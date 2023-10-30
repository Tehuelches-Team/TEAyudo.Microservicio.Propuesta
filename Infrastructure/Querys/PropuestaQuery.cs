using Application.Interface.Propuestas;
using Domain.Entitites;
using Infrastructure.Persistence;
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
        private readonly TEAyudoContext Context;

        public PropuestaQuery(TEAyudoContext Context)
        {
            this.Context = Context;
        }

        public async Task<List<Propuesta>> GetAllPropuestas(int? IdAcompanante, int? IdTutor)
        {
            return await Context.Propuesta.Where(s => (IdAcompanante != null ? (s.AcompananteId == IdAcompanante) : true) && 
                                                                                    (IdTutor != null ? (s.TutorId == IdTutor) : true))
                                                                                    .ToListAsync();
        }

        public async Task<Propuesta?> GetPropuestaById(int PropuestaId)
        {
            return await Context.Propuesta.FirstOrDefaultAsync(s => s.PropuestaId == PropuestaId);
        }

        //public async Task<List<Propuesta>> GetPropuestasByEstado(int EstadoPropuestaID)
        //{
        //    return await Context.Propuesta.Where(x => x.EstadoPropuestaId == EstadoPropuestaID).ToListAsync();  
        //}
    }
}

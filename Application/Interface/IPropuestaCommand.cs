using Application.Model.DTO;
using Application.Model.Response;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IPropuestaCommand
    {
        Task<Propuesta> AddPropuesta(Propuesta Propuesta);
        Task<Propuesta> RemovePropuesta(int PropuestaId);
        Task<Propuesta?> UpdatePropuesta(int Id, PropuestaDTO PropuestaDTO);
    }
}

using Application.Model.DTO;
using Application.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IPropuestaService
    {
        Task<List<PropuestaResponse>> GetAllPropuestaUsuario(int? IdAcompanante, int? IdTutor);
        Task<PropuestaResponse?> GetPropuestaById(int Id);
        Task<PropuestaResponse> AddPropuesta(PropuestaDTO PropuestaDTO);
        Task<PropuestaResponse?> UpdatePropuesta(int Id, PropuestaDTO PropuestaDTO);
        Task<PropuestaResponse> RemovePropuesta(int id);
    }
}

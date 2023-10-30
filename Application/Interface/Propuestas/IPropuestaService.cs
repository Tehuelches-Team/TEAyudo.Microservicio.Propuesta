using Application.Model.DTO;
using Application.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Propuestas
{
    public interface IPropuestaService
    {
        Task<List<PropuestaTutorResponse>> GetAllPropuestaForTutor(int? IdTutor);
        Task<List<PropuestaAcompananteResponse>> GetAllPropuestaForAcompanante(int? IdAcompanante);
        Task<PropuestaResponse?> GetPropuestaById(int Id);
        Task<PropuestaResponse> AddPropuesta(PropuestaDTO PropuestaDTO);
        Task<PropuestaResponse> UpdatePropuesta(int Id, int Estado);
        Task<PropuestaResponse> RemovePropuesta(int id);
    }
}

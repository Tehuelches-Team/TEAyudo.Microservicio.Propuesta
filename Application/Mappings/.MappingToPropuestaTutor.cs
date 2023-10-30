using Application.Model.DTO;
using Application.Model.Response;
using Domain.Entitites;

namespace Application.Mappings
{
    public class MappingToPropuestaTutor
    {
        public PropuestaTutorResponse Map(Propuesta Propuesta, AcompananteResponse AcompananteResponse)
        {
            return new PropuestaTutorResponse
            {
                PropuestaId  = Propuesta.PropuestaId,
                TutorId  = Propuesta.TutorId,
                AcompananteId = Propuesta.AcompananteId,
                InfoAdicional = Propuesta.InfoAdicional,
                Monto = Propuesta.Monto,
                EstadoPropuesta = Propuesta.EstadoPropuesta,
                Descripcion = Propuesta.Descripcion,
                AcompananteResponse = AcompananteResponse,
            }; 
        }
    }
}
using Application.Model.Response;
using Domain.Entitites;

namespace Application.Mappings
{
    public class MappingPropuestaToPropuestaResponse
    {
        public PropuestaResponse Map(Propuesta Propuesta) 
        {
            return new PropuestaResponse
            {
                PropuestaId = Propuesta.PropuestaId,
                TutorId = Propuesta.TutorId,
                AcompananteId = Propuesta.AcompananteId,
                InfoAdicional = Propuesta.InfoAdicional,
                Monto = Propuesta.Monto,
                EstadoPropuesta = Propuesta.EstadoPropuesta,
                Descripcion = Propuesta.Descripcion,
            };
        }
    }
}
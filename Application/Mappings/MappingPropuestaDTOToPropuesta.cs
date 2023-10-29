using Application.Model.DTO;
using Application.Model.Response;
using Domain.Entitites;

namespace Application.Mappings
{
    public class MappingPropuestaDTOToPropuesta
    {
        public Propuesta Map(PropuestaDTO PropuestaDTO)
        {
            return new Propuesta
            {
                TutorId = PropuestaDTO.TutorId,
                AcompananteId = PropuestaDTO.AcompananteId,
                InfoAdicional = PropuestaDTO.InfoAdicional,
                Monto = PropuestaDTO.Monto,
                EstadoPropuesta = PropuestaDTO.EstadoPropuesta,
                Descripcion = PropuestaDTO.Descripcion
            }; 
        }
    }
}
using Application.Model.DTO;
using Application.Model.Response;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingToPropuestaAcompanante
    {
        public PropuestaAcompananteResponse Map(Propuesta Propuesta, TutorResponse Tutor)
        {
            return new PropuestaAcompananteResponse
            {
                PropuestaId = Propuesta.PropuestaId,
                TutorId = Propuesta.TutorId,
                AcompananteId = Propuesta.AcompananteId,
                InfoAdicional = Propuesta.InfoAdicional,
                Monto = Propuesta.Monto,
                EstadoPropuesta = Propuesta.EstadoPropuesta,
                Descripcion = Propuesta.Descripcion,
                TutorResponse = Tutor
            };
        }
    }
}

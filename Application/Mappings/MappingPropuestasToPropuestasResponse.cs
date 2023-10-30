using Application.Model.Response;
using Domain.Entitites;

namespace Application.Mappings
{
    public class MappingPropuestasToPropuestasResponse
    {
        public List<PropuestaResponse> Map(List<Propuesta> ListaPropuesta)
        {
            MappingPropuestaToPropuestaResponse Mapping = new MappingPropuestaToPropuestaResponse();
            List<PropuestaResponse> ListaResponse = new List<PropuestaResponse>();
            foreach(Propuesta Propuesta in ListaPropuesta)
            {
                ListaResponse.Add(Mapping.Map(Propuesta));
            }
            return ListaResponse;
        }
    }
}
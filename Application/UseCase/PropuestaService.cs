using Application.Interface;
using Application.Mappings;
using Application.Model.DTO;
using Application.Model.Response;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class PropuestaService : IPropuestaService
    {
        private readonly IPropuestaQuery PropuestaQuery;
        private readonly IPropuestaCommand PropuestaCommand;

        public PropuestaService(IPropuestaQuery PropuestaQuery, IPropuestaCommand propuestaCommand)
        {
            this.PropuestaQuery = PropuestaQuery;
            PropuestaCommand = propuestaCommand;
        }

        public async Task<List<PropuestaResponse>> GetAllPropuestaUsuario(int? IdAcompanante, int? IdTutor)
        {
            List<Propuesta> Lista = await PropuestaQuery.GetAllPropuestas(IdAcompanante,IdTutor);
            MappingPropuestasToPropuestasResponse Mapping = new MappingPropuestasToPropuestasResponse();
            List<PropuestaResponse> ListaResponse = Mapping.Map(Lista);
            return ListaResponse;
        }

        public async Task<PropuestaResponse?> GetPropuestaById(int Id)
        {
            Propuesta? Propuesta = await PropuestaQuery.GetPropuestaById(Id);
            if(Propuesta != null) 
            {
                MappingPropuestaToPropuestaResponse Mapping = new MappingPropuestaToPropuestaResponse();
                return Mapping.Map(Propuesta);
            }
            return null; 
        }
    
        public async Task<PropuestaResponse> AddPropuesta(PropuestaDTO PropuestaDTO) 
        {
            MappingPropuestaDTOToPropuesta Mapping = new MappingPropuestaDTOToPropuesta();
            Propuesta Propuesta = Mapping.Map(PropuestaDTO);
            Propuesta = await PropuestaCommand.AddPropuesta(Propuesta);
            MappingPropuestaToPropuestaResponse Mapping2 = new MappingPropuestaToPropuestaResponse();
            return Mapping2.Map(Propuesta);
        }

        public async Task<PropuestaResponse?> UpdatePropuesta(int Id, PropuestaDTO PropuestaDTO) 
        {
            MappingPropuestaDTOToPropuesta Mapping = new MappingPropuestaDTOToPropuesta();
            Propuesta? Propuesta = Mapping.Map(PropuestaDTO);
            Propuesta.PropuestaId = Id;
            Propuesta = await PropuestaCommand.UpdatePropuesta(Id,PropuestaDTO);
            if (Propuesta == null)
            {
                return null;
            }
            MappingPropuestaToPropuestaResponse Mapping2 = new MappingPropuestaToPropuestaResponse();
            return Mapping2.Map(Propuesta); 
        }

        public async Task<PropuestaResponse> RemovePropuesta(int Id)
        {
            Propuesta? Propuesta = await PropuestaCommand.RemovePropuesta(Id);
            if (Propuesta == null)
            {
                return null;
            }
            MappingPropuestaToPropuestaResponse Mapping2 = new MappingPropuestaToPropuestaResponse();
            return Mapping2.Map(Propuesta);
        }
    }
}

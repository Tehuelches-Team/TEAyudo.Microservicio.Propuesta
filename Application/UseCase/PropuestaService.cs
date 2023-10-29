using Application.Interface.acompanantes;
using Application.Interface.Propuestas;
using Application.Interface.Tutores;
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
        private readonly IAcompananteQuery AcompananteQuery;
        private readonly ITutorQuery TutorQuery;

        public PropuestaService(IPropuestaQuery PropuestaQuery, IPropuestaCommand PropuestaCommand, IAcompananteQuery AcompananteQuery, ITutorQuery TutorQuery)
        {
            this.PropuestaQuery = PropuestaQuery;
            this.PropuestaCommand = PropuestaCommand;
            this.AcompananteQuery = AcompananteQuery;
            this.TutorQuery = TutorQuery;
        }

        public async Task<List<PropuestaTutorResponse>> GetAllPropuestaForTutor(int? IdTutor)
        {
            List<Propuesta> Lista = await PropuestaQuery.GetAllPropuestas(null, IdTutor);
            MappingToPropuestaTutor Mapping = new MappingToPropuestaTutor();
            List<PropuestaTutorResponse> ListaResponse = new List<PropuestaTutorResponse>();
            foreach (var Propuesta in Lista)
            {
                ListaResponse.Add(Mapping.Map(Propuesta, await AcompananteQuery.GetAcompananteById(Propuesta.AcompananteId)));
            }
            return ListaResponse;
        }

        public async Task<List<PropuestaAcompananteResponse>> GetAllPropuestaForAcompanante(int? IdAcompanante)
        {
            List<Propuesta> Lista = await PropuestaQuery.GetAllPropuestas(IdAcompanante, null);
            MappingToPropuestaAcompanante Mapping = new MappingToPropuestaAcompanante();
            List<PropuestaAcompananteResponse> ListaResponse = new List<PropuestaAcompananteResponse>();
            foreach (var Propuesta in Lista)
            {
                ListaResponse.Add(Mapping.Map(Propuesta, await TutorQuery.GetTutorById(Propuesta.TutorId)));
            }
            return ListaResponse;
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

        public async Task<PropuestaResponse> UpdatePropuesta(int Id, int Estado) 
        {
            Propuesta Propuesta = await PropuestaCommand.UpdatePropuesta(Id,Estado);
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

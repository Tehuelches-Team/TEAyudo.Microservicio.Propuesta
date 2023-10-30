using Application.Interface.Propuestas;
using Application.Model.DTO;
using Application.Model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TEAyudo_Propuesta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropuestaController : ControllerBase
    {
        private readonly IPropuestaService PropuestaService;

        public PropuestaController(IPropuestaService PropuestaService)
        {
            this.PropuestaService = PropuestaService;
        }

        [HttpGet("{TutorId}/Tutor")]
        public async Task<IActionResult> GetPropuestaForTutor(int? TutorId) //Panorama tutor (Podra ver las propuestas con los datos del acompanante correspondiente)
        {
            return Ok(await PropuestaService.GetAllPropuestaForTutor(TutorId));
        }

        [HttpGet("{AcompananteId}/Acompanante")]
        public async Task<IActionResult> GetPropuestaForAcompanante(int? AcompananteId) //Panorama Acompanante (Podra ver las propuestas con los datos del tutor correspondiente)
        {
            return Ok(await PropuestaService.GetAllPropuestaForAcompanante(AcompananteId));
        }

        //[HttpGet("{IdAcom}")]
        //public async Task<IActionResult> GetPropuestaForAcom(int Id, int? IdTutor)


        [HttpPost]
        public async Task<IActionResult> PostPropuesta(PropuestaDTO PropuestaDTO)
        {
            PropuestaResponse? Propuesta = await PropuestaService.AddPropuesta(PropuestaDTO);
            return Ok(Propuesta);
        }

        [HttpPut("{Id}/{Estado}")]
        public async Task<IActionResult> PutPropuesta(int Id, int Estado)
        {
            PropuestaResponse? Propuesta = await PropuestaService.UpdatePropuesta(Id,Estado);
            if (Propuesta == null)
            {
                var Mensaje = new
                {
                    motivo = "No existe una propuesta asociada a ese id"
                };
                return NotFound(Mensaje);
            }
            return Ok(Propuesta);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeletePropuesta(int Id)
        {
            PropuestaResponse? Propuesta = await PropuestaService.RemovePropuesta(Id);
            if (Propuesta == null)
            {
                var Mensaje = new
                {
                    motivo = "No existe una propuesta asociada a ese id"
                };
                return NotFound(Mensaje);
            }
            return Ok(Propuesta);
        }

    }
}

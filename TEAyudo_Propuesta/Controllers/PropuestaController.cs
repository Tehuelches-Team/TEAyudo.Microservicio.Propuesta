using Application.Interface;
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

        [HttpGet("{IdAcompanante,IdTutor}")]
        public async Task<IActionResult> GetAllPropuestaUsuario(int? IdAcompanante, int? IdTutor)
        {
            return Ok(await PropuestaService.GetAllPropuestaUsuario(IdAcompanante, IdTutor));
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPropuestaById(int Id)
        {
            PropuestaResponse? Propuesta = await PropuestaService.GetPropuestaById(Id);
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

        [HttpPost]
        public async Task<IActionResult> PostPropuesta(PropuestaDTO PropuestaDTO)
        {
            PropuestaResponse? Propuesta = await PropuestaService.AddPropuesta(PropuestaDTO);
            return Ok(Propuesta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropuesta(int Id, PropuestaDTO PropuestaDTO)
        {
            PropuestaResponse? Propuesta = await PropuestaService.UpdatePropuesta(Id,PropuestaDTO);
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

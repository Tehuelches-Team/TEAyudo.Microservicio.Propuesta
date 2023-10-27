using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TEAyudo_Propuesta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoPropuestaController : ControllerBase
    {
        private readonly IEstadoPropuestaService _estadoPropuestaService;

        public EstadoPropuestaController(IEstadoPropuestaService estadoPropuestaService)
        {
            _estadoPropuestaService = estadoPropuestaService;
        }

        // GET: api/EstadoPropuesta
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}

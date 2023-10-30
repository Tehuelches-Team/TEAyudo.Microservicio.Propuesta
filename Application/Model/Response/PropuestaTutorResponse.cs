using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Response
{
    public class PropuestaTutorResponse
    {
        public int PropuestaId {  get; set; }
        public int TutorId { get; set; }
        public int AcompananteId { get; set; }
        public string InfoAdicional { get; set; }
        public int Monto { get; set; }
        public int EstadoPropuesta { get; set; }
        public string Descripcion { get; set; }
        public AcompananteResponse AcompananteResponse { get; set; }


    }
}

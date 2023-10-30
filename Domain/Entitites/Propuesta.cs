using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitites
{
    public class Propuesta
    {
        public int PropuestaId { get; set; }
        public int TutorId { get; set; }
        public int AcompananteId { get; set; }
        public string InfoAdicional { get; set; }
        public int Monto { get; set; }
        public int EstadoPropuesta { get; set; }
        public string Descripcion { get; set; }
    }
}

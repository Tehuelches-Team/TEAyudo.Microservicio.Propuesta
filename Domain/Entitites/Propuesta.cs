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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropuestaId { get; set; }
        public int TutorId { get; set; }
        public int AcompananteId { get; set; }
        public int EstadoPropuestaId { get; set; }
        public string InfoAdicional { get; set; }
        public int Monto { get; set; }

        public  EstadoPropuesta EstadosPropuestas { get; set; }
    }
}

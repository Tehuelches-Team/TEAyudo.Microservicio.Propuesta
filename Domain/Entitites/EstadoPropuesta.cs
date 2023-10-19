using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitites
{
    public class EstadoPropuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstadoPropuestaId { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; }
        public  Propuesta Propuesta { get; set; }
    }
}

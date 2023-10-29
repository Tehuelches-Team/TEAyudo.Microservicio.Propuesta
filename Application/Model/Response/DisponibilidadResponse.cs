using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Response
{
    public class DisponibilidadResponse
    {
        public int DisponibilidadSemanalId { get; set; }
        public int DiaSemana { get; set; }
        public string HorarioInicio { get; set; }
        public string HorarioFin { get; set; }
    }
}

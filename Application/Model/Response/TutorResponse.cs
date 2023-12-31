﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Response
{
    public class TutorResponse
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public string FotoPerfil { get; set; }
        public string Domicilio { get; set; }
        public string FechaNacimiento { get; set; }
        public int? EstadoUsuarioId { get; set; }
    }
}

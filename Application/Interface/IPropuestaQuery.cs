﻿using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IPropuestaQuery
    {
        Task<Propuesta> GetPropuesta(int PropuestaID);

        Task<List<Propuesta>> GetPropuestas();

        Task<List<Propuesta>> GetPropuestasByEstado(int EstadoPropuestaID);
    }
}
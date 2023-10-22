﻿using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IEstadoPropuestaCommand
    {
        Task InsertEstadoPropuesta(EstadoPropuesta EstadoPropuesta);
        Task RemoveEstadoPropuesta(int EstadoPropuestaID);

    }
}
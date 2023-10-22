using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IPropuestaCommand
    {
        Task InsertPropuesta(Propuesta Propuesta);
        Task RemovePropuesta(int PropuestaID);

        Task UpdatePropuesta(Propuesta Propuesta);

        Task DeletePropuesta(int PropuestaID);



    }
}

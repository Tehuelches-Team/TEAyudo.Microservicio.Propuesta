using Application.Interface;
using Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class PropuestaCommand : IPropuestaCommand
    {
        public Task DeletePropuesta(int PropuestaID)
        {
            throw new NotImplementedException();
        }

        public Task InsertPropuesta(Propuesta Propuesta)
        {
            throw new NotImplementedException();
        }

        public Task RemovePropuesta(int PropuestaID)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePropuesta(Propuesta Propuesta)
        {
            throw new NotImplementedException();
        }
    }
}

using Application.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.acompanantes
{
    public interface IAcompananteQuery
    {
        Task<List<AcompananteResponse>> GetAllAcompanantes();
        Task<AcompananteResponse> GetAcompananteById(int Id);
    }
}

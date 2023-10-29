using Application.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Tutores
{
    public interface ITutorQuery
    {
        Task<List<TutorResponse>> GetAllTutores();
        Task<TutorResponse> GetTutorById(int Id);
    }
}

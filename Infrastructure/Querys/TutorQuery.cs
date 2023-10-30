using Application.Interface.Tutores;
using Application.Model.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class TutorQuery : ITutorQuery
    {
        async Task<List<TutorResponse>>? ITutorQuery.GetAllTutores()
        {
            var Client = new RestClient("https://localhost:7044");
            var Resquest = new RestRequest("/api/Tutor");
            RestResponse Response = await Client.ExecuteGetAsync(Resquest);
            //return await Client.GetJsonAsync<List<UsuarioResponse>>("/api/Usuario");
            if (Response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            return JsonSerializer.Deserialize<List<TutorResponse>>(Response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        async Task<TutorResponse?> ITutorQuery.GetTutorById(int Id)
        {
            var Client = new RestClient("https://localhost:7044");
            return await Client.GetJsonAsync<TutorResponse>("/api/Tutor/" + Id);
        }
    }
}

using Application.Interface.acompanantes;
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
    public class AcompananteQuery : IAcompananteQuery
    {
        async Task<List<AcompananteResponse>>? IAcompananteQuery.GetAllAcompanantes()
        {
            var Client = new RestClient("https://localhost:7235");
            var Resquest = new RestRequest("/api/Acompanantes");
            RestResponse Response = await Client.ExecuteGetAsync(Resquest);
            //return await Client.GetJsonAsync<List<UsuarioResponse>>("/api/Usuario");
            if (Response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            return JsonSerializer.Deserialize<List<AcompananteResponse>>(Response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        async Task<AcompananteResponse?> IAcompananteQuery.GetAcompananteById(int Id)
        {
            var Client = new RestClient("https://localhost:7235");
            return await Client.GetJsonAsync<AcompananteResponse>("/api/Acompanantes/" + Id);
        }
    }
}

using HotelSearch.Web.Models.Request.Authentication;
using HotelSearch.Web.Models.Response.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HotelSearch.Web.Controllers
{
    public class TokenController : Controller
    {
        public async Task<string> Login()
        {
            //request
            LoginRequest loginRequest = new LoginRequest();
            //post 
            var httpclient = new HttpClient();
           
            var response = await httpclient.PostAsJsonAsync("http://service.stage.paximum.com/v2/api/authenticationservice/login", loginRequest);

            var id = await response.Content.ReadAsStringAsync();

            LoginResponse deserializedJson = JsonConvert.DeserializeObject<LoginResponse>(id);
            

            return deserializedJson.body.token.ToString();
        }
    }
}

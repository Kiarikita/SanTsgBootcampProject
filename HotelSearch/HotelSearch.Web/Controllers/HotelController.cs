using HotelSearch.Application.Interfaces;
using HotelSearch.Data;
using HotelSearch.Web.Models.Request.HotelProduct;
using HotelSearch.Web.Models.Response.HotelProduct;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HotelSearch.Web.Controllers
{
    public class HotelController : Controller
    {
        private string token = "";
        private readonly HotelSearchDbContext _context;
        private readonly IEmailService _emailservice;
        private readonly ILogger<HotelController> _logger;

        private List<string> cities = new List<string>();

        public HotelController(HotelSearchDbContext context, ILogger<HotelController> logger, IEmailService emailservice)
        {
            _context = context;
            _logger = logger;
            _emailservice = emailservice;
        }

        public JsonResult CityList()
        {
            return Json(cities);
        }

        public async Task<IActionResult> GetArrivalAutocomplete(string cityid)
        {
            
            //request
            GetArrivalAutocompleteRequest getArrivalRequest = new GetArrivalAutocompleteRequest();
            //post
            var httpclient = new HttpClient();
            //token ekledim
            httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //post
            var response = await httpclient.PostAsJsonAsync("http://service.stage.paximum.com/v2/api/productservice/getarrivalautocomplete", getArrivalRequest);

            var id = await response.Content.ReadAsStringAsync();
            GetArrivalAutocompleteResponse.Root deserializedJson = JsonConvert.DeserializeObject<GetArrivalAutocompleteResponse.Root>(id);
            
            return View();
        }

        public async Task<IActionResult> PriceSearch(string cityid)
        {
            List<string> list = new List<string>();
            //request
            PriceSearchHotelRequest.ArrivalLocation addCity = new PriceSearchHotelRequest.ArrivalLocation() { id = cityid };

            PriceSearchHotelRequest.Root priceSearchHotelRequest = new PriceSearchHotelRequest.Root();
            priceSearchHotelRequest.arrivalLocations.Add(addCity);
            //post
            var httpclient = new HttpClient();
            //token ekledim
            httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //post
            var response = await httpclient.PostAsJsonAsync("http://service.stage.paximum.com/v2/api/productservice/pricesearch", priceSearchHotelRequest);

            var id = await response.Content.ReadAsStringAsync();
            PriceSearchHotelResponse.Rootobject deserializedJson = JsonConvert.DeserializeObject<PriceSearchHotelResponse.Rootobject>(id);
            foreach (var item in deserializedJson.body.hotels)
            {
                list.Add(item.name);
            }
            return View(list);
        }
    }
}
using HotelSearch.Application.Interfaces;
using HotelSearch.Data;
using HotelSearch.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace HotelSearch.Web.Controllers
{
    public class HotelController : Controller
    {
        private string token = "";
        private readonly HotelSearchDbContext _context;
        private readonly IEmailService _emailservice;
        private readonly ILogger<HotelController> _logger;

       List<string> cities = new List<string>();

        public HotelController(HotelSearchDbContext context, ILogger<HotelController> logger, IEmailService emailservice)
        {
            _context = context;
            _logger = logger;
            _emailservice = emailservice;
            login();
        }  
        void login()
        {
            Models.Request.Authentication.LoginRequest request = new Models.Request.Authentication.LoginRequest();
            request.Agency = "PXM25397";
            request.User = "USR1";
            request.Password = "test!23";
            Models.Response.Authentication.LoginResponse response = Api.Post<Models.Response.Authentication.LoginResponse>(Global.LoginUrl, request);
            this.token = response.body.token;
        }
   
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TrCityList()
        {

            Models.Request.HotelProduct.GetArrivalAutocompleteRequest request = new Models.Request.HotelProduct.GetArrivalAutocompleteRequest();
            request.Culture = "en-US";
            request.ProductType = 2;
            request.Query = "anta";

            Models.Response.HotelProduct.GetArrivalAutocompleteResponse response = Api.Post<Models.Response.HotelProduct.GetArrivalAutocompleteResponse>(Global.GetArrivalautocompleteUrl, request, token);

            var myList = response.body.items.Where(a => a.country.id.Equals("TR"));
 

            foreach (var item in myList)
            {
                cities.Add(item.city.name);
            }
      
            return View(response);
        }

        public IActionResult HotelList(string City/*, string Country*/)
        {

            Models.Request.HotelProduct.GetArrivalAutocompleteRequest request = new Models.Request.HotelProduct.GetArrivalAutocompleteRequest();
            request.Culture = "en-US";
            request.ProductType = 2;
            request.Query = "Antalya";

            Models.Response.HotelProduct.GetArrivalAutocompleteResponse response = Api.Post<Models.Response.HotelProduct.GetArrivalAutocompleteResponse>(Global.GetArrivalautocompleteUrl, request, token);

            var hotelList = response.body.items.Where(a => a.type == 2).ToList();

            return View(hotelList);
        }

        public IActionResult ProductInfoList(string Hotel/*, string Country*/)
        {

            Models.Request.ProductInfoRequest.Root request = new Models.Request.ProductInfoRequest.Root();    
            request.productType = 2;
            request.ownerProvider = 2;
            request.product = "102576";
            request.culture = "en-US";

            Models.Response.ProductInfoResponse.Root response = Api.Post<Models.Response.ProductInfoResponse.Root>(Global.ProductInfoUrl, request, token);

            var hotelInfoList = response.body.hotel;

            return View(hotelInfoList);
        }

        //public JsonResult CityList()
        //{
        //    return Json(cities);
        //}
 
    }
}

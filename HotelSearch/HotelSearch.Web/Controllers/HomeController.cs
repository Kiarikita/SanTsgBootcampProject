using HotelSearch.Application.Interfaces;
using HotelSearch.Data;
using HotelSearch.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSearch.Web.Controllers
{
    public class HomeController : Controller 
    {
        private string token = "";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            login();
        }

        public IActionResult Index()
        
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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


    }
}

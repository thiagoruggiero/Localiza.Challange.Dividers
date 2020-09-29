using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Localiza.Challange.Dividers.Models;
using Localiza.Challange.Dividers.Services.Interfaces;

namespace Localiza.Challange.Dividers.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDividersService _dividersService;

        public HomeController(IDividersService dividersService)
        {
            _dividersService = dividersService;
        }

        public IActionResult Index()
        {
            return View(new NumberModel());
        }

        public IActionResult Privacy()
        {
            return View(new NumberModel());
        }

        public IActionResult Calculate(int number)
        {
            var dividers = _dividersService.GetDividers(number);
            return View("Index", new NumberModel() { Dividers = new ResponseDividers() { AllDividers = dividers.AllDividers, PrimeDividers = dividers.PrimeDividers } });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

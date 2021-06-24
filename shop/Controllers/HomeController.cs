using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shop.Data.interfaces;
using shop.Data.Models;
using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace shop.Controllers
{
    public class HomeController : Controller
    {
        private iAllCars  _carRep;
        public HomeController(iAllCars carRep)
        {
            _carRep = carRep;
        }
        public ViewResult Index() 
        {
            var homeCars = new HomeViewModels { favCars = _carRep.getFavCars};
            return View(homeCars); 

        
        }

    }
}



//private readonly ILogger<HomeController> _logger;

//public HomeController(ILogger<HomeController> logger)
//{
//    _logger = logger;
//}

//public IActionResult Index()
//{
//    return View();
//}

//public IActionResult Privacy()
//{
//    return View();
//}

//[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//public IActionResult Error()
//{
//    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//}
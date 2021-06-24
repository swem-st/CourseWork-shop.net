using Microsoft.AspNetCore.Mvc;
using shop.ViewModels;
using shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.Data.Models;

namespace shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly iAllCars _allCars;
        private readonly iCarsCategory _allCategories;
        public CarsController(iAllCars iAllC, iCarsCategory iCarsCat)
        {
            _allCars = iAllC;
            _allCategories = iCarsCat;

        }
        [Route("Cars/List")]

        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars=null;
            string curCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Electric", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Electric")).OrderBy(i => i.id);
                    curCategory = "Electric";
                }
                else if (string.Equals("Fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Clasic AUTO")).OrderBy(i => i.id);
                    curCategory = "Clasic AUTO";
                }
                curCategory = _category;
            }



            var carObj = new CarsListViewModel 
            {
                allCars = cars,
                carCategory = curCategory
            };


        ViewBag.Title = "Auto PAGE";

            return View(carObj);
        }
    }
}

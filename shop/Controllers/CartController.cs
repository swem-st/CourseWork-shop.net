using Microsoft.AspNetCore.Mvc;
using shop.Data.interfaces;
using shop.Data.Models;
using shop.Data.Repository;
using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace shop.Controllers
{
    public class CartController : Controller
    {
        private readonly iAllCars  _carRep;
        private readonly ShopCart _shopCart;


        public CartController(iAllCars carRep, ShopCart shopCart) 
        {
            _carRep = carRep;
                _shopCart = shopCart;
        }
        public ViewResult Index() 
        {
            var items = _shopCart.GetShopItems();
            _shopCart.listShopItems = items;


            var obj = new CartViewModels 
            {
                shopCart = _shopCart 
            };
            return View(obj);

        }
        //this function add product to cart and refer to cart page
        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}


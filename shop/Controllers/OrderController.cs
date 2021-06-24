using Microsoft.AspNetCore.Mvc;
using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class OrderController :Controller
    {

        private readonly iAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController (iAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }


        public IActionResult Checkout() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.GetShopItems();
            if (shopCart.listShopItems.Count == 0) 
            {
                ModelState.AddModelError("","You don't have order");            
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Your order successfully processed.";
            return View();
        }


    }
}

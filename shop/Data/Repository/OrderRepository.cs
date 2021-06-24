using Microsoft.EntityFrameworkCore;
using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Repository
{
    public class OrderRepository : iAllOrders
    {

        private readonly AppDBContent appDBcontent;
        private readonly ShopCart shopCart;
        public OrderRepository(AppDBContent appDBContent,ShopCart shopCart) {
            this.appDBcontent = appDBContent;
            this.shopCart = shopCart;
        }
      
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBcontent.Order.Add(order);

            var items = shopCart.listShopItems;
            foreach (var el in items) 
            {
                var orderDetail = new OrderDetail() {
                    CarId = el.car.id,
                    orderId = order.Id,
                     price = el.car.price
                };
                appDBcontent.OrderDetail.Add(orderDetail);
            }
            appDBcontent.SaveChanges();
        }

       

    }
}

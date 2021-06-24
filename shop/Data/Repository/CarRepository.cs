using Microsoft.EntityFrameworkCore;
using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Repository
{
    public class CarRepository : iAllCars
    {

        private readonly AppDBContent appDBcontent;
        public CarRepository(AppDBContent appDBContent) {
            this.appDBcontent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBcontent.Car.Include(c => c.Category);

   
        public Car getObjectCar(int carID) => appDBcontent.Car.FirstOrDefault(g => g.id == carID);     public IEnumerable<Car> getFavCars => appDBcontent.Car.Where(g => g.isFavorite).Include(c => c.Category);

    }
}

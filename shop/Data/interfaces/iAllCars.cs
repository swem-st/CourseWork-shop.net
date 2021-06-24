﻿using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.interfaces
{
    public interface iAllCars
    {

        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carID);

    }
}

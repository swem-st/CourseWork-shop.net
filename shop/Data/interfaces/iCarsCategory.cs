using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.interfaces
{
    public interface iCarsCategory
    {

        IEnumerable<Category> AllCategories { get; }
    }
}

using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCategory : iCarsCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category> {  
                new Category{categoryName="Electric", desc="Cars with electric engine" },
                new Category{categoryName="Clasic AUTO", desc="Cars with fuel engine"}
                };
            }
        }
    }
    
}

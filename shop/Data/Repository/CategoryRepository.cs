using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Repository
{
    public class CategoryRepository : iCarsCategory
    {
        private readonly AppDBContent appDBcontent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBcontent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBcontent.Category;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Category
    {
        public int ID { set; get; }
        public string categoryName { set; get; }

        public string desc { set; get; }
        public List<Car> cars { set; get; }
    }
}

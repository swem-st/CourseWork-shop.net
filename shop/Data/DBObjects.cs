using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data
{
    public class DBObjects
    {
        
        public static void Initial(AppDBContent content)
        {
             if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));

            };
            if (!content.Car.Any())
            {
                content.AddRange
                    (
                      new Car
                      {
                          name = "Renault Megane",
                          shortDesc = "Gold average",
                          longDesc = "Gold average speed, comfort and money ",
                          img = "https://images.caradisiac.com/logos-ref/modele/modele--renault-megane-4/S7-modele--renault-megane-4.jpg",
                          price = 30000,
                          isFavorite = true,
                          available = true,
                          Category = Categories["Electric"]
                      },
                    new Car
                    {
                        name = "Bmv M4",
                        shortDesc = "Speed",
                        longDesc = "You get great speed and enjoy your driving",
                        img = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/BMW_M4_GTS_1X7A8158.jpg/800px-BMW_M4_GTS_1X7A8158.jpg",
                        price = 30000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Clasic AUTO"]
                    },
                    new Car
                    {
                        name = "AudiEtron",
                        shortDesc = "ElectroCross",
                        longDesc = "Silent and Economic auto with Germany quality and The best Comfort ever",
                        img = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-audi-q4-e-tron-1588264942.jpg?crop=0.792xw:0.594xh;0.0208xw,0.209xh&resize=1200:*",
                        price = 50000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Electric"]
                    },
                    new Car
                    {
                        name = "Mercedes EQ",
                        shortDesc = "Future",
                        longDesc = "Future with all new technoly that have our world",
                        img = "https://cdn.slashgear.com/wp-content/uploads/2018/08/mercedes-ev-compact-980x463-980x463.jpg",
                        price = 60000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Clasic AUTO"]
                    }
                    );

            };
            content.SaveChanges();

        }

      
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get 
            {
                if (category == null) 
                {
                    var list = new Category[] 
                    {
                         new Category{categoryName="Electric", desc="Cars with electric engine" },
                         new Category{categoryName="Clasic AUTO", desc="Cars with fuel engine"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category i in list) { category.Add(i.categoryName, i); }
                }
                return category; 
            }
            
                    
        }
    }
}

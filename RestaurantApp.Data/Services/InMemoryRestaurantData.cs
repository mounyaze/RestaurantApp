using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id=1, Name="Le Merisier", Cuisine=CuisineType.French},
                new Restaurant { Id=2, Name="Abtal Cham", Cuisine=CuisineType.Syrian},
                new Restaurant { Id=3, Name = "Dar Al Naji", Cuisine =CuisineType.Moroccan}
            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);

        }
    }

}

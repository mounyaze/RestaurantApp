﻿using System;
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

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            if (restaurant != null) 
            { 
                restaurants.Remove(restaurant);
            
            }

        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);

        }

        public void Update(Restaurant restaurant)
        {
            var updatedRestaurant = Get(restaurant.Id);
            if(updatedRestaurant != null)
            {
                updatedRestaurant.Name= restaurant.Name;
                updatedRestaurant.Cuisine= restaurant.Cuisine;
            }
        }
    }

}

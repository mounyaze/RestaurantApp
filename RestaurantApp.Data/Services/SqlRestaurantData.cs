using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly RestaurantAppContext db;

        public SqlRestaurantData(RestaurantAppContext db)
        {
            this.db = db;
        }
        public void Add(Restaurant restaurant)
        {
            db.restaurants.Add(restaurant);
            db.SaveChanges();   
        }

        public Restaurant Get(int id)
        {
            return db.restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in db.restaurants orderby r.Name select r;
        }

        public void Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State= EntityState.Modified;
            //var Existing = Get(restaurant.Id);
            //Existing.Name = restaurant.Name;
            db.SaveChanges();
        }
    }
}

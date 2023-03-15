using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data
{
    public class Restaurant
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Services
{
    public class RestaurantAppContext : DbContext
    {
        public DbSet<Restaurant> restaurants { get; set; }
    }
}

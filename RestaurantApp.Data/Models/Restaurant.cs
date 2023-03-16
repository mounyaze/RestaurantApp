using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Display(Name="Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}

using RestaurantApp.Data;
using RestaurantApp.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantApp.Web.Api
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }
        public IEnumerable<Restaurant> Get() 
        {
            var mdoel = db.GetAll();
            return mdoel;
        }
    }
}

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
        public String Get() 
        {
            return "hey there its me again !";
        }
    }
}

using RestaurantApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(String name)
        {
            var model = new GreetingViewModel();
            model.Name = name ?? "Stranger ";
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}
using Foodie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//This is the Controller page that directs which views are displayed and what data is sent and in what form

namespace Foodie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //This Gets the data from the pre-created array and displays it to a string on the home index page
        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                //string? FavDish = r.FavDish ?? "It's all tasty";

                restList.Add($"#{r.Rank}. {r.RestName} | BEST DISH: {r.FavDish} | ADDRESS: {r.Address} | PHONE: {r.RestPhone} | WEBSITE: {r.WebLink}");
            }

            return View(restList);
        }

        //This View gets the data from the Temp Storage to display all the entries from site users
        //[HttpGet("List")]
        public IActionResult RestList()
        {
            //return View();
            return View(TempStorage.Applications);
        }

        [HttpGet]
        public IActionResult AddRest()
        {
            return View();
        }

        //This takes the submission, and as long as the data is in an acceptable format it will direct the user to a confirmation page
        // otherwise it will display any errors and fail to save the input to local storage
        [HttpPost]
        public IActionResult AddRest(ApplicationResponse appResponse)
        {
            //TempStorage.AddApplication(appResponse);
            //return View("AddRest");
            if (ModelState.IsValid)
            { 
                TempStorage.AddApplication(appResponse);
                return View("Confirmation");
                //Response.redirect
            }
            else
            {
                return View("AddRest");
            }


        }
        //Confirmation page view
        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

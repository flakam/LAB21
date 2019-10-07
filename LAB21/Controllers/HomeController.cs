using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LAB21.Models;

namespace LAB21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
        public IActionResult Result()
        {
          

            return View();
        }

        [HttpGet]
        public IActionResult Result(User u)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FirstName = u.FirstName;
                return View();
            }

            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}

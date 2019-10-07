using LAB21.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB21.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult HtmlValidation()
        {
            return View();
        }
        public IActionResult UserResult(User u)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = u.FirstName;
                return View(u);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
           
       
        
    }
}

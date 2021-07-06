using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "You just created a ASP.Net Core web application!";
        Object obj1 = typeof(Type);
        Object obj2 = typeof(String);
     
           if(obj2.Equals(obj2)){ 
            return null;
            }
           
            return View();
        }

        public IActionResult Error()
        {
            ViewData["Message"] = "We've encountered an error :(";
            return View();
        }
    }
}

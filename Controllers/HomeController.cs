using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jQWidgets.AspNetCore.Mvc.Bootstrap.Demos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Components()
        {
            ViewData["Message"] = "Your Components page.";

            return View();
        }

        public IActionResult JavaScript()
        {
            ViewData["Message"] = "Your JavaScript page.";

            return View();
        }

        public IActionResult Setup()
        {
            ViewData["Message"] = "Your Setup page.";

            return View();
        }

        public IActionResult Download()
        {
            ViewData["Message"] = "Your Download page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

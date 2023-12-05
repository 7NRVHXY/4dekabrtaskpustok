using _4dekabrtask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _4dekabrtask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}
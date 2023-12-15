using _4dekabrtask.Context;
using _4dekabrtask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _4dekabrtask.Controllers
{
    public class HomeController : Controller
    {
        PustokDbContext _db {  get; }

        public HomeController(PustokDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
       // public async Task<IActionResult> ProductPagination(int page = 1, int count = 8)
       // var items = _context.Products.Where(p => !p.IsDeleted).Skip((page-1)*count).Take(count).Select(p => new AdminProdectList)
    }
}
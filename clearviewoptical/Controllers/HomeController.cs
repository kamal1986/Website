using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using clearviewoptical.Models;
using Microsoft.EntityFrameworkCore;
using clearviewoptical.DB;

namespace clearviewoptical.Controllers
{
    public class HomeController : Controller
    {
        private readonly clearviewopticalContext _db;

        public HomeController(clearviewopticalContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
           
            var getCat = _db.ProductCatMaster.ToListAsync();
            var Count = getCat.Result;
            return View(getCat.Result);
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

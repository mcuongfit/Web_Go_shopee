using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCKTEAM30.Models;

namespace NETCKTEAM30.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            if (HttpContext.Session.Get<int>("a") == 2)
            {
                return View();
            }
            if (HttpContext.Session.Get<int>("a") != 1)
            {
                HttpContext.Session.Set<NguoiDung>("MaKH", null);
                return View();
            }

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
        public IActionResult quanlytrangweb()
        {
            return View();
        }
    }
}

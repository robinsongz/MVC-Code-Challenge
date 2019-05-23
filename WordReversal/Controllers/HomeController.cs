using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordReversal.Models;

namespace WordReversal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string input)
        {
            if (input == null)
            {
                return View();
            }
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            ViewData["Input"] = new string(charArray);

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

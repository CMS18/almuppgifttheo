using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ALMTheo.Models;

namespace ALMTheo.Controllers
{
    public class HomeController : Controller
    {


        public bool firsttime;

        public IActionResult Index()
        {
            if (firsttime == false)
            {
                var model = new BankRepository();
                firsttime = true;
                return View("Index", model);
            }
            else { return View("Index"); }

        }

        public IActionResult Update(BankRepository repo)
        {
            return View("Index", repo);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMTheo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALMTheo.Controllers
{
    public class TransactionsController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult PutMoney(decimal money, int account)
        {
            var repo = new BankRepository();
        
            var currAccount = repo.PutMoney(money, account);
            if (currAccount)
            {
                return View("~/Views/Home/Index.cshtml", repo);
            }
            ViewBag.Error = "You shall not Deposit your money, into the void";
            return View("Index");

        }

        public IActionResult TakeMoney(decimal money, int account)
        {
            var repo = new BankRepository();

            var currAccount = repo.TakeMoney(money, account);
            if (currAccount)
            {
                return View("~/Views/Home/Index.cshtml", repo);
            }
            ViewBag.Error = "You are doing wrong";
            return View("Index");
        }

        
    }
}

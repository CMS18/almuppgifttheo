using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMTheo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALMTheo.Controllers
{
    public class TransferController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Transfer(int accountFrom, int accountTo, decimal money)
        {
            var repo = new BankRepository();

            var transfer = repo.Transfer(accountFrom, accountTo, money);

            if (transfer)
            {
                return View("~/Views/Home/Index.cshtml", repo);
            }

            ViewBag.Error = "Something went wrong. Make sure you use existing account numbers, and that the amount is correct.";

            return View("Index");
        }
    }
}

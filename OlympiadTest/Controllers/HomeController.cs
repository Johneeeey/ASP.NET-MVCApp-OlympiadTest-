using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OlympiadTest.Models;

namespace OlympiadTest.Controllers
{
    public class HomeController : Controller
    {
        TestContext db;
        public HomeController(TestContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.BankOfQuestion.ToList());
        }

    }
}

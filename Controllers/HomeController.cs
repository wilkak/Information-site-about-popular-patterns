using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Chainofresponsibilily()
        {
            return View();
        }

        public IActionResult Command()
        {
            return View();
        }

        public IActionResult Interpreter()
        {
            return View();
        }
        public IActionResult Iterator()
        {
            return View();
        }
        public IActionResult Mediator()
        {
            return View();
        }
        public IActionResult Memento()
        {
            return View();
        }
        public IActionResult Observer()
        {
            return View();
        }
        public IActionResult State()
        {
            return View();
        }
        public IActionResult Strategy()
        {
            return View();
        }
        public IActionResult Templatemethod()
        {
            return View();
        }
        public IActionResult Visitor()
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

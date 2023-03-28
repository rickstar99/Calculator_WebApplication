using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult OperationPressed(CalculatorModel model)
            =>  View("Index", model);
        

            public IActionResult Calculate(CalculatorModel model)
        {
            switch (model.Operation)
            {
                case "Addition" :
                    model.Result = model.FirstNumber + model.SecondNumber;
                    break;

                case "Division":
                    model.Result = model.FirstNumber / model.SecondNumber;
                    break;

                case "Multiplication":
                    model.Result = model.FirstNumber * model.SecondNumber;
                    break;

                case "Subtraction":
                    model.Result = model.FirstNumber - model.SecondNumber;
                    break;

                case null:                    
                    break;
            }


            return View("Index", model);
        }

        public IActionResult Index()
        {
            CalculatorModel model = new CalculatorModel();
            return View(model);
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

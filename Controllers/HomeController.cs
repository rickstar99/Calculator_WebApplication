using AutoMapper;
using Calculator.Models;
using Calculator.UseCases.Calculate;
using MediatR;
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
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _mediator = mediator;
        }


        public IActionResult OperationPressed(CalculatorModel model)
            =>  View("Index", model);
        

            public async Task<IActionResult> Calculate(CalculatorModel model)
        {
            var request = _mapper.Map<CalculatorRequest>(model);
            var response = await _mediator.Send(request);

            model.Result = response.Result;

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

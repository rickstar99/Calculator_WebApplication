using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator.UseCases.Calculate
{
    public class CalculatorInteractor : IRequestHandler<CalculatorRequest, CalculatorResponse>
    {
        Task<CalculatorResponse> IRequestHandler<CalculatorRequest, CalculatorResponse>.Handle(CalculatorRequest request, CancellationToken cancellationToken)
        {
            var response = new CalculatorResponse();

            switch (request.Operation)
            {
                case "Addition":
                    response.Result = request.FirstNumber + request.SecondNumber;
                    break;

                case "Division":
                    response.Result = request.FirstNumber / request.SecondNumber;
                    break;

                case "Multiplication":
                    response.Result = request.FirstNumber * request.SecondNumber;
                    break;

                case "Subtraction":
                    response.Result = request.FirstNumber - request.SecondNumber;
                    break;

                case null:
                    break;
            }

            return Task.FromResult(response);
        }
    }
}

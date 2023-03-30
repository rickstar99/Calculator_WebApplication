using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Calculator.UseCases.Calculate
{
    public class CalculatorRequest : IRequest<CalculatorResponse>
    {
        public double FirstNumber { get; set; }

        public double SecondNumber { get; set; }

        public string Operation { get; set; }

        public double Result { get; set; }
    }
}

using AutoMapper;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.UseCases.Calculate
{
    public class CalculatorMapping : Profile
    {
        public CalculatorMapping()
            => this.CreateMap<CalculatorModel, CalculatorRequest>();
        
    }
}

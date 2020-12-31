using Enities;
using Enities.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator;

namespace TaxClient
{
    public class TaxClient : ITaxClient
    {
        public async Task<ITaxCalculatorResponse> Handle(ITaxRequest taxRequest)
        {
            CalculatorService calculatorService = new CalculatorService();
            return await calculatorService.Send(taxRequest);
        }
    }
}

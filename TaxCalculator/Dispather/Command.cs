using Enities;
using Enities.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Dispather
{
    public class Command : ICommand
    {
        public ITaxRequest TaxRequest { get; set; }
        public ITaxCalculatorResponse TaxResponse { get ; set; }
    }
}

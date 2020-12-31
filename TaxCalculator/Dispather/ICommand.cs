using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Enities;
using Enities.Requests;
using Enities.Utility;

namespace TaxCalculator.Dispather
{
    public interface ICommand
    {
        ITaxRequest TaxRequest { get; set; }
        ITaxCalculatorResponse TaxResponse { get; set; } 
    }
}

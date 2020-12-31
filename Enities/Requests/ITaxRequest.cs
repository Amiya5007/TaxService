using System;
using System.Collections.Generic;
using System.Text;
using Enities.Utility;


namespace Enities
{
    public interface ITaxRequest
    {
        Common.CalculatorTypeType CalculatorType { get; set; }
        Common.CommandName CommandName { get; set; }
        string ZipCode { get; set; }
        string ToCountry { get; set; }
        string ToState {get; set;}
        float Shipping { get; set; }
        string FromCountry { get; set; }
        string FromZip { get; set; }
        string FromState { get; set; }
        string FromCity { get; set; }
        string ToCity { get; set; }
        float Amount { get; set; }

    }
}

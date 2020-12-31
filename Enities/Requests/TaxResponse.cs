using Enities.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enities.Requests
{
    public class TaxCalculatorResponse : ITaxCalculatorResponse
    {

        public object ResponseData { get; set; }
        public Response Response { get; set; }
       
    }
     
}

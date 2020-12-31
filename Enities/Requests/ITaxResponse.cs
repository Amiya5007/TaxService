using Enities.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enities.Requests
{
    public interface ITaxCalculatorResponse
    {
        object ResponseData { get; set; }
        Response Response { get; set; }
    }
}

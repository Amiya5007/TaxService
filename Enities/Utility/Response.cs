using System;
using System.Collections.Generic;
using System.Text;

namespace Enities.Utility
{
    public class Response
    {
        public Common.ProcessState Status { get; set; }
        public string StatusMessage { get; set; }
        public Response()
        {
            Status = Common.ProcessState.Success;
            StatusMessage = "Success";
        }
    }
}

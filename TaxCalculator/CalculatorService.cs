using Enities;
using Enities.Requests;
using Enities.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Dispather;

namespace TaxCalculator
{
    public class CalculatorService
    {
        public async  Task<ITaxCalculatorResponse> Send(ITaxRequest taxRequest) 
        {
            ICommand command = new Command();
            var handler = Factory.GetCommand(taxRequest.CalculatorType);
            if (handler != null)
            {
                command.TaxRequest = taxRequest;
                 
                await handler.Handle(command);
                return command.TaxResponse;
            }
            return new TaxCalculatorResponse() { ResponseData = null, Response = new Response() { Status = Common.ProcessState.Fail, StatusMessage = "No Handler Found" } } ;
        }
    }
}

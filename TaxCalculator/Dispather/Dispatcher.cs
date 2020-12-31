using Enities.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Dispather
{
    public class Dispatcher : IDispatcher<ICommand>
    {
        public async Task Send(ICommand Command)
        {
            var handler = Factory.GetCommand(Command.TaxRequest.CalculatorType);
            if (handler != null)
                await handler.Handle(Command);
            else
                Command.TaxResponse.Response = new Response() { Status = Common.ProcessState.Fail,
                                                                StatusMessage = "Dispatcher can not find the requested handler" };
        }
    }
}

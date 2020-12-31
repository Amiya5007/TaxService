using Enities.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Dispather;
using Taxjar;

namespace TaxCalculator.TaxJar
{
    public class TaxJarHandler : ICommandHandler
    {
        TaxjarApi client = null;
        public TaxJarHandler()
        {
            client = new TaxjarApi("5da2f821eee4035db4771edab942a4cc");
        }
        public async Task Handle(ICommand Command)
        {
            switch (Command.TaxRequest.CommandName)
            {
                case Enities.Utility.Common.CommandName.GetTaxrateLocationWise:
                   await GetTaxrateLocationWise(Command);
                    break;
                case Enities.Utility.Common.CommandName.GetTaxOnOrder:
                    await GetTaxOnOrder(Command);
                    break;
                default:
                    Command.TaxResponse = new TaxCalculatorResponse()
                    {
                        ResponseData = null,
                        Response = new Enities.Utility.Response() { Status = Enities.Utility.Common.ProcessState.Fail, StatusMessage = $"No Command Found" }
                    };
                    break;
            }
        }
        private async Task GetTaxOnOrder(ICommand command)
        {
            var xx = JsonConvert.SerializeObject(command.TaxRequest);
            try
            {
                
                var tax = await client.TaxForOrderAsync(new
                {
                    from_country = command.TaxRequest.FromCountry,
                    from_zip = command.TaxRequest.FromZip,
                    from_state = command.TaxRequest.FromState,
                    from_city = command.TaxRequest.FromCity,
                    to_country = command.TaxRequest.ToCountry,
                    to_zip = command.TaxRequest.ZipCode,
                    to_state = command.TaxRequest.ToState,
                    to_city = command.TaxRequest.ToCity,
                    amount = command.TaxRequest.Amount,
                    shipping = command.TaxRequest.Shipping,
                   
                });
                command.TaxResponse = new TaxCalculatorResponse()
                {
                    ResponseData = tax,
                    Response = new Enities.Utility.Response()
                };

            }
            catch (TaxjarException er)
            {
                command.TaxResponse = new TaxCalculatorResponse()
                {
                    ResponseData = null,
                    Response = new Enities.Utility.Response() { Status = Enities.Utility.Common.ProcessState.Fail, StatusMessage = er.ToString() }
                };
            }
            catch (Exception ex)
            {
                command.TaxResponse = new TaxCalculatorResponse()
                {
                    ResponseData = null,
                    Response = new Enities.Utility.Response() { Status = Enities.Utility.Common.ProcessState.Fail,  StatusMessage = ex.ToString()}
                };
            }
            
            
        }
        private async Task GetTaxrateLocationWise(ICommand command)
        {
            try
            {
                command.TaxResponse = new TaxCalculatorResponse()
                {
                    ResponseData = await client.RatesForLocationAsync(command.TaxRequest.ZipCode),
                    Response = new Enities.Utility.Response()
                };
            }
            catch (TaxjarException er)
            {
                command.TaxResponse = new TaxCalculatorResponse()
                {
                    ResponseData = null,
                    Response = new Enities.Utility.Response() { Status = Enities.Utility.Common.ProcessState.Fail, StatusMessage = er.ToString() }
                };
            }
            catch (Exception ex)
            {
                command.TaxResponse = new TaxCalculatorResponse()
                {
                    ResponseData = null,
                    Response = new Enities.Utility.Response() { Status = Enities.Utility.Common.ProcessState.Fail, StatusMessage = ex.ToString() }
                };
            }

        }
    }
}

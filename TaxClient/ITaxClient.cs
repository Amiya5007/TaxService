using Enities;
using Enities.Requests;
using System;
using System.Threading.Tasks;

namespace TaxClient
{
    public interface ITaxClient
    {
        Task<ITaxCalculatorResponse> Handle(ITaxRequest taxRequest);
    }
}

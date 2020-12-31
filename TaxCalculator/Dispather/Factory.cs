
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TaxCalculator.Dispather;
using TaxCalculator.TaxJar;
using Enities.Utility;

namespace TaxCalculator
{
    public static class Factory
    {
        private static Dictionary<string, object> actionList = new Dictionary<string, object>();
        static Factory()
        {
            actionList.Add(Common.CalculatorTypeType.TaxJar.ToString(), new TaxJarHandler());
             
        }
        public static ICommandHandler  GetCommand(Common.CalculatorTypeType calculatorType) 
        {
            return (ICommandHandler)actionList.FirstOrDefault(i => i.Key == calculatorType.ToString()).Value;
        }
    }
}

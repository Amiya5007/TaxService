using System;

namespace Enities.Utility
{
    public static class Common
    {
        public enum CalculatorTypeType
        {
            TaxJar,
            Other
        }
        public enum CommandName
        {
            GetTaxrateLocationWise,
            GetTaxOnOrder,
            Other
        }
        public enum ProcessState
        {
            Fail,
            Success
        }
    }
}

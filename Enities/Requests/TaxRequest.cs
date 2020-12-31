using Enities.Utility;
using Newtonsoft.Json;
using System;

namespace Enities
{
    public class TaxRequest : ITaxRequest
    {
        [JsonIgnore]
        public Common.CalculatorTypeType CalculatorType { get ; set ; }
        [JsonProperty("to_zip")]
        public string ZipCode { get; set ; }
        [JsonIgnore]
        public Common.CommandName CommandName { get; set; }
        [JsonProperty("to_country")]
        public string ToCountry { get ; set ; }
        [JsonProperty("to_state")]
        public string ToState { get ; set ; }
       
        [JsonProperty("amount")]
        public float Amount { get; set; }
        [JsonProperty("shipping")]
        public float Shipping { get; set; }

        [JsonProperty("from_country")]
        public string FromCountry { get; set; }
        [JsonProperty("from_zip")]
        public string FromZip { get; set; }

        [JsonProperty("from_state")]
        public string FromState { get; set; }
        [JsonProperty("from_city")]
        public string  FromCity { get; set; }
        [JsonProperty("to_city")]
        public string ToCity { get; set; }

        public TaxRequest()
        {
            CalculatorType = Common.CalculatorTypeType.Other;
            CommandName = Common.CommandName.Other;
            ZipCode = "";
            ToCountry = "";
            ToState = "";
            Shipping = 0;
            Amount = 0;
            FromCountry = "";
            FromState = "";
            FromZip = "";
            FromCity = "";
            ToCity = "";
        }
    }
}

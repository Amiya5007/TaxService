using Enities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TaxClient;

namespace TaxJarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task GetTaxrateLocationWise()
        {
            ITaxRequest taxRequest = new TaxRequest()
            {
                CalculatorType = Enities.Utility.Common.CalculatorTypeType.TaxJar,
                CommandName = Enities.Utility.Common.CommandName.GetTaxrateLocationWise,
                ZipCode = "90404-3370"
            };
            ITaxClient taxClient = new TaxClient.TaxClient();
            var result = await taxClient.Handle(taxRequest);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public async Task GetTaxOnOrder()
        {
            ITaxRequest taxRequest = new TaxRequest()
            {
                CalculatorType = Enities.Utility.Common.CalculatorTypeType.TaxJar,
                CommandName = Enities.Utility.Common.CommandName.GetTaxOnOrder,
                ZipCode = "90002",
                ToCountry = "US",
                ToState = "CA",
                Amount = 400,
                Shipping = 20,
                FromCountry = "US",
                FromState = "CA",
                FromZip = "92093",
                FromCity = "La Jolla",
                ToCity = "Los Angeles"

            };
            ITaxClient taxClient = new TaxClient.TaxClient();
            var result = await taxClient.Handle(taxRequest);

            Assert.IsNotNull(result.ResponseData);
        }
    }
}

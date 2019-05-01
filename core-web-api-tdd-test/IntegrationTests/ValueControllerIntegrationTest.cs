using core_web_api_tdd.Controllers;
using Xunit;

namespace core_web_api_tdd_test.IntegrationTests
{
    public class ValueControllerIntegrationTest
    {
        [Fact]
        public void IntegrationTest1()
        {
            var valueController = new ValuesController();
            var results = valueController.Get();
            Assert.NotNull(results);
        }
    }
}

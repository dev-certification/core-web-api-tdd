using core_web_api_tdd.Controllers;
using Xunit;

namespace core_web_api_tdd_test.UnitTests
{
    public class ValueContollerUnitTest
    {
        [Fact]
        public void UnitTest1()
        {
            var valueController = new ValuesController();
            var results = valueController.Get();
            Assert.NotNull(results);
        }
    }
}

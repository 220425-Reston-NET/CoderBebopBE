using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest10

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            MoneyMarketAccount test10 = new MoneyMarketAccount();
            int testMAccBalance = 1;

            test10.MAccBalance = testMAccBalance;

            Assert.NotNull(test10.MAccBalance);
            Assert.Equal(testMAccBalance, test10.MAccBalance);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        [InlineData(-100000)]
        [InlineData(-0.01)]
        [InlineData(-2000000)]
        [InlineData(-121212)]      
        public void CoderBebopModel_Should_Fail_Set_InvalidData(double p_found)
        {
          MoneyMarketAccount test10 = new MoneyMarketAccount();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test10.MAccBalance = p_found;
            }
            );
        }
    }   
}
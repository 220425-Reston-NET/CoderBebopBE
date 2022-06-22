using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest7

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            MoneyMarketAccount test7 = new MoneyMarketAccount();
            int testMAccID = 1;

            test7.MAccID = testMAccID;

            Assert.NotNull(test7.MAccID);
            Assert.Equal(testMAccID, test7.MAccID);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        [InlineData(-100000)]
        [InlineData(-20)]
        [InlineData(-2000000)]
        [InlineData(-121212)]      
        public void CoderBebopModel_Should_Fail_Set_InvalidData(int p_found)
        {
            MoneyMarketAccount test7 = new MoneyMarketAccount();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test7.MAccID = p_found;
            }
            );
        }
    }   
}
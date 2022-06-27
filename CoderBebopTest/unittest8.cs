using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest8

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            CheckingAccount test8 = new CheckingAccount();
            int testCAccBalance = 1;

            test8.CAccBalance = testCAccBalance;

            Assert.NotNull(test8.CAccBalance);
            Assert.Equal(testCAccBalance, test8.CAccBalance);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        [InlineData(-100000)]
        [InlineData(-0.01)]
        [InlineData(-2000000)]
        [InlineData(-121212)]      
        public void CoderBebopModel_Should_Fail_Set_InvalidData(decimal p_found)
        {
            CheckingAccount test8 = new CheckingAccount();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test8.CAccBalance = p_found;
            }
            );
        }
    }   
}
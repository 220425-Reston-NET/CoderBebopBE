using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest9

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            SavingsAccount test9 = new SavingsAccount();
            int testSAccBalance = 1;

            test9.SAccBalance = testSAccBalance;

            Assert.NotNull(test9.SAccBalance);
            Assert.Equal(testSAccBalance, test9.SAccBalance);
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
           SavingsAccount test9 = new SavingsAccount();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test9.SAccBalance = p_found;
            }
            );
        }
    }   
}
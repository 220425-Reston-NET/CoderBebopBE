using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest6

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            SavingsAccount test6 = new SavingsAccount();
            int testSAccID = 1;

            test6.SAccID = testSAccID;

            Assert.NotNull(test6.SAccID);
            Assert.Equal(testSAccID, test6.SAccID);
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
            SavingsAccount test6 = new SavingsAccount();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test6.SAccID = p_found;
            }
            );
        }
    }   
}
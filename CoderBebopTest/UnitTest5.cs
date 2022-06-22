using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest5

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            CheckingAccount test5 = new CheckingAccount();
            int testCAccID = 1;

            test5.CAccID = testCAccID;

            Assert.NotNull(test5.CAccID);
            Assert.Equal(testCAccID, test5.CAccID);
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
            CheckingAccount test5 = new CheckingAccount();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test5.CAccID = p_found;
            }
            );
        }
    }   
}
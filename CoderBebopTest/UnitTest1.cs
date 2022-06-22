using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest1

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            Customer test1 = new Customer();
            int testCusID = 1;

            test1.CustID = testCusID;

            Assert.NotNull(test1.CustID);
            Assert.Equal(testCusID, test1.CustID);
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
            Customer test1 = new Customer();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test1.CustID = p_found;
            }
            );
        }
    }   
}
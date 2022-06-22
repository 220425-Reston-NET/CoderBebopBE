using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest3

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            Customer test3 = new Customer();
            decimal testCardNumber = 1234567890123456;

            test3.CardNumber = testCardNumber;

            Assert.NotNull(test3.CardNumber);
            Assert.Equal(testCardNumber, test3.CardNumber);
        }

        [Theory]
        [InlineData(123456789012345)]
        [InlineData(12345678901234)]
        [InlineData(-1234567890123456)]
        [InlineData(12345678901234567)]
        [InlineData(12345678901234567890)]
        [InlineData(-1234567890123456789)]     
        public void CoderBebopModel_Should_Fail_Set_InvalidData(decimal p_found)
        {
            Customer test3 = new Customer();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test3.CardNumber = p_found;
            }
            );
        }
    }   
}
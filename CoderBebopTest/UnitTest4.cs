using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest4

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            Customer test4 = new Customer();
            int testPin = 1234;

            test4.Pin = testPin;

            Assert.NotNull(test4.Pin);
            Assert.Equal(testPin, test4.Pin);
        }

        [Theory]
        [InlineData(999)]
        [InlineData(10000)]
        [InlineData(-1000)]
        [InlineData(1)]
        [InlineData(123456)]
        [InlineData(-9999)]     
        public void CoderBebopModel_Should_Fail_Set_InvalidData(int p_found)
        {
            Customer test4 = new Customer();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test4.Pin = p_found;
            }
            );
        }
    }   
}
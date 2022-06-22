using Xunit;
using CoderBebopModel;

namespace CoderBebopTest
{
    public class UnitTest2

    {
        [Fact]

        public void CoderBebopModel_should_set_validData()
        {
            Customer test2 = new Customer();
            string testPhone = "1234567890";

            test2.Phone = testPhone;

            Assert.NotNull(test2.Phone);
            Assert.Equal(testPhone, test2.Phone);
        }

        [Theory]
        [InlineData("123456789")]
        [InlineData("12345678")]
        [InlineData("1234567")]
        [InlineData("123456")]
        [InlineData("12345")]
        [InlineData("1234")]
        [InlineData("123")]
        [InlineData("12")]
        [InlineData("1")]      
        public void CoderBebopModel_Should_Fail_Set_InvalidData(string p_found)
        {
            Customer test2 = new Customer();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
            {
                test2.Phone = p_found;
            }
            );
        }
    }   
}
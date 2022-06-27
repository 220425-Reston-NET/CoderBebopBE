using CoderBebopBL;
using CoderBebopDL;
using CoderBebopModel;
using Moq;
using Xunit;

namespace CoderBebopTest
{
    public class CoderBebopBLTest1
    {
        [Fact]
        public void Should_Get_All_Customer()
        {
            decimal CardNumber = 1234567890123456;
            int Pin = 1234;
            Customer test = new Customer()
            {
                CardNumber = CardNumber,
                Pin = Pin
            };

            List<Customer> expectedlistofcustomer = new List<Customer>();
            expectedlistofcustomer.Add(test);

            Mock<iCoderBebopDL<Customer>> mockrepo = new Mock<iCoderBebopDL<Customer>>();

            mockrepo.Setup(repo => repo.GetAll()).Returns(expectedlistofcustomer);

            iCustomerBL testBL = new CustomerBL(mockrepo.Object);

            List<Customer> actuallistofcustomer = testBL.GetallCustomer();

            Assert.Same(expectedlistofcustomer, actuallistofcustomer);
            Assert.Equal(CardNumber, actuallistofcustomer[0].CardNumber);
            Assert.Equal(Pin, actuallistofcustomer[0].Pin);
        
            // When
        
            // Then
        }
    }
}
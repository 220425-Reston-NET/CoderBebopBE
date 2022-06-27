using CoderBebopBL;
using CoderBebopDL;
using CoderBebopModel;
using Moq;
using Xunit;

namespace CoderBebopTest
{
    public class CoderBebopBLTest2
    {
        [Fact]
        public void Should_Get_All_Customer()
        {
            int CAccID = 1;
            CheckingAccount test = new CheckingAccount()
            {
                CAccID = CAccID
            };

            List<CheckingAccount> expectedlistofcustomer = new List<CheckingAccount>();
            expectedlistofcustomer.Add(test);

            Mock<iCoderBebopDL<CheckingAccount>> mockrepo = new Mock<iCoderBebopDL<CheckingAccount>>();

            mockrepo.Setup(repo => repo.GetAll()).Returns(expectedlistofcustomer);

            iCheckingBL testBL = new CheckingBL(mockrepo.Object);

            List<CheckingAccount> actuallistofcustomer = testBL.GetallCustomer();

            Assert.Same(expectedlistofcustomer, actuallistofcustomer);
            Assert.Equal(CAccID, actuallistofcustomer[0].CAccID);
        
            // When
        
            // Then
        }
    }
}
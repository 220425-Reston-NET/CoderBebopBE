using CoderBebopBL;
using CoderBebopDL;
using CoderBebopModel;
using Moq;
using Xunit;

namespace CoderBebopTest
{
    public class CoderBebopBLTest3
    {
        [Fact]
        public void Should_Get_All_Customer()
        {
            int SAccID = 1;
            SavingsAccount test = new SavingsAccount()
            {
                SAccID = SAccID
            };

            List<SavingsAccount> expectedlistofcustomer = new List<SavingsAccount>();
            expectedlistofcustomer.Add(test);

            Mock<iCoderBebopDL<SavingsAccount>> mockrepo = new Mock<iCoderBebopDL<SavingsAccount>>();

            mockrepo.Setup(repo => repo.GetAll()).Returns(expectedlistofcustomer);

            iSavingsBL testBL = new SavingsBL(mockrepo.Object);

            List<SavingsAccount> actuallistofcustomer = testBL.GetallCustomer();

            Assert.Same(expectedlistofcustomer, actuallistofcustomer);
            Assert.Equal(SAccID, actuallistofcustomer[0].SAccID);
        
            // When
        
            // Then
        }
    }
}
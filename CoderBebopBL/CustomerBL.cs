using CoderBebopModel;
using CoderBebopDL;

namespace CoderBebopBL
{
    public class CustomerBL : iCustomerBL
    {
    
        private readonly iCoderBebopDL<Customer> _Customer;
        public CustomerBL(iCoderBebopDL<Customer> p_Customer)
        {
            _Customer = p_Customer;
        }

        public void AddCus(Customer p_AddAll)
        {
            p_AddAll.CustID = p_AddAll.PinID;

            Random rand = new Random();
            p_AddAll.AccNumber = rand.Next(50);
            p_AddAll.CardNumber = rand.Next(50);
            p_AddAll.AccNumber = rand.Next(50);
            p_AddAll.Pin = rand.Next(50);

            _Customer.AddCus(p_AddAll);
           
            _Customer.AddCus(p_AddAll);
        }


        public void AddJoin(int p_cusID, int p_PinID, decimal p_CardNum, decimal p_Account)
        {
            throw new NotImplementedException();
        }

        public void AddPin(int p_pin)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetallCustomer()
        {
            return _Customer.GetAll();
        }

        public Customer Search(decimal p_Atm, decimal p1_Atm)
        {
            throw new NotImplementedException();
        }
    }
}

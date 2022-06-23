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

        public void AddCus(Customer p_addAll)
        {
            _Customer.AddCus(p_addAll);
            

            Random rand = new Random();

            p_addAll.Pin = rand.Next(1000,9999);
            p_addAll.CardNumber = (Decimal)(rand.NextDouble()*9000000000000000) + 1000000000000000;


            _Customer.JoinTable(p_addAll);

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

        public Customer Search(decimal p_Atm, int p1_Atm)
        {
            return _Customer.GetAll().First(Customer => Customer.CardNumber == p_Atm && Customer.Pin == p1_Atm);
        }
    }
}

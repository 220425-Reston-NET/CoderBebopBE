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

            Customer foundedcustomer = Search(p_AddAll.CardNumber, p_AddAll.Pin);

            if (foundedcustomer == null)
            {
            _Customer.AddCus(p_AddAll);
            

            Random rand = new Random();

            p_AddAll.Pin = rand.Next(1000,9999);
            p_AddAll.CardNumber = (Decimal)(rand.NextDouble()*9000000000000000) + 1000000000000000;


            _Customer.JoinTable(p_AddAll);
            }

            else
            {
                throw new InvalidOperationException ("Customer already exist!");
            }

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

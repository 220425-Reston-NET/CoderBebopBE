using CoderBebopModel;
using CoderBebopDL;

namespace CoderBebopBL
{
    public class CustomerBL : iCustomerBL
    {
        Customer AddData = new Customer();
        private readonly iCoderBebopDL<Customer> _Customer;
        public CustomerBL(iCoderBebopDL<Customer> p_Customer)
        {
            _Customer = p_Customer;
        }

        public void AddCus(string p_Name, string p_Phone, string p_Address, string p_Email)
        {
            AddData.Name = p_Name;
            AddData.Phone = p_Phone;
            AddData.Address = p_Address;
            AddData.Email = p_Email;

            _Customer.AddCus(AddData);
        }


        public void AddJoin(int p_cusID, int p_PinID, decimal p_CardNum, decimal p_Account)
        {
            throw new NotImplementedException();
        }

        public void AddPin(int p_pin)
        {
            Random rand = new Random();
            p_pin = rand.Next(50);

            AddData.Pin = p_pin;

            _Customer.AddPin(AddData);
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

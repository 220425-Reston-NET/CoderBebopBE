using CoderBebopModel;

namespace CoderBebopBL
{
    public interface iCustomerBL
    {
        void AddCus(string p_Name, string p_Phone, string p_Address, string p_Email);

        void AddPin(int p_pin);

        void AddJoin(int p_cusID, int p_PinID, decimal p_CardNum, decimal p_Account);

        List<Customer> GetallCustomer();

        public Customer Search(decimal p_Atm, decimal p1_Atm);
    }
}
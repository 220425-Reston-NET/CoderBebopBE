using CoderBebopModel;

namespace CoderBebopBL
{
    public interface iCustomerBL
    {
        void AddCus(Customer p_addAll);

        void AddPin(int p_pin);

        void AddJoin(int p_cusID, int p_PinID, decimal p_CardNum, decimal p_Account);

        List<Customer> GetallCustomer();

        public Customer Search(decimal p_Atm, decimal p1_Atm);
    }
}
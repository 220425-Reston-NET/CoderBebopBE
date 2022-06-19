using CoderBebopModel;

namespace CoderBebopDL
{
    public interface iCoderBebopDL<T>
    {
        void AddCus(T p_resource);

        void AddChecking(decimal p_resource);

        void AddSavings(decimal p_resource);

        void AddMonMarket(decimal p_resource);

        void DepositMoney(T p_resource);

        void WithdrawMoney(T p_resource);

        void JoinTable(T p_resource);

        List<Customer> GetAll();

        void verify(decimal p_resource, int p_resource1);
    }
}
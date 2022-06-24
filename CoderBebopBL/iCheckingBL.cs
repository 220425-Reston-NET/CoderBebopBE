using CoderBebopModel;

namespace CoderBebopBL
{
    public interface iCheckingBL
    {
        void AddCheckingAcc(decimal p_account);

        void UpdateDeposit(int p_balance, int p_accID);

        void UpdateWithdraw(int p_balance, int p_accID);
        List<CheckingAccount> GetallCustomer();

        public CheckingAccount viewbalance(int p_balance);
    }
}
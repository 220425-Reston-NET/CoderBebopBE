using CoderBebopDL;
using CoderBebopModel;

namespace CoderBebopBL
{
    public class SavingsBL : iSavingsBL
    {
        private readonly iCoderBebopDL<SavingsAccount> _Savings;

        public SavingsBL(iCoderBebopDL<SavingsAccount> Savings)
        {
           _Savings = Savings;
        }

        public void AddSavingsAcc(decimal p_account)
        {
            Random rand = new Random();
            p_account = (Decimal)(rand.NextDouble()*9000000000) + 1000000000;

            _Savings.AddSavings(p_account);
        }

        public void UpdateDeposit(int p_balance, int p_accID)
        {
            SavingsAccount updatebalance = new SavingsAccount();
            updatebalance.SAccBalance = p_balance;
            updatebalance.SAccID = p_accID;

            _Savings.DepositMoney(updatebalance);
        }

        public void UpdateWithdraw(int p_balance, int p_accID)
        {
            SavingsAccount updatebalance = new SavingsAccount();
            updatebalance.SAccBalance = p_balance;
            updatebalance.SAccID = p_accID;

            _Savings.WithdrawMoney(updatebalance);
        }
    }
}
using CoderBebopDL;
using CoderBebopModel;

namespace CoderBebopBL
{
    public class CheckingBL : iCheckingBL
    {
        private readonly iCoderBebopDL<CheckingAccount> _Checking;

        public CheckingBL(iCoderBebopDL<CheckingAccount> checking)
        {
            _Checking = checking;
        }

        public void AddCheckingAcc(decimal p_account)
        {
           Random rand = new Random();
            p_account = (Decimal)(rand.NextDouble()*9000000000) + 1000000000;

            _Checking.AddChecking(p_account);
        }

        public List<CheckingAccount> GetallCustomer()
        {
            return _Checking.GetAll();
        }

        public void UpdateDeposit(int p_balance, int p_accID)
        {
            CheckingAccount updatebalance = new CheckingAccount();

            updatebalance.CAccBalance = p_balance;
            updatebalance.CAccID = p_accID;

            _Checking.DepositMoney(updatebalance);
        }

        public void UpdateWithdraw(int p_balance, int p_accID)
        {
            CheckingAccount updatebalance = new CheckingAccount();

            updatebalance.CAccBalance = p_balance;
            updatebalance.CAccID = p_accID;

            _Checking.WithdrawMoney(updatebalance);
        }

        public CheckingAccount viewbalance(int p_accID)
        {
        
           
            return _Checking.GetAll().First(CheckingAccount => CheckingAccount.CAccID == p_accID);
           
        }

    }
}
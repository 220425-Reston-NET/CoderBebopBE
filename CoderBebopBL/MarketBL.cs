using CoderBebopDL;
using CoderBebopModel;

namespace CoderBebopBL
{
    public class MarketBL : iMarketBL
    {
        private readonly iCoderBebopDL<MoneyMarketAccount> _Market;

        public MarketBL(iCoderBebopDL<MoneyMarketAccount> market)
        {
            _Market = market;
        }

        public void AddMarketAcc(decimal p_account)
        {
            Random rand = new Random();
            p_account = (Decimal)(rand.NextDouble()*9000000000) + 1000000000;

            _Market.AddMonMarket(p_account);
        }

        public void UpdateDeposit(int p_balance, int p_accID)
        {
            MoneyMarketAccount updatebalance = new MoneyMarketAccount();
            updatebalance.MAccBalance = p_balance;
            updatebalance.MAccID = p_accID;

            _Market.DepositMoney(updatebalance);
        }

        public void UpdateWithdraw(int p_balance, int p_accID)
        {
            MoneyMarketAccount updatebalance = new MoneyMarketAccount();
            updatebalance.MAccBalance = p_balance;
            updatebalance.MAccID = p_accID;

            _Market.WithdrawMoney(updatebalance);
        }
    }
}
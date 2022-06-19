namespace CoderBebopBL
{
    public interface iMarketBL
    {
        void AddMarketAcc(decimal p_account);

        void UpdateDeposit(int p_balance, int p_accID);

        void UpdateWithdraw(int p_balance, int p_accID);
    }
}
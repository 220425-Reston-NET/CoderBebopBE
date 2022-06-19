namespace CoderBebopBL
{
    public interface iSavingsBL
    {
        void AddSavingsAcc(decimal p_account);

        void UpdateDeposit(int p_balance, int p_accID);

        void UpdateWithdraw(int p_balance, int p_accID);
    }
}
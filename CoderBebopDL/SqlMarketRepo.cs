using CoderBebopModel;
using Microsoft.Data.SqlClient;

namespace CoderBebopDL
{
    public class SqlMarketRepo : iCoderBebopDL<MoneyMarketAccount>
    {
        
        private readonly string _connectionString;

        public SqlMarketRepo(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void AddChecking(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddCus(MoneyMarketAccount p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddMonMarket(decimal p_resource)
        {
            string SQLQuery = @"insert into marAccount
                                values ('Money Market',@accNumber,0,'Test')";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@accNumber", p_resource);

                command.ExecuteNonQuery();
            }
        }

        public void AddSavings(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void checkbalance(int p_resource)
        {
            throw new NotImplementedException();
        }

        public void DepositMoney(MoneyMarketAccount p_resource)
        {
            string SQLQuery = @"update marAccount
                                set marAccBalance = marAccBalance + @marAccBalance
                                where marAccID = @marAccID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@marAccBalance", p_resource.MAccBalance);
                command.Parameters.AddWithValue("@marAccID", p_resource.MAccID);

                command.ExecuteNonQuery();
            }
        }

        public List<MoneyMarketAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public void JoinTable(MoneyMarketAccount p_resource)
        {
            throw new NotImplementedException();
        }

        public void verify(decimal p_resource, int p_resource1)
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney(MoneyMarketAccount p_resource)
        {
            string SQLQuery = @"update marAccount
                                set marAccBalance = marAccBalance - @marAccBalance
                                where marAccID = @marAccID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@marAccBalance", p_resource.MAccBalance);
                command.Parameters.AddWithValue("@marAccID", p_resource.MAccID);

                command.ExecuteNonQuery();
            }
        }
    }


}
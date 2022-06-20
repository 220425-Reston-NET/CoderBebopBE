using CoderBebopModel;
using Microsoft.Data.SqlClient;

namespace CoderBebopDL
{
    public class SqlSavingRepo : iCoderBebopDL<SavingsAccount>
    {
        
        private readonly string _connectionString;

        public SqlSavingRepo(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void AddChecking(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddCus(SavingsAccount p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddMonMarket(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddSavings(decimal p_resource)
        {
            string SQLQuery = @"insert into savAccount
                                values ('Savings',@accNumber,0,'Test')";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@accNumber", p_resource);

                command.ExecuteNonQuery();
            }
        }

        public void DepositMoney(SavingsAccount p_resource)
        {
            string SQLQuery = @"update savAccount
                                set savAccBalance = savAccBalance + @savAccBalance
                                where savAccID = @savAccID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@savAccBalance", p_resource.SAccBalance);
                command.Parameters.AddWithValue("@savAccID", p_resource.SAccID);

                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void JoinTable(SavingsAccount p_resource)
        {
            throw new NotImplementedException();
        }

        public void verify(decimal p_resource, int p_resource1)
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney(SavingsAccount p_resource)
        {
             string SQLQuery = @"update savAccount
                                set savAccBalance = savAccBalance - @savAccBalance
                                where savAccID = @savAccID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@savAccBalance", p_resource.SAccBalance);
                command.Parameters.AddWithValue("@savAccID", p_resource.SAccID);

                command.ExecuteNonQuery();
            }
        }
    }


}
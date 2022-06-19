using CoderBebopModel;
using Microsoft.Data.SqlClient;

namespace CoderBebopDL
{
    public class SqlCheckingRepo : iCoderBebopDL<CheckingAccount>
    {
        
        private readonly string _connectionString;

        public SqlCheckingRepo(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void AddChecking(decimal p_resource)
        {
            string SQLQuery = @"insert into account
                                values ('Checking',@accNumber,0,'Test')";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@accNumber", p_resource);

                command.ExecuteNonQuery();
            }
        }

        public void AddCus(CheckingAccount p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddMonMarket(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddSavings(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void DepositMoney(CheckingAccount p_resource)
        {
            string SQLQuery = @"update account
                                set accBalance = accBalance + @accBalance
                                where accID = @accID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@accBalance", p_resource.CAccBalance);
                command.Parameters.AddWithValue("@accID", p_resource.CAccID);

                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void JoinTable(CheckingAccount p_resource)
        {
            throw new NotImplementedException();
        }

        public void verify(decimal p_resource, int p_resource1)
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney(CheckingAccount p_resource)
        {
           string SQLQuery = @"update account
                                set accBalance = accBalance - @accBalance
                                where accID = @accID";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@accBalance", p_resource.CAccBalance);
                command.Parameters.AddWithValue("@accID", p_resource.CAccID);

                command.ExecuteNonQuery();
            }
        }

    }
}
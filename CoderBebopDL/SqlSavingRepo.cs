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

        public void checkbalance(int p_resource)
        {
            string SQLQuery = @"select s.savAccID, b.bcustName, s.savAccType, s.savAccBalance from bankCustomer b
                                inner join bankCard bc on b.bcustID = bc.bcustID
                                inner join savAccount s on bc.savAccID = s.SavAccID
                                where bc.cardPin = @Pin";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@accBalance", p_resource);


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

        public List<SavingsAccount> GetAll()
        {
            string SQLQuery = @"select s.savAccID, b.bcustName, s.savAccType, s.savAccBalance from bankCustomer b
                                inner join bankCard bc on b.bcustID = bc.bcustID
                                inner join savAccount s on bc.savAccID = s.SavAccID";
            List<SavingsAccount> listofcustomer = new List<SavingsAccount>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofcustomer.Add(new SavingsAccount(){
                        SAccID = reader.GetInt32(0),
                        sName = reader.GetString(1),
                        SAccType = reader.GetString(2),
                        SAccBalance = reader.GetDecimal(3)
                        
                });
                    
            }
            return listofcustomer;
        }
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
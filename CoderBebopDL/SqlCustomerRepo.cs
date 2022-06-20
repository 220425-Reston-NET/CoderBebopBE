
using CoderBebopModel;
using Microsoft.Data.SqlClient;

namespace CoderBebopDL
{
    public class SqlCustomerRepo : iCoderBebopDL<Customer>
    {
        
        private readonly string _connectionString;

        public SqlCustomerRepo(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void AddChecking(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddCus(Customer p_resource)
        {
            string SQLQuery = @"insert into bankCustomer
                                values (@CusName,@CusPhone,@CusAddress,@cusEmail)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@CusName", p_resource.Name);
                command.Parameters.AddWithValue("@CusPhone", p_resource.Phone);
                command.Parameters.AddWithValue("@CusAddress", p_resource.Address);
                command.Parameters.AddWithValue("@cusEmail", p_resource.Email);

                command.ExecuteNonQuery();
            }
        }

        public void AddMonMarket(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddSavings(decimal p_resource)
        {
            throw new NotImplementedException();
        }

        public void DepositMoney(Customer p_resource)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            string SQLQuery = @"select b.bcustName, b.bPhoneNumber, b.bAddress, b.bEmail, bc.cardNumber from bankCustomer b
                                inner join bankCard bc on b.bcustID = bc.bcustID;";
            List<Customer> listofcustomer = new List<Customer>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofcustomer.Add(new Customer(){

                        Name = reader.GetString(0),
                        Phone = reader.GetString(1),
                        Address = reader.GetString(2),
                        Email = reader.GetString(3),
                        CardNumber = reader.GetDecimal(4)
                    });
                }
                
                return listofcustomer;
            }
        }

        public void JoinTable(Customer p_resource)
        {
            p_resource.CustID = p_resource.CAccID;
            p_resource.CAccID = p_resource.SAccID;
            p_resource.SAccID = p_resource.MAccID;

            string SQLQuery = @"insert into bankCard
                                 values (@bcustID,@accID,@savAccID,@marAccBalance,@cardPin,@cardNumber)";

             using (SqlConnection con = new SqlConnection(_connectionString))
             {
                 con.Open();
                 SqlCommand command = new SqlCommand(SQLQuery, con);

                 command.Parameters.AddWithValue("@bcustID", p_resource.CustID);
                 command.Parameters.AddWithValue("@accID", p_resource.CAccID);
                 command.Parameters.AddWithValue("@savAccID", p_resource.SAccID);
                 command.Parameters.AddWithValue("@marAccBalance", p_resource.MAccID);
                 command.Parameters.AddWithValue("@cardPin", p_resource.Pin);
                 command.Parameters.AddWithValue("@cardNumber", p_resource.CardNumber);    

                 command.ExecuteNonQuery();
             }
        }

        public void verify(decimal p_resource, int p_resource1)
        {
            string SQLQuery = @"select b.bcustName, b.bPhoneNumber, b.bAddress, b.bEmail, bc.cardNumber from bankCustomer b
                                inner join bankCard bc on b.bcustID = bc.bcustID
                                where bc.cardNumber = @cardNumber and bc.cardPin = @Pin;";

             using(SqlConnection con = new SqlConnection(_connectionString))
             {
                 con.Open();

                 SqlCommand command = new SqlCommand(SQLQuery, con);


                 command.Parameters.AddWithValue("@cardNumber", p_resource);
                 command.Parameters.AddWithValue("@Pin", p_resource1);

                 command.ExecuteNonQuery();
             }
        }

        public void WithdrawMoney(Customer p_resource)
        {
            throw new NotImplementedException();
        }
    }
}
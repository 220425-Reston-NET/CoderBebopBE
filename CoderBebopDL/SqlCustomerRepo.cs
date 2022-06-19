
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

        public void AddJoin(Customer p_resource)
        {
            string SQLQuery = @"insert into CusCard
                                 values (@CusID,@PinID,@CardNumber,@AccountNumber)";

             using (SqlConnection con = new SqlConnection(_connectionString))
             {
                 con.Open();
                 SqlCommand command = new SqlCommand(SQLQuery, con);

                 command.Parameters.AddWithValue("@CusID", p_resource.CustID);
                 command.Parameters.AddWithValue("@PinID", p_resource.PinID);
                 command.Parameters.AddWithValue("@CardNumber", p_resource.CardNumber);
                 command.Parameters.AddWithValue("@AccountNumber", p_resource.AccNumber);    

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
            string SQLQuery = @"select c.CusName, c.CusPhone, c.CusAddress, c.cusEmail, cu.AccNumber from Customer c
                                inner join CusCard cu on c.CusID = cu.CusID
                                inner join pin p on cu.PinID = p.PinID;";
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
                        AccNumber = reader.GetDecimal(4)
                    });
                }
                
                return listofcustomer;
            }
        }

        public void JoinTable(Customer p_resource)
        {
            throw new NotImplementedException();
        }

        public void verify(decimal p_resource, int p_resource1)
        {
            string SQLQuery = @"select c.CusName, c.CusPhone, c.CusAddress, cu.AccNumber from Customer c
                                 inner join CusCard cu on c.CusID = cu.CusID
                                 inner join pin p on cu.PinID = p.PinID
                                 where cu.CardNumber = @CardNumber and p.Pin = @Pin";

             using(SqlConnection con = new SqlConnection(_connectionString))
             {
                 con.Open();

                 SqlCommand command = new SqlCommand(SQLQuery, con);


                 command.Parameters.AddWithValue("@CardNumber", p_resource);
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
using Microsoft.Data.SqlClient;
using CoderBebopModel;

namespace CoderBebopDL
{
    public class SqlCustomerRepo : iCoderBebopDL<Customer>
    {
        
        private readonly string _connectionString;

        public SqlCustomerRepo(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void Add(Customer p_resource)
        {
            string SQLQuery = @"insert into Customer
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

        public void AddPin(Customer p_resource)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            string SQLQuery = @"Select * from Customer";
            List<Customer> listofcustomer = new List<Customer>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofcustomer.Add(new Customer(){

                        Name = reader.GetString(1),
                        Phone = reader.GetString(2),
                        Address = reader.GetString(3),
                        Email = reader.GetString(4)
                    });
                }
                
                return listofcustomer;
            }
        }

        public void verify(decimal p_resource, int p_resource1)
        {
            throw new NotImplementedException();
        }
    }
}
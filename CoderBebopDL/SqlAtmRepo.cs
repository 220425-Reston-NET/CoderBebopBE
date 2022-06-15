

using CoderBebopModel;
using Microsoft.Data.SqlClient;

namespace CoderBebopDL
{
    public class SqlAtmRepo : iCoderBebopDL<Atm>
    {
        private readonly string _connectionString;

        public SqlAtmRepo(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void Add(Atm p_resource)
        {
            string SQLQuery = @"insert into CusCard
                                values (@CusID,@CardNumber,@AccountNumber)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@CusID", p_resource.CusID);
                command.Parameters.AddWithValue("@CusPhone", p_resource.CardNumber);
                command.Parameters.AddWithValue("@CusAddress", p_resource.AccNumber);    

                command.ExecuteNonQuery();
            }
        }

        public void AddPin(Atm p_resource)
        {
            string SQLQuery = @"insert into Pin
                                values (@PinID,@Pin)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@PinID", p_resource.PinID);
                command.Parameters.AddWithValue("@Pin", p_resource.Pin);

                command.ExecuteNonQuery();
            }
        }

        public List<Atm> GetAll()
        {
            throw new NotImplementedException();

        }

        public void verify(decimal p_resource, int p_resource1)
        {
            string SQLQuery = @"select c.CusName, c.CusPhone, c.CusAddress, cu.AccNumber from Customer c
                                nner join CusCard cu on c.CusID = cu.CusID
                                inner join pin p on cu.CusCardID = p.pinID
                                where cu.CardNumber = @CardNumber and p.pin = @Pin";

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);


                command.Parameters.AddWithValue("@CardNumber", p_resource);
                command.Parameters.AddWithValue("@Pin", p_resource1);

                command.ExecuteNonQuery();
            }

        }
    }
}
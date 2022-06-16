

// using CoderBebopModel;
// using Microsoft.Data.SqlClient;

// namespace CoderBebopDL
// {
//     public class SqlAtmRepo : iCoderBebopDL<Atm>
//     {
//         private readonly string _connectionString;

//         public SqlAtmRepo(string connectionString)
//         {
//             this._connectionString = connectionString;
//         }
//         public void Add(Atm p_resource)
//         {
//             string SQLQuery = @"insert into CusCard
//                                 values (@CusID,@PinID,@CardNumber,@AccountNumber)";

//             using (SqlConnection con = new SqlConnection(_connectionString))
//             {
//                 con.Open();
//                 SqlCommand command = new SqlCommand(SQLQuery, con);

//                 command.Parameters.AddWithValue("@CusID", p_resource.CusID);
//                 command.Parameters.AddWithValue("@PinID", p_resource.PinID);
//                 command.Parameters.AddWithValue("@CardNumber", p_resource.CardNumber);
//                 command.Parameters.AddWithValue("@AccountNumber", p_resource.AccNumber);    

//                 command.ExecuteNonQuery();
//             }
//         }

//         public void AddPin(int p_resource)
//         {
//             string SQLQuery = @"insert into Pin
//                                 values (@Pin)";

//             using (SqlConnection con = new SqlConnection(_connectionString))
//             {
//                 con.Open();
//                 SqlCommand command = new SqlCommand(SQLQuery, con);

//                 command.Parameters.AddWithValue("@Pin", p_resource);

//                 command.ExecuteNonQuery();
//             }
//         }

//         public List<Customer> GetAll()
//         {
//             string SQLQuery = @"select c.CusName, c.CusPhone, c.CusAddress, c.cusEmail, cu.AccNumber from Customer c
//                                 inner join CusCard cu on c.CusID = cu.CusID
//                                 inner join pin p on cu.PinID = p.PinID;";
//             List<Customer> listofcustomer = new List<Customer>();

//             using (SqlConnection con = new SqlConnection(_connectionString))
//             {
//                 con.Open();

//                 SqlCommand command = new SqlCommand(SQLQuery, con);

//                 SqlDataReader reader = command.ExecuteReader();

//                 while (reader.Read())
//                 {
//                     listofcustomer.Add(new Customer(){

//                         Name = reader.GetString(0),
//                         Phone = reader.GetString(1),
//                         Address = reader.GetString(2),
//                         Email = reader.GetString(3),
//                         AccNumber = reader.GetDecimal(4)
//                     });
//                 }
                
//                 return listofcustomer;
//             }

//         }

//         public void verify(decimal p_resource, int p_resource1)
//         {
//             string SQLQuery = @"select c.CusName, c.CusPhone, c.CusAddress, cu.AccNumber from Customer c
//                                 inner join CusCard cu on c.CusID = cu.CusID
//                                 inner join pin p on cu.PinID = p.PinID
//                                 where cu.CardNumber = @CardNumber and p.Pin = @Pin";

//             using(SqlConnection con = new SqlConnection(_connectionString))
//             {
//                 con.Open();

//                 SqlCommand command = new SqlCommand(SQLQuery, con);


//                 command.Parameters.AddWithValue("@CardNumber", p_resource);
//                 command.Parameters.AddWithValue("@Pin", p_resource1);

//                 command.ExecuteNonQuery();
//             }

//         }
//     }
// }
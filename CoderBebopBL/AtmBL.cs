// using CoderBebopModel;
// using CoderBebopDL;

// namespace CoderBebopBL
// {
//     public class AtmBL : iAtmBL
//     {
//         private readonly iCoderBebopDL<Atm> _Atm;
//         private readonly iCoderBebopDL<Customer> _Customer;
//         public AtmBL(iCoderBebopDL<Atm> p_Atm, iCoderBebopDL<Customer> customer)
//         {
//             _Atm = p_Atm;
//             _Customer = customer;
//         }

//         public void Add(Atm p_Atm, Customer p_Customer)
//         {
//             Random rand = new Random();
//             p_Atm.AccNumber = rand.Next(50);
//             p_Atm.CardNumber = rand.Next(50);
//             p_Atm.Pin = rand.Next(50);

//             p_Customer.CustID = p_Atm.CusID;

//             p_Atm.CusID = p_Atm.PinID;

            


//             Atm FoundCustomer = Search(p_Atm.CardNumber, p_Atm.Pin);
//             if (FoundCustomer == null)
//             {
//                 _Atm.Add(p_Atm);
//                 _Atm.AddPin(p_Atm.Pin);
//             }
//             else
//             {
//                 throw new Exception("Customer already exist");
//             }
//         }

//         public List<Customer> GetAll()
//         {
//             return _Atm.GetAll();
//         }


//         public Atm Search(decimal p_Atm, decimal p1_Atm)
//         {
//             return _Atm.GetAll().First(Atm => Atm.CardNumber == p_Atm && Atm.Pin == p1_Atm);
//         }
//     }

// }
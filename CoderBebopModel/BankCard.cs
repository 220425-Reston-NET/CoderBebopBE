// using System.ComponentModel.DataAnnotations;


// namespace CoderBebopModel
// {
//     public class BankCard
//     {
//         // private int _cardId;

//         // public int CardID { 
//         // get {return _cardId; }
//         // set {
//         //     if (value > 0)
//         //     {
//         //         _cardId = value;
//         //     }
//         //     else
//         //     {
//         //         throw new ValidationException("CardID is not valid");
//         //     }
//         //     } 
//         // }

//         private decimal _cardNumber;

//         public decimal CardNumber { 
//         get {return _cardNumber; }
//         set {
//             if (value > 1000000000000000 && value < 9999999999999999)
//             {
//                 _cardNumber = value;
//             }
//             else
//             {
//                 throw new ValidationException("Card Number is not valid");
//             }
//             } 
//         }

//         // private int _pin;

//         // public int Pin { 
//         // get {return _pin; }
//         // set {
//         //     if (value > 1000 && value < 9999)
//         //     {
//         //         _pin = value;
//         //     }
//         //     else
//         //     {
//         //         throw new ValidationException("Card Number is not valid");
//         //     }
//         //     } 
//         // }
//     }
// }
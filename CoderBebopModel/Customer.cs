using System.ComponentModel.DataAnnotations;

namespace CoderBebopModel;
public class Customer
{
    private int _custId;

    public int CustID { 
        get {return _custId; }
        set {
            if (value >= 0)
            {
                _custId = value;
            }
            else
            {
                throw new ValidationException("CustID is not valid");
            }
        } 
    }

    public string Name { get; set; }
    private string _phone { get; set; }

    public string Phone { 
        get {return _phone; }
        set {
            if (value.Length == 10)
            {
                _phone = value;
            }
            else
            {
                throw new ValidationException("Phone Number is not valid");
            }
        } 
    }

    public string Address { get; set; }

    public string Email { get; set; }

     private decimal _accNumber;

        public decimal AccNumber { 
        get {return _accNumber; }
        set {
            if (value > 1000000000 && value < 9999999999)
            {
                _accNumber = value;
            }
            else
            {
                throw new ValidationException("Card Number is not valid");
            }
            } 
        }
        private decimal _cardNumber;

        public decimal CardNumber { 
        get {return _cardNumber; }
        set {
            if (value > 1000000000000000 && value < 9999999999999999)
            {
                _cardNumber = value;
            }
            else
            {
                throw new ValidationException("Card Number is not valid");
            }
            } 
        }
        private int _pin;

        public int Pin { 
        get {return _pin; }
        set {
            if (value > 1000 && value < 9999)
            {
                _pin = value;
            }
            else
            {
                throw new ValidationException("Card Number is not valid");
            }
            } 
        }
         private int _pinId;

        public int PinID { 
        get {return _pinId; }
        set {
            if (value > 0)
            {
                _pinId = value;
            }
            else
            {
                throw new ValidationException("Card Number is not valid");
            }
            } 
        }

        public int CAccID { get; set; }
        public int SAccID { get; set; }
        public int MAccID { get; set; }





}

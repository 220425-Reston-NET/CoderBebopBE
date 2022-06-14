using System.ComponentModel.DataAnnotations;


namespace CoderBebopModel
{
    public class Atm
    {
        private int _custCardId;

        public int CustCardID { 
        get {return _custCardId; }
        set {
            if (value > 0)
            {
                _custCardId = value;
            }
            else
            {
                throw new ValidationException("CustCardID is not valid");
            }
            } 
        }

        private int _cusId;

        public int CusID { 
        get {return _cusId; }
        set {
            if (value > 0)
            {
                _cusId = value;
            }
            else
            {
                throw new ValidationException("CusID is not valid");
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
    }
}
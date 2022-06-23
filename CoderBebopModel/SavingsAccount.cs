using System.ComponentModel.DataAnnotations;

namespace CoderBebopModel
{
    public class SavingsAccount
    {
        private int _saccId;
        public int SAccID { 
            get {return _saccId;}
            set
            {
                if (value > 0)
                {
                    _saccId = value;
                }
                else
                {
                    throw new ValidationException("ID is invalid. Must be above 0.");
                }
            }
        }

        public String SAccType { get; set; }
        public Decimal SAccNumber { get; set; }
        private Double _SAccBalance;
        public Double SAccBalance{
            get {return _SAccBalance;}
            set
            {
                if(value > 0)
                {
                    _SAccBalance = value;
                }
                else{
                    throw new ValidationException("Your balance must be greater than 0");
                }
            }
        }
        public String SAccHistory { get; set; }
    }
}
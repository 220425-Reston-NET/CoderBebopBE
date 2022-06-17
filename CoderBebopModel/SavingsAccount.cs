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
        public Double SAccBalance { get; set; }
        public String SAccHistory { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CoderBebopModel
{
    public class MoneyMarketAccount
    {
        private int _maccId;
        public int MAccID { 
            get {return _maccId;}
            set
            {
                if (value > 0)
                {
                    _maccId = value;
                }
                else
                {
                    throw new ValidationException("ID is invalid. Must be above 0.");
                }
            }
        }

        public String MAccType { get; set; }
        public Decimal MAccNumber { get; set; }
       private Double _MAccBalance;
        public Double MAccBalance{
            get {return _MAccBalance;}
            set
            {
                if(value > 0)
                {
                    _MAccBalance = value;
                }
                else{
                    throw new ValidationException("Your balance must be greater than 0");
                }
            }
        }
        public String MAccHistory { get; set; }
    }
}